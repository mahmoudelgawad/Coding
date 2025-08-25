USE DB_PlayGround;

--#it is temporary result set 
--#CTE for writing recursive query

--#create common table expression
/*
WITH Emp_CTE AS
(
	SELECT * FROM Employee
)

--#using in subsequent context excution scope for only once
SELECT * FROM Emp_CTE

--#if you select another time it will not working,because you changed the current context.
--SELECT * FROM Emp_CTE

--#for using second time in same context, with union or inner join
UNION
SELECT * FROM Emp_CTE
*/



--#for recursive query nested select from same self CTE
/*
WITH Count_CTE AS
(
--#base sql
SELECT 1 as n
--#recursive sql
--#should be UNIOIN ALL as (top level) include dublicate
UNION ALL 
SELECT n+1 FROM Count_CTE WHERE n < 3
)
--#will get 1, then 1+1,2+1 (1,2,3)
SELECT * FROM Count_CTE;
*/



--#real word examble for usage CTE, summary total sales for hierarchy management
/*
WITH SalesPerson_recursion1_CTE AS(
	SELECT leader = s.ID, manager=s.ID
	FROM SalesPerson s
	WHERE s.SalesHeadId_FK IS NULL
	UNION ALL
	SELECT leader = cte.leader, manager = sj.ID
	FROM SalesPerson_recursion1_CTE cte
	INNER JOIN SalesPerson sj ON cte.manager = sj.SalesHeadID_FK
	WHERE sj.SalesHeadID_FK IS NOT NULL
),
SalesPerson_recursion2_CTE AS(
	SELECT leader = s.ID, manager=s.ID
	FROM SalesPerson s
	WHERE s.SalesHeadId_FK IS NULL
	UNION ALL
	SELECT leader = cte.leader, manager = sj.ID
	FROM SalesPerson_recursion2_CTE cte
	INNER JOIN SalesPerson sj ON cte.manager = sj.SalesHeadID_FK
	WHERE sj.SalesHeadID_FK IS NOT NULL
)
SELECT (SELECT Name FROM SalesPerson WHERE ID = CTE_R.manager) AS SalesName,
	   	CTE_R.leader,
		--CTE_R.manager,
		SUM(s.Amount) AS SumSalary
FROM(		
   select * from SalesPerson_recursion1_CTE
  --UNION ALL
   --select * from SalesPerson_recursion2_CTE  
) AS CTE_R
INNER JOIN SalesPerson s ON s.ID = CTE_R.manager
GROUP BY CTE_R.leader,CTE_R.manager
*/


--#insert into query will affect on reference table physically that CTE table select from 
WITH CTE_AllSales_Test AS(
	SELECT * FROM SalesPerson
)
--one row affected
INSERT INTO CTE_AllSales_Test VALUES(7,'test',100,NULL);
		 

