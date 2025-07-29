--# is like query inside query, and can return single or multiple records

SELECT BusinessEntityID,Rate, RateChangeDate
FROM HumanResources.EmployeePayHistory
--# if subquery return single record/value
--where BusinessEntityID = (SELECT BusinessEntityID from HumanResources.EmployeePayHistory where BusinessEntityID = 4)
where BusinessEntityID in (SELECT BusinessEntityID from HumanResources.EmployeePayHistory where RateChangeDate between '2009-01-01' and '2010-11-15')