set CURR_DIR=%cd%

: Build generator
cd ..\..\..\..\..
set GOPATH=%cd%
go build -o %CURR_DIR%\sprotogen.exe github.com/davyxu/gosproto/sprotogen
cd %CURR_DIR%

: Generate c# source file by sproto
sprotogen --type=cs --out=..\ExtendTest\Extend.cs --package=SprotoType Extend.sp