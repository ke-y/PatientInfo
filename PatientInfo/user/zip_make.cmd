@echo off
sqlite3.exe zip.sqlite < zip.sql
sqlite3.exe zip.sqlite < zip_index.sql

echo "UTF-8Œ`Ž®‚ÌKEN_ALL.csv‚ð—pˆÓ"
pause

sqlite3.exe -separator , zip.sqlite ".import KEN_ALL_20160331.CSV zip"

exit