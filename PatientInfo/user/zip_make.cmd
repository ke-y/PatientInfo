@echo off
sqlite3.exe zip.sqlite < zip.sql
sqlite3.exe zip.sqlite < zip_index.sql

echo "UTF-8形式のKEN_ALL.csvを用意"
pause

sqlite3.exe -separator , zip.sqlite ".import KEN_ALL_20160331.CSV zip"

exit