--# query for duplicated record , fetch, delete 
--#having ID ,or not exist ID (row_number() over (partiion by col))

--##Select rows repeated more than one
/*
SELECT ID,Name
FROM  Names
GROUP BY ID,NAME
--#fetch/get dublicate
HAVING COUNT(*) > 1
--#fetch only single records not repeated
--HAVING COUNT(*) = 1
*/



--#DELTE Dublicates Names Records with  ID#
/*
DELETE FROM NamesWithID WHERE ID  NOT IN
(
	SELECT MAX(ID)
	FROM NamesWithID
	GROUP BY Name
)
SELECT * FROM NamesWithID
*/



--#DELTE Dublicates Names Recordsm in case without ID
/*
DELETE FROM AliasTable FROM
		(
		  SELECT ROW_NUMBER() OVER (PARTITION BY Name ORDER BY Name) AS rnp
		  FROM NamesWithID
		) AS AliasTable
WHERE AliasTable.rnp > 1
*/


--#Delete dublicates records using CTE
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


