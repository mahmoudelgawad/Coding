USE AdventureWorks2017;

SELECT Name,
	CASE
		WHEN ISNULL(ReorderPoint,0) > 200 THEN 'Greater than 200'
		WHEN ISNULL(ReorderPoint,0) < 200 THEN 'Less than 200'
		ELSE 'NA'
	END AS ReorderPoint,
	ReorderPoint AS OrigReorderPoint 
FROM Production.Product