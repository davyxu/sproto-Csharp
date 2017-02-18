set CURR_DIR=%cd%

: Build generator
cd ..\..\..\..\..
set GOPATH=%cd%
go build -o %CURR_DIR%\sprotogen.exe github.com/davyxu/gosproto/sprotogen
cd %CURR_DIR%

: Generate c# source file by sproto
sprotogen --type=cs --out=Extend.cs --gopackage=SprotoType Extend.sp
sprotogen --type=cs --out=Member.cs --gopackage=SprotoType Member.sproto
:sprotogen --type=cs --out=TestAll2.cs --gopackage=SprotoType TestAll.sproto