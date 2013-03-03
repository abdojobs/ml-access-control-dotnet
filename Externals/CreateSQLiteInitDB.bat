@ECHO OFF
ECHO.
ECHO This batch file create a SQLite DB from the given script folder
ECHO Use it with " -sample" parameter to populate the DB with sample data
ECHO.
PAUSE

SET inputFolder=..\\DBScripts\\SQLite3\\

REM Generate the DB file name
set hr=%time:~0,2%
if "%hr:~0,1%" equ " " set hr=0%hr:~1,1%
set resultDB=ML.AccessControl_%date:~-4,4%%date:~-7,2%%date:~-10,2%_%hr%%time:~3,2%%time:~6,2%.db

REM Create the commands file here
ECHO. > ExSQLite.sql
ECHO .read %inputFolder%mlac_tbl_users.sql >> ExSQLite.sql
ECHO .read %inputFolder%mlac_tbl_sessions.sql >> ExSQLite.sql
ECHO .read %inputFolder%mlac_tbl_access_flags.sql >> ExSQLite.sql
ECHO .read %inputFolder%mlac_tbl_object_types.sql >> ExSQLite.sql
ECHO .read %inputFolder%mlac_tbl_modules.sql >> ExSQLite.sql
ECHO .read %inputFolder%mlac_tbl_roles.sql >> ExSQLite.sql
ECHO .read %inputFolder%mlac_tbl_user_role.sql >> ExSQLite.sql
ECHO .read %inputFolder%mlac_tbl_role_permission.sql >> ExSQLite.sql
ECHO .read %inputFolder%data_init.sql >> ExSQLite.sql
IF NOT (%1)==(-sample) GOTO L1
ECHO .read %inputFolder%data_sample.sql >> ExSQLite.sql

:L1
REM Execute the commands file
sqlite3 %resultDB% < ExSQLite.sql
DEL ExSQLite.sql

ECHO DB '%resultDB%' created successfully
ECHO.
