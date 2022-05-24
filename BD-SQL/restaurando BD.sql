
RESTORE FILELISTONLY
FROM DISK = 'C:\X\AdventureWorks2016.BAK'

RESTORE DATABASE AdventureWorks2016
FROM DISK = 'C:\X\AdventureWorks2016.BAK'
WITH RECOVERY, STATS=10,
MOVE 'AdventureWorks2016_Data' TO 'C:\sql_2016\sql_data\AdventureWorks2016_Data.mdf',
MOVE 'AdventureWorks2016_Log' TO 'C:\sql_2016\sql_log\AdventureWorks2016_Log.ldf'

