echo off
Set Fecha=%Date:~6,4%%Date:~3,2%%Date:~0,2%
Set Hora=%Time:~0,2%%Time:~3,2%%Time:~6,2%
git add .
git commit -m "%Fecha%%Hora%"
git pull
git push

pause
exit