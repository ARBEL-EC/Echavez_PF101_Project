; Compile with Inno Setup 6.3 or later via Package-Release.ps1.
#ifndef PayloadDir
  #error Supply the validated Release payload using Package-Release.ps1 -BuildInstaller.
#endif

#define ProjectName "ECHAVEZ_PF101_PROJECT"
#define ProjectVersion "1.0.0.0"
#define Publisher "Arlvel L. Echavez"
#define AppExe ProjectName + ".exe"

[Setup]
AppId={{E71AA044-2161-4B36-9F61-9BF6708E256A}
AppName={#ProjectName}
AppVersion={#ProjectVersion}
AppPublisher={#Publisher}
VersionInfoCompany={#Publisher}
VersionInfoDescription=PF101 Object-Oriented Programming Portfolio Installer
VersionInfoVersion={#ProjectVersion}
DefaultDirName={localappdata}\Programs\{#ProjectName}
DefaultGroupName={#ProjectName}
DisableProgramGroupPage=yes
PrivilegesRequired=lowest
MinVersion=10.0
; The Any CPU application ships with x86 and x64 SQLite libraries.
ArchitecturesAllowed=x86os or x64os
UninstallDisplayName={#ProjectName}
UninstallDisplayIcon={app}\{#AppExe}
CloseApplications=yes
RestartApplications=no
WizardStyle=modern
OutputBaseFilename={#ProjectName}_Setup

[Tasks]
Name: "desktopicon"; Description: "Create a desktop shortcut"; GroupDescription: "Additional shortcuts"; Flags: unchecked

[Files]
; Install the runtime files only. The application creates its databases under Local AppData on first use.
Source: "{#PayloadDir}\{#AppExe}"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#PayloadDir}\{#AppExe}.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#PayloadDir}\Microsoft.Data.Sqlite.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#PayloadDir}\SQLitePCLRaw.batteries_v2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#PayloadDir}\SQLitePCLRaw.core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#PayloadDir}\SQLitePCLRaw.provider.dynamic_cdecl.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#PayloadDir}\System.Buffers.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#PayloadDir}\System.Memory.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#PayloadDir}\System.Numerics.Vectors.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#PayloadDir}\System.Runtime.CompilerServices.Unsafe.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#PayloadDir}\SQLite-NOTICES.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#PayloadDir}\Assets\background.gif"; DestDir: "{app}\Assets"; Flags: ignoreversion
Source: "{#PayloadDir}\Assets\player.png"; DestDir: "{app}\Assets"; Flags: ignoreversion
Source: "{#PayloadDir}\Assets\food.png"; DestDir: "{app}\Assets"; Flags: ignoreversion
Source: "{#PayloadDir}\Assets\hazard.png"; DestDir: "{app}\Assets"; Flags: ignoreversion
Source: "{#PayloadDir}\Assets\Bomb.png"; DestDir: "{app}\Assets"; Flags: ignoreversion
Source: "{#PayloadDir}\runtimes\win-x86\native\e_sqlite3.dll"; DestDir: "{app}\runtimes\win-x86\native"; Flags: ignoreversion
Source: "{#PayloadDir}\runtimes\win-x64\native\e_sqlite3.dll"; DestDir: "{app}\runtimes\win-x64\native"; Flags: ignoreversion

[Icons]
Name: "{group}\{#ProjectName}"; Filename: "{app}\{#AppExe}"; WorkingDir: "{app}"
Name: "{autodesktop}\{#ProjectName}"; Filename: "{app}\{#AppExe}"; WorkingDir: "{app}"; Tasks: desktopicon

[Code]
const
  FrameworkKey = 'SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full';
  // Microsoft documents 461808 as the lowest Release value for .NET Framework 4.7.2.
  FrameworkMinimumRelease = 461808;
  FrameworkRequiredMessage =
    'Install Microsoft .NET Framework 4.7.2 or a later compatible .NET Framework 4.x version, then run setup again.';

function InitializeSetup(): Boolean;
var
  FrameworkRelease: Cardinal;
begin
  Result := False;
  if RegQueryDWordValue(HKLM32, FrameworkKey, 'Release', FrameworkRelease) then
    Result := FrameworkRelease >= FrameworkMinimumRelease;

  if not Result and IsWin64 then
    if RegQueryDWordValue(HKLM64, FrameworkKey, 'Release', FrameworkRelease) then
      Result := FrameworkRelease >= FrameworkMinimumRelease;

  if not Result then
  begin
    Log(FrameworkRequiredMessage);
    if not WizardSilent then
      MsgBox(FrameworkRequiredMessage, mbError, MB_OK);
  end;
end;
