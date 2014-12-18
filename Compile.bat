@echo off

"%ProgramFiles%\MSBuild\12.0\bin\msbuild.exe" /property:Configuration=Release YTVL.sln

"%ProgramFiles%\NSIS\makensis.exe" "NSIS Installer for YTVL.nsi"
del bin\Release\YTVL-Portable.exe
ren bin\Release\YTVL.exe YTVL-Portable.exe

explorer.exe "%~dp0bin\Release"