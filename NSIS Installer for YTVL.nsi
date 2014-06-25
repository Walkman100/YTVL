; YTVL Installer NSIS Script
; get NSIS at http://tenet.dl.sourceforge.net/project/nsis/NSIS%202/2.46/nsis-2.46-setup.exe
; As a program that all Power PC users should have, Notepad ++ is recommended to edit this file

AddBrandingImage top 20
Icon YTVL\youtube_withLink.ico
Caption "YTVL Installer"
Name "YTVL"
AutoCloseWindow true

InstallDir $PROGRAMFILES\DeavmiOSS

OutFile ..\YTVL-Installer.exe

; Pages

;Page components
Page directory
Page instfiles
UninstPage uninstConfirm
UninstPage instfiles

; Sections

Section "YTVL Executable"
  SetOutPath $INSTDIR
  File "YTVL\bin\Release\YTVL.exe"
  CreateDirectory "$SMPROGRAMS\DeavmiOSS"
  CreateShortCut "$SMPROGRAMS\DeavmiOSS\YTVL.lnk" "$INSTDIR\YTVL.exe" "" "$INSTDIR\YTVL.exe" "" "" "" "YouTube Video Linker"
  CreateShortCut "$SMPROGRAMS\DeavmiOSS\Uninstall.lnk" "$INSTDIR\Uninstall YTVL.exe" "" "" "" "" "" "Uninstall YouTube Video Linker"
  ;Syntax for CreateShortCut: link.lnk target.file [parameters [icon.file [icon_index_number [start_options [keyboard_shortcut [description]]]]]]
SectionEnd

;Section "More apps at DeavmiOSS"
; this should have sub options for available apps, that are downloaded
;SectionEnd

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
