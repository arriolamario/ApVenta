echo off
Set Fecha=%Date:~6,4%%Date:~3,2%%Date:~0,2%
Set Hora=%Time:~0,2%%Time:~3,2%%Time:~6,2%
echo %Fecha%
echo %Hora%
pause
git add .
pause
git commit -m "%Fecha%%Hora%"
pause
git pull
pause
git push

pause
exit