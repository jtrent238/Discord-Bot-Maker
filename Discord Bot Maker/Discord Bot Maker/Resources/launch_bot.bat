@echo off
cls
title Bot Console
SET /p bot_name=
SET /p bot_directory=
SET bin="/bin"
SET node_executable=%bin%"/node.exe"
::SET /p bot_version=
::SET /p bot_author=

cd %bot_directory%
%bin%/node.exe
echo %node_executable%
node 