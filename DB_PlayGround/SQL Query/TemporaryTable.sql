--#Temporary table is physical table created for one session,
--#created in local current server (Databases-System Databases-tempdb-Temporary Tables)
--#once this session is closed it will dropped

--#Create temporary table should prefix '#' before table name
CREATE TABLE #TestTempTable(
Product_Name VARCHAR(MAX) NULL,
List_Price DEC(10,2) NULL
)
INSERT INTO #TestTempTable VALUES('MAC Book Pro MAX 16C',4000);
SELECT * FROM #TestTempTable;