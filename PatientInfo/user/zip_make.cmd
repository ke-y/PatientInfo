@echo off
sqlite3.exe zip.sqlite < zip.sql
sqlite3.exe zip.sqlite < zip_index.sql

echo "UTF-8�`����KEN_ALL.csv��p��"
pause

sqlite3.exe -separator , zip.sqlite ".import KEN_ALL_20160331.CSV zip"

exit