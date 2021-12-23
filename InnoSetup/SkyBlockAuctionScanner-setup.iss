#define MyAppName "SkyBlockAuctionScanner"
#define MyAppFullName "SkyBlock Auction Scanner"
#define MyAppRootDirectory ".."
#define MyAppOutputDirectory MyAppRootDirectory + "\Output"
#define MyAppReleaseDirectory MyAppRootDirectory + "\" + MyAppName + "\bin\Release"
#define MyAppFileName MyAppName + ".exe"
#define MyAppFilePath MyAppReleaseDirectory + "\" + MyAppFileName
#dim Version[4]
#expr GetVersionComponents(MyAppFilePath, Version[0], Version[1], Version[2], Version[3])
#define MyAppVersion Str(Version[0]) + "." + Str(Version[1]) + "." + Str(Version[2])
#define MyAppPublisher "Jaex"
#define MyAppURL "https://github.com/Jaex/SkyBlockAuctionScanner"
#define MyAppId "5e6049df-88fc-4454-a0ee-53dcf130c52f"

[Setup]
AppCopyright=Copyright (c) {#MyAppPublisher}
AppId={#MyAppId}
AppMutex={#MyAppId}
AppName={#MyAppFullName}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppVerName={#MyAppFullName} {#MyAppVersion}
AppVersion={#MyAppVersion}
ArchitecturesAllowed=x86 x64 arm64 ia64
ArchitecturesInstallIn64BitMode=x64 ia64
DefaultDirName={commonpf}\{#MyAppFullName}
DefaultGroupName={#MyAppFullName}
DisableProgramGroupPage=yes
LicenseFile={#MyAppRootDirectory}\LICENSE.txt
MinVersion=6.1sp1
OutputBaseFilename={#MyAppName}-{#MyAppVersion}-setup
OutputDir={#MyAppOutputDirectory}
PrivilegesRequired=none
SolidCompression=yes
UninstallDisplayIcon={app}\{#MyAppFileName}
UninstallDisplayName={#MyAppFullName}
VersionInfoCompany={#MyAppPublisher}
VersionInfoTextVersion={#MyAppVersion}
VersionInfoVersion={#MyAppVersion}

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"

[Files]
Source: "{#MyAppFilePath}"; DestDir: {app}; Flags: ignoreversion
Source: "{#MyAppFilePath}.config"; DestDir: {app}; Flags: ignoreversion
Source: "{#MyAppReleaseDirectory}\*.dll"; DestDir: {app}; Flags: ignoreversion
Source: "{#MyAppRootDirectory}\LICENSE.txt"; DestDir: {app}; Flags: ignoreversion

[Icons]
Name: "{group}\{#MyAppFullName}"; Filename: "{app}\{#MyAppFileName}"; WorkingDir: "{app}"
Name: "{group}\{cm:UninstallProgram,{#MyAppFullName}}"; Filename: "{uninstallexe}"; WorkingDir: "{app}"
Name: "{commondesktop}\{#MyAppFullName}"; Filename: "{app}\{#MyAppFileName}"; WorkingDir: "{app}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppFileName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppFullName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent