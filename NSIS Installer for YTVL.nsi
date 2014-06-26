; YTVL Installer NSIS Script
; get NSIS at http://tenet.dl.sourceforge.net/project/nsis/NSIS%202/2.46/nsis-2.46-setup.exe
; As a program that all Power PC users should have, Notepad ++ is recommended to edit this file

AddBrandingImage top 20
Icon YTVL\youtube_withLink.ico
Caption "YTVL Installer"
Name "YTVL"
AutoCloseWindow true

InstallDir $PROGRAMFILES\DeavmiOSS
SetShellVarContext all

OutFile ..\YTVL-Installer.exe

; Pages

Page components
Page directory
Page instfiles
UninstPage uninstConfirm
UninstPage instfiles

; Sections

Section "YTVL Executable & Uninstaller"
  SetOutPath $INSTDIR
  File "YTVL\bin\Release\YTVL.exe"
  WriteUninstaller "YTVL-Uninst.exe"
SectionEnd

Section "YTVL Start Menu Shortcuts"
  CreateDirectory "$SMPROGRAMS\DeavmiOSS"
  CreateShortCut "$SMPROGRAMS\DeavmiOSS\YTVL.lnk" "$INSTDIR\YTVL.exe" "" "$INSTDIR\YTVL.exe" "" "" "" "YouTube Video Linker"
  CreateShortCut "$SMPROGRAMS\DeavmiOSS\Uninstall.lnk" "$INSTDIR\YTVL-Uninst.exe" "" "" "" "" "" "Uninstall YouTube Video Linker"
  ;Syntax for CreateShortCut: link.lnk target.file [parameters [icon.file [icon_index_number [start_options [keyboard_shortcut [description]]]]]]
SectionEnd

Section "YTVL Desktop Shortcut"
  CreateShortCut "$DESKTOP\YTVL.lnk" "$INSTDIR\YTVL.exe" "" "$INSTDIR\YTVL.exe" "" "" "" "YouTube Video Linker"
SectionEnd

Section "YTVL Quick Launch Shortcut"
  CreateShortCut "$QUICKLAUNCH\YTVL.lnk" "$INSTDIR\YTVL.exe" "" "$INSTDIR\YTVL.exe" "" "" "" "YouTube Video Linker"
SectionEnd

;Section "More apps from DeavmiOSS"
; this should have sub options for available apps, that are downloaded
;SectionEnd

; Uninstaller

Section "Uninstall"
  Delete $INSTDIR\YTVL-Uninst.exe
  Delete $INSTDIR\YTVL.exe
  RMDir $INSTDIR
  Delete $SMPROGRAMS\DeavmiOSS\YTVL.lnk
  Delete $SMPROGRAMS\DeavmiOSS\Uninstall.lnk
  RMDir $SMPROGRAMS\DeavmiOSS
SectionEnd

; Functions

Function .onInit
  MessageBox MB_YESNO "This will install YTVL. Do you wish to continue?" IDYES gogogo
    Abort
  gogogo:
  File "YTVL\youtube_withLink.ico"
  SetBrandingImage "[/RESIZETOFIT] YTVL\youtube_withLink.ico"
  SetBrandingImage "[/RESIZETOFIT] youtube_withLink.ico"
FunctionEnd

Function .onInstSuccess
    MessageBox MB_YESNO "Install Succeeded! Open ReadMe?" IDNO NoReadme
      Exec "http://github.com/Walkman100/YTVL/blob/master/README.md#youtube-video-linker-"
    NoReadme:
FunctionEnd

; Uninstaller

Function un.onInit
    MessageBox MB_YESNO "This will uninstall YTVL. Continue?" IDYES NoAbort
      Abort ; causes uninstaller to quit.
    NoAbort:
FunctionEnd

Function un.onUninstFailed
    MessageBox MB_OK "Uninstall Cancelled"
FunctionEnd

Function un.onUninstSuccess
    MessageBox MB_OK "Uninstall Completed"
FunctionEnd
