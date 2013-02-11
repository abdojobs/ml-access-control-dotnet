@ECHO OFF
ECHO.
ECHO This batch file exports the SQL schema of the given SQLite DB
ECHO.

SET inputDB=..\..\DB\ML.AccessControl.db

REM Create the result directory
set hr=%time:~0,2%
if "%hr:~0,1%" equ " " set hr=0%hr:~1,1%
set resultDir=schema_%date:~-4,4%%date:~-7,2%%date:~-10,2%_%hr%%time:~3,2%%time:~6,2%
MD %resultDir%

REM Create the commands file here
ECHO. > ExSQLite.sql
ECHO .output %resultDir%\\mlac_tbl_users.sql >> ExSQLite.sql
ECHO .schema mlac_tbl_users >> ExSQLite.sql
ECHO .output %resultDir%\\mlac_tbl_sessions.sql >> ExSQLite.sql
ECHO .schema mlac_tbl_sessions >> ExSQLite.sql
ECHO .output %resultDir%\\mlac_tbl_access_types.sql >> ExSQLite.sql
ECHO .schema mlac_tbl_access_types >> ExSQLite.sql
ECHO .output %resultDir%\\mlac_tbl_object_types.sql >> ExSQLite.sql
ECHO .schema mlac_tbl_object_types >> ExSQLite.sql

REM Execute the commands file
sqlite3 %inputDB% < ExSQLite.sql
DEL ExSQLite.sql

ECHO Folder '%resultDir%' created with the schema script
ECHO.
PAUSE