# Run with Windows PowerShell from a Visual Studio Developer PowerShell.
[CmdletBinding()]
param(
    [Parameter(Mandatory = $true)]
    [string]$OutputPath,

    [string]$MSBuildPath = 'MSBuild.exe'
)

$ErrorActionPreference = 'Stop'
$msbuild = (Get-Command $MSBuildPath -CommandType Application).Source
$projectName = 'ECHAVEZ_PF101_PROJECT'
$project = Join-Path $PSScriptRoot "$projectName\$projectName\$projectName.vbproj"
$zipPath = $ExecutionContext.SessionState.Path.GetUnresolvedProviderPathFromPSPath($OutputPath)
if ([IO.Path]::GetExtension($zipPath) -ne '.zip') {
    throw 'OutputPath must name a .zip file.'
}

$id = [Guid]::NewGuid().ToString('N')
$staging = Join-Path ([IO.Path]::GetTempPath()) "pf101-release-$id"
$buildOutput = Join-Path $staging 'bin'
$intermediate = Join-Path $staging 'obj'
$zipDirectory = [IO.Path]::GetDirectoryName($zipPath)
$pendingZip = Join-Path $zipDirectory "pf101-release-$id.zip"

try {
    New-Item -ItemType Directory -Path $staging | Out-Null
    & $msbuild $project /nologo /t:Rebuild /p:Configuration=Release /p:Platform=AnyCPU `
        "/p:OutDir=$buildOutput/" "/p:BaseIntermediateOutputPath=$intermediate/"
    if ($LASTEXITCODE -ne 0) {
        throw "Release build failed with exit code $LASTEXITCODE."
    }

    $requiredFiles = @(
        "$projectName.exe"
        "$projectName.exe.config"
        'Assets\background.gif'
        'Assets\player.png'
        'Assets\food.png'
        'Assets\hazard.png'
        'Assets\Bomb.png'
    )
    foreach ($relativePath in $requiredFiles) {
        if (-not (Test-Path -LiteralPath (Join-Path $buildOutput $relativePath) -PathType Leaf)) {
            throw "Release output is missing $relativePath."
        }
    }

    Add-Type -AssemblyName System.IO.Compression.FileSystem
    [IO.Directory]::CreateDirectory($zipDirectory) | Out-Null
    [IO.Compression.ZipFile]::CreateFromDirectory($buildOutput, $pendingZip)
    if ([IO.File]::Exists($zipPath)) {
        [IO.File]::Replace($pendingZip, $zipPath, [NullString]::Value)
    } else {
        [IO.File]::Move($pendingZip, $zipPath)
    }
    Write-Output $zipPath
} finally {
    if ([IO.File]::Exists($pendingZip)) { [IO.File]::Delete($pendingZip) }
    if ([IO.Directory]::Exists($staging)) { [IO.Directory]::Delete($staging, $true) }
}
