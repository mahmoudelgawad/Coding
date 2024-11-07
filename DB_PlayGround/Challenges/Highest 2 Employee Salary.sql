/*
declare @nHight int = 3;

select top 1 id,FirstName,MiddleName,salary
from (select top 2 * from employee order by salary DESC) empTop
order by Salary
*/

-- co related
declare @nth int = 3;
select e1.salary from employee e1
where @nth = ( 
select count(*) from Employee as e2
where e1.Salary > e2.Salary
)
