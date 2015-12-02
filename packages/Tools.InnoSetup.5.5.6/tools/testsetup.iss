#define   Name       "RadioStation"
#define   Version    GetFileVersion("F:\Мои документы\GitHub\RadioStation\Radio Station\bin\Release\Radio Station.exe")
#define   Publisher  "Anton"
#define   URL        "http://antonde@ukr.net"
#define   ExeName    "RadioStation.exe"

[Setup]

AppId = {{4277ECF3-4AA0-491F-AF0D-F58173FDB9EA}

AppName={#Name}
AppVersion={#Version}
AppPublisher={#Publisher}
AppPublisherURL={#URL}
AppSupportURL={#URL}
AppUpdatesURL={#URL}


DefaultDirName={pf}\{#Name}
DefaultGroupName={#Name}

OutputDir=F:\radio\test-setup
OutputBaseFileName={#Name}-{#Version}

Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl";
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl";

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "F:\Мои документы\GitHub\RadioStation\Radio Station\bin\Release\Radio Station.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Мои документы\GitHub\RadioStation\Radio Station\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

