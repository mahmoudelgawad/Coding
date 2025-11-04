--# query for duplicated record , fetch, delete 
--#having ID ,or without ID (row_number() over (partiion by col))

--#######################################################################
--#use distinct to select unrepeated/unique values from specific column
/*
USE AdvantureWorks2017
SELECT DISTINCT(JobTitle)
from HumanResources.Employee
*/
--######################################################################

--##1)Select rows repeated more than one
/*
SELECT ID,Name
FROM  Names
GROUP BY ID,NAME
--#fetch/get dublicate
HAVING COUNT(*) > 1
--#fetch only single records not repeated
--HAVING COUNT(*) = 1
*/

--######################################################################


--#2)DELTE Dublicates Names Records with  ID "Physically removed"#
/*
DELETE FROM NamesWithID WHERE ID  NOT IN
(
	SELECT MAX(ID)
	FROM NamesWithID
	GROUP BY Name
)
SELECT * FROM NamesWithID
*/


--######################################################################

--#3)DELTE Dublicates Names Records in case without ID "Physically removed"#
/*
DELETE FROM AliasTable FROM
		(
		  SELECT ROW_NUMBER() OVER (PARTITION BY Name ORDER BY Name) AS rnp
		  FROM NamesWithID
		) AS AliasTable
WHERE AliasTable.rnp > 1
*/


--######################################################################

--#4)Delete dublicates records using CTE
/*
WITH CTE_Names AS
(
	SELECT 
	ROW_NUMBER() OVER (PARTITION BY Name ORDER BY Name) AS rnp,
	Name
	FROM NamesWithID
)
DELETE FROM CTE_Names
WHERE rnp > 1
--#SELECT
SELECT * FROM NamesWithID
*/


--######################################################################

--#5)Delete million records from table without affect on performance

--define batch variable for (batch size, lock escalation, transaction log, recovery)
/*
USE AdventureWorks2017;
DECLARE @BATCHSize INT = 1000;
WHILE 1=1
	BEGIN
		DELETE TOP (@BATCHSize) FROM Person.Address WHERE ModifiedDate < '2023-01-01';
		--#system function after (select, delete, update)
		IF @@ROWCOUNT = 0 BREAK;
		--#Throttling (for prevent heavy load)
		WAITFOR DELAY '00:00:01';
	END
*/
--######################################################################
--#as above query Delete million records, as one transaction
USE AdventureWorks2017;
BEGIN TRAN
	DECLARE @BATCHSize INT = 1000;
	WHILE 1=1
		BEGIN
			DELETE TOP (@BATCHSize) FROM Person.Address WHERE ModifiedDate < '2023-01-01';
			--#system function after (select, delete, update)
			IF @@ROWCOUNT = 0 BREAK;
			--#Throttling (for prevent heavy load)
			WAITFOR DELAY '00:00:01';
		END
COMMIT TRAN 


