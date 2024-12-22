@echo off
:MENU
cls
echo *************************************
echo ===============MENU==================
echo *************************************
echo.
echo 1. Somar 
echo 2. Subtracao
echo 3. Multiplicacao
echo 4. Dividir
echo 5. Sair 
set /p opcao=Escolha uma opcao:
if "%opcao%"=="1" goto SOMA
if "%opcao%"=="2" goto SUBTRACAO
if "%opcao%"=="3" goto MULTIPLICAO
if "%opcao%"=="4" goto DIVISAO
if "%opcao%"=="5" goto exit
goto MENU
:SOMA
cls
echo ==Bem Vindo a opcao de Soma==
echo.
set /p num1=Digite o primeiro numero:
set /p num2=Digite o primeiro numero:
set /a resultado=num1+num2
echo O Resultado: %resultado%
pause
goto MENU
:SUBTRACAO
cls
echo ==Bem Vindo a opcao de Subtracao==
echo.
set /p num1=Digite o primeiro numero:
set /p num2=Digite o primeiro numero:
set /a resultado=num1-num2
echo O Resultado: %resultado%
pause
goto MENU
:MULTIPLICAO
cls
echo ==Bem Vindo a opcao de Multiplicacao==
echo.
set /p num1=Digite o primeiro numero:
set /p num2=Digite o primeiro numero:
set /a resultado=num1*num2
echo O Resultado: %resultado%
pause
goto MENU
:DIVISAO
cls
echo ==Bem Vindo a opcao de Divisao==
echo.
set /p num1=Digite o primeiro numero:
set /p num2=Digite o primeiro numero:
set /a resultado=num1/num2
echo O Resultado: %resultado%
pause
goto MENU

