; YTVL Installer NSIS Script
; get NSIS at http://nsis.sourceforge.net/Download
; As a program that all Power PC users should have, Notepad++ is recommended to edit this file

Icon "Resources\YTVL.ico"
Caption "YTVL Installer"
Name "YTVL"
XPStyle on
AutoCloseWindow true
ShowInstDetails show

LicenseBkColor /windows
LicenseData "LICENSE.md"
LicenseForceSelection checkbox "I have read and understand this notice"
LicenseText "Please read the notice below before installing YTVL. If you understand the notice, click the checkbox below and click Next."

InstallDir $PROGRAMFILES\WalkmanOSS

OutFile "bin\Release\YTVL-Installer.exe"

; Pages

Page license
Page components
Page directory
Page instfiles
UninstPage uninstConfirm
UninstPage instfiles

; Sections

Section "YTVL Executable & Uninstaller"
  SectionIn RO
  SetOutPath $INSTDIR
  File "bin\Release\YTVL.exe"
  WriteUninstaller "YTVL-Uninst.exe"
SectionEnd

Section "Remove old files in DeavmiOSS"
  Delete "$PROGRAMFILES\DeavmiOSS\YTVL-Uninst.exe"
  Delete "$PROGRAMFILES\DeavmiOSS\YTVL.exe"
  RMDir "$PROGRAMFILES\DeavmiOSS"
  
  Delete "$SMPROGRAMS\DeavmiOSS\YTVL.lnk"
  Delete "$SMPROGRAMS\DeavmiOSS\Uninstall YTVL.lnk"
  RMDir "$SMPROGRAMS\DeavmiOSS"
SectionEnd

Section "YTVL Start Menu Shortcuts"
  CreateDirectory "$SMPROGRAMS\WalkmanOSS"
  CreateShortCut "$SMPROGRAMS\WalkmanOSS\YTVL.lnk" "$INSTDIR\YTVL.exe" "" "$INSTDIR\YTVL.exe" "" "" "" "YouTube Video Linker"
  CreateShortCut "$SMPROGRAMS\WalkmanOSS\Uninstall YTVL.lnk" "$INSTDIR\YTVL-Uninst.exe" "" "" "" "" "" "Uninstall YouTube Video Linker"
  ;Syntax for CreateShortCut: link.lnk target.file [parameters [icon.file [icon_index_number [start_options [keyboard_shortcut [description]]]]]]
SectionEnd

Section "YTVL Desktop Shortcut"
  CreateShortCut "$DESKTOP\YTVL.lnk" "$INSTDIR\YTVL.exe" "" "$INSTDIR\YTVL.exe" "" "" "" "YouTube Video Linker"
SectionEnd

Section "YTVL Quick Launch Shortcut"
  CreateShortCut "$QUICKLAUNCH\YTVL.lnk" "$INSTDIR\YTVL.exe" "" "$INSTDIR\YTVL.exe" "" "" "" "YouTube Video Linker"
SectionEnd

; Functions

Function .onInit
  MessageBox MB_YESNO "This will install YTVL. Do you wish to continue?" IDYES gogogo
    Abort
  gogogo:
  SetShellVarContext all
  SetAutoClose true
FunctionEnd

Function .onInstSuccess
    MessageBox MB_YESNO "Install Succeeded! Open ReadMe?" IDNO NoReadme
      ExecShell "open" "https://github.com/Walkman100/YTVL/blob/master/README.md#youtube-video-linker-"
    NoReadme:
FunctionEnd

; Uninstaller

Section "Uninstall"
  Delete "$INSTDIR\YTVL-Uninst.exe"   ; Remove Application Files
  Delete "$INSTDIR\YTVL.exe"
  RMDir "$INSTDIR"
  
  Delete "$SMPROGRAMS\WalkmanOSS\YTVL.lnk"   ; Remove Start Menu Shortcuts & Folder
  Delete "$SMPROGRAMS\WalkmanOSS\Uninstall YTVL.lnk"
  RMDir "$SMPROGRAMS\WalkmanOSS"
  
  Delete "$DESKTOP\YTVL.lnk"   ; Remove Desktop Shortcut
  Delete "$QUICKLAUNCH\YTVL.lnk"   ; Remove Quick Launch shortcut
  
  ; Remove old files in DeavmiOSS
  Delete "$PROGRAMFILES\DeavmiOSS\YTVL-Uninst.exe"
  Delete "$PROGRAMFILES\DeavmiOSS\YTVL.exe"
  RMDir "$PROGRAMFILES\DeavmiOSS"
  
  Delete "$SMPROGRAMS\DeavmiOSS\YTVL.lnk"
  Delete "$SMPROGRAMS\DeavmiOSS\Uninstall YTVL.lnk"
  RMDir "$SMPROGRAMS\DeavmiOSS"
SectionEnd

; Uninstaller Functions

Function un.onInit
    MessageBox MB_YESNO "This will uninstall YTVL. Continue?" IDYES NoAbort
      Abort ; causes uninstaller to quit.
    NoAbort:
    SetShellVarContext all
    SetAutoClose true
FunctionEnd

Function un.onUninstFailed
    MessageBox MB_OK "Uninstall Cancelled"
FunctionEnd

Function un.onUninstSuccess
    MessageBox MB_OK "Uninstall Completed"
FunctionEnd
