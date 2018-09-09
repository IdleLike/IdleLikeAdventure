echo off & color 0A
::指定起始文件夹
cd..
set DIR=%CD%\Output\Bin_C
echo DIR=%DIR%
set MGRDIR = %CD%\Output\Code_C\StaticDataMgr.cs
echo DIR=%MGRDIR%
Set CODEDIR = %CD%\Output\Code_C\Data
echo CODEDIR=%CODEDIR%
::指定起始文件夹 Byte文件目标文件夹
cd..
set ToDIR=%CD%\Assets\Resources\Configs\Bytes
echo ToDIR=%ToDIR%
set ToCodeDIR=%CD%\Assets\Scripts\StaticDataMgr\Data
echo ToCodeDIR=%ToCodeDIR%
set ToMGRDIR=%CD%\Assets\Scripts\StaticDataMgr\StaticDataMgr.cs
echo ToMGRDIR=%ToMGRDIR%

cd %DIR%
for %%f in (*.bytes) do ( 

    move %DIR%\%%f %ToDIR%\%%f

echo %%f
)
cd %CODEDIR%
for %%f in (*.bytes) do ( 

    move %CODEDIR%\%%f %ToCodeDIR%\%%f

echo %%f
)
move %MGRDIR% %ToMGRDIR%
pause