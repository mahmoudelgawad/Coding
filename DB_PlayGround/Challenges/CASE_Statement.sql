/****** 
isnull() to handle null values in case not need ELSE 'NA' case
******/
SELECT Name,
CASE
WHEN isnull(SalesYTD,0) < 10000000 THEN 'Less than 10 million'
WHEN isnull(SalesYTD,0) > 10000000 THEN 'More Than 10 million'
ELSE 'NA'
END AS SalesYTD, SalesYTD as YTD
  FROM [AdventureWorks2017].[Sales].[SalesTerritory]