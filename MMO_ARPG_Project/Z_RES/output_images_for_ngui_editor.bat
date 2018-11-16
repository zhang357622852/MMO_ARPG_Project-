@echo off

rem 变量使用
rem set test_var = 666
rem echo %test_var%

rem 获取外部参数%i
rem echo pram is %1
rem echo pram is %2
rem echo pram is %3

rem %1 E:\MMO_ARPG_Project\MMO_ARPG_Project\Assets
rem %2 StartMenu

TexturePacker --smart-update %1\..\Z_RES\Atlas\%2 --data %1\Art\Atlas\%2\%2.txt --format unity --sheet %1\Art\Atlas\%2\%2.png --disable-rotation --no-trim --reduce-border-artifacts

rem alpha通道图片
copy %1\Art\Atlas\%2\%2.png %1\Art\Atlas\%2\%2_alpha.png

rem 延迟5秒,执行后面的命令
rem ping -n 5 127.0.0.1

pause
