echo off
Set Fecha=%Date:~6,4%%Date:~3,2%%Date:~0,2%
Set Hora=%Time:~0,2%%Time:~3,2%%Time:~6,2%
echo "Ejecutando ADD.."
echo " "
git add .
echo "Ejecutando commit.."
echo " "
git commit -m "%Fecha%%Hora%"
echo "Ejecutando pull.."
echo " "
git pull
echo "Ejecutando push.."
echo " "
git push

pause
exit