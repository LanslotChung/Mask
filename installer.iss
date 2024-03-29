; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Mask"
#define MyAppVersion "1.0"
#define MyAppPublisher "zxLanslot, Inc."
#define MyAppExeName "Mask.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{5E67EEC8-DC63-4D0F-BCD4-87699320A2B0}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName=C:\software\{#MyAppName}
DisableDirPage=yes
DefaultGroupName={#MyAppName}
DisableProgramGroupPage=yes
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputDir=C:\Users\exLan\OneDrive\Projects\Mask
OutputBaseFilename=MaskInstaller
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Files]
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\Config.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\Config.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\config.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\Config.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\GameOverlay.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\GameOverlay.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\Mask.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\Mask.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\Mask.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\MaskProtector.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\MaskProtector.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\MaskProtector.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\Newtonsoft.Json.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\SharpDX.Direct2D1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\SharpDX.Direct2D1.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\SharpDX.Direct2D1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\SharpDX.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\SharpDX.DXGI.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\SharpDX.DXGI.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\SharpDX.DXGI.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\SharpDX.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\config.ini"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\zxing.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\zxing.presentation.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\zxing.presentation.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\exLan\OneDrive\Projects\Mask\bin\Debug\zxing.xml"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[registry]
Root:HKLM;Subkey:SOFTWARE\Microsoft\Windows\CurrentVersion\Run;ValueType: string; ValueName:Mask;ValueData:{app}\Mask.exe;Flags: uninsdeletevalue

[Code]
function AskPassword(): Boolean;
var
  Form: TSetupForm;
  OKButton, CancelButton: TButton;
  PwdEdit: TPasswordEdit;
  Password: String;
begin
  Result := false;
  Form := CreateCustomForm();
  try
    Form.ClientWidth := ScaleX(256);
    Form.ClientHeight := ScaleY(100);
    Form.Caption := 'Uninstall Password';
    Form.BorderIcons := [biSystemMenu];
    Form.BorderStyle := bsDialog;

    OKButton := TButton.Create(Form);
    OKButton.Parent := Form;
    OKButton.Width := ScaleX(75);
    OKButton.Height := ScaleY(23);
    OKButton.Left := Form.ClientWidth - ScaleX(75 + 6 + 75 + 50);
    OKButton.Top := Form.ClientHeight - ScaleY(23 + 10);
    OKButton.Caption := 'OK';
    OKButton.ModalResult := mrOk;
    OKButton.Default := true;

    CancelButton := TButton.Create(Form);
    CancelButton.Parent := Form;
    CancelButton.Width := ScaleX(75);
    CancelButton.Height := ScaleY(23);
    CancelButton.Left := Form.ClientWidth - ScaleX(75 + 50);
    CancelButton.Top := Form.ClientHeight - ScaleY(23 + 10);
    CancelButton.Caption := 'Cancel';
    CancelButton.ModalResult := mrCancel;
    CancelButton.Cancel := True;

    PwdEdit := TPasswordEdit.Create(Form);
    PwdEdit.Parent := Form;
    PwdEdit.Width := ScaleX(210);
    PwdEdit.Height := ScaleY(23);
    PwdEdit.Left := ScaleX(23);
    PwdEdit.Top := ScaleY(23);

    Form.ActiveControl := PwdEdit;

    Password := 'Root';
    //if RegKeyExists(HKLM32, 'Software\Mask') then
    //  begin
    //    RegQueryStringValue(HKLM32, 'Software\Mask', 'Password', Password);
    //  end;
    //if IsWin64 then
    //begin
    //  if RegKeyExists(HKLM64, 'Software\Mask') then
    //  begin
    //    RegQueryStringValue(HKLM64, 'Software\Mask', 'Password', Password);
    //  end;
    //end;

    Password := GetIniString('secure','password','Root',ExpandConstant('{app}\config.ini'));
    
    if Form.ShowModal() = mrOk then
    begin
      Result := PwdEdit.Text = Password;
      if not Result then
        MsgBox('Password incorrect: Uninstallation prohibited.', mbInformation, MB_OK);
    end;
  finally
    Form.Free();
  end;
end;


function InitializeUninstall(): Boolean;
begin
  Result := AskPassword();
end;

