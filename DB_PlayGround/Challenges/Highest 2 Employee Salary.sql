--this query for get the second highest salary
USE DB_PlayGround;

--(1)using subquery nested TOP's query, but not available for use variable/parameter as @nth
-- the outer alwyas TOP 1
--internal query use DISTINCT TOP 3 OR TOP 2 (*) salries order by DESC (highest)
--optional final salaries order by defualt ASC, to get the 2th 

/*
--declare @nth int = 3;
select TOP 1 id,FirstName,MiddleName,salary
from (select DISTINCT TOP 2 * from employee order by salary DESC) empTop
order by Salary
*/


--(2)using TSQL OFFSET and FETCH
--rows number start with zero index (@nth - 1)
DECLARE @nth INT = 2;
SELECT FirstName, Salary 
FROM Employee
ORDER BY Salary DESC
OFFSET @nth-1 ROWS -- skip first N row/rows
FETCH NEXT 1 ROWS ONLY --get first row only


--(3) correlated subquery best solution
-- using two aliases e1,e2, when e1(outer) <= e2 (inner)
-- @nth = 1 , like 3500 <= (count * inner salaries), which = him self,  
-- the final result salaries ordered by default ASC
-- so using alias names to pass outer query salary first, to inner query 
/*
declare @nth int = 1;
select e1.FirstName,e1.salary from employee e1
where @nth = ( 
select count(*) from Employee as e2
where e1.Salary <= e2.Salary
)
*/
