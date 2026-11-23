# Run with Windows PowerShell from a Visual Studio Developer PowerShell.
[CmdletBinding()]
param(
    [Parameter(Mandatory = $true)]
    [string]$OutputPath,

    [string]$MSBuildPath = 'MSBuild.exe',

    [switch]$BuildInstaller,

    [string]$InnoSetupPath = 'ISCC.exe'
)

$ErrorActionPreference = 'Stop'
$msbuild = (Get-Command $MSBuildPath -CommandType Application).Source
if ($BuildInstaller) {
    $iscc = (Get-Command $InnoSetupPath -CommandType Application).Source
    $installerScript = Join-Path $PSScriptRoot 'Installer\PF101.iss'
}
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
$payload = Join-Path $staging 'payload'
$zipDirectory = [IO.Path]::GetDirectoryName($zipPath)
$pendingZip = Join-Path $zipDirectory "pf101-release-$id.zip"
$pendingInstaller = $null

function Publish-ReleaseFile([string]$StagedFile, [string]$Destination) {
    if ([IO.File]::Exists($Destination)) {
        [IO.File]::Replace($StagedFile, $Destination, [NullString]::Value)
    } else {
        [IO.File]::Move($StagedFile, $Destination)
    }
}

try {
    New-Item -ItemType Directory -Path $staging | Out-Null
    & $msbuild $project /nologo /restore /t:Rebuild /p:RestoreLockedMode=true /p:Configuration=Release /p:Platform=AnyCPU `
        "/p:OutDir=$buildOutput/" "/p:BaseIntermediateOutputPath=$intermediate/"
    if ($LASTEXITCODE -ne 0) {
        throw "Release build failed with exit code $LASTEXITCODE."
    }

    $requiredFiles = @(
        "$projectName.exe"
        "$projectName.exe.config"
        'Microsoft.Data.Sqlite.dll'
        'SQLitePCLRaw.batteries_v2.dll'
        'SQLitePCLRaw.core.dll'
        'SQLitePCLRaw.provider.dynamic_cdecl.dll'
        'System.Buffers.dll'
        'System.Memory.dll'
        'System.Numerics.Vectors.dll'
        'System.Runtime.CompilerServices.Unsafe.dll'
        'runtimes\win-x86\native\e_sqlite3.dll'
        'runtimes\win-x64\native\e_sqlite3.dll'
        'SQLite-NOTICES.txt'
        'Assets\background.gif'
        'Assets\player.png'
        'Assets\food.png'
        'Assets\hazard.png'
        'Assets\Bomb.png'
    )
    foreach ($relativePath in $requiredFiles) {
        $source = Join-Path $buildOutput $relativePath
        if (-not (Test-Path -LiteralPath $source -PathType Leaf)) {
            throw "Release output is missing $relativePath."
        }
        $destination = Join-Path $payload $relativePath
        [IO.Directory]::CreateDirectory([IO.Path]::GetDirectoryName($destination)) | Out-Null
        [IO.File]::Copy($source, $destination)
    }

    Add-Type -AssemblyName System.IO.Compression.FileSystem
    [IO.Directory]::CreateDirectory($zipDirectory) | Out-Null
    [IO.Compression.ZipFile]::CreateFromDirectory($payload, $pendingZip)

    if ($BuildInstaller) {
        $setupName = "${projectName}_Setup.exe"
        $installerOutput = Join-Path $staging 'installer'
        $compiledInstaller = Join-Path $installerOutput $setupName
        $installerPath = Join-Path $zipDirectory $setupName
        $pendingInstaller = Join-Path $zipDirectory "pf101-setup-$id.exe"

        [IO.Directory]::CreateDirectory($installerOutput) | Out-Null
        & $iscc "/DPayloadDir=$payload" "/O$installerOutput" $installerScript
        if ($LASTEXITCODE -ne 0) {
            throw "Inno Setup compilation failed with exit code $LASTEXITCODE."
        }
        if (-not (Test-Path -LiteralPath $compiledInstaller -PathType Leaf)) {
            throw "Inno Setup did not produce $setupName."
        }
        [IO.File]::Copy($compiledInstaller, $pendingInstaller)
    }

    Publish-ReleaseFile $pendingZip $zipPath
    if ($BuildInstaller) {
        Publish-ReleaseFile $pendingInstaller $installerPath
    }

    Write-Output $zipPath
    if ($BuildInstaller) {
        Write-Output $installerPath
    }
} finally {
    if ([IO.File]::Exists($pendingZip)) { [IO.File]::Delete($pendingZip) }
    if ($pendingInstaller -and [IO.File]::Exists($pendingInstaller)) { [IO.File]::Delete($pendingInstaller) }
    if ([IO.Directory]::Exists($staging)) { [IO.Directory]::Delete($staging, $true) }
}
