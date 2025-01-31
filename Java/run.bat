@echo off
setlocal

echo Compilando los programas...
javac MultiplicacionMatrices.java Entero.java
if %ERRORLEVEL% neq 0 (
    echo Error en la compilaci¢n.
    exit /b %ERRORLEVEL%
)


echo Ejecuci¢n de la verificacion de n£meros primos...
java Entero
echo -----------------------------------

echo Ejecuci¢n de la multiplicaci¢n de matrices...
java MultiplicacionMatrices
echo -----------------------------------


echo Procesos finalizados.
endlocal
pause
