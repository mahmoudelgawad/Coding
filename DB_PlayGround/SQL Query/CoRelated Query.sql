-- is like the subquery but the outer query send data first
-- then inner query evaluate and return data to outer query

SELECT tbl1.BusinessEntityID,tbl1.JobTitle
FROM HumanResources.Employee tbl1
--where BusinessEntityID = (SELECT BusinessEntityID from HumanResources.EmployeePayHistory where BusinessEntityID = 4)
where tbl1.BusinessEntityID in (SELECT tbl2.BusinessEntityID 
						        from HumanResources.EmployeePayHistory tbl2
								where tbl2.BusinessEntityID = tbl1.BusinessEntityID AND
									  tbl2.Rate < 500.0)