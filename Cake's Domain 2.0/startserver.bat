@echo off

cmd /K "D:\Program Files\xampp\xampp-control.exe"
cmd /K ".\bin\Debug\server.exe"
cmd /K ".\bin\Debug\wserver.exe"

:: Runs in the Background

:: current directory(Should be in same folder as Server.sln)
::set currdir=~
::cd > cat

::echo %currdir%

::if [pwd/bin/Debug has server and wserver] continue else error
::	if [xampp is running apache and mysql] else start xampp
::	open server.exe in admin mode(sudo)
::	open wserver.exe

:: This should start up realm server(maybe switch between localhost and hamachi)


:: First check if xampp is up and running,if not put it up
:: THen run server in admin and wserver in normal

:: Could add AHK hook for this, to start, restart and end


