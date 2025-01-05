--how to make Common table expression
--https://learn.microsoft.com/en-us/sql/t-sql/queries/with-common-table-expression-transact-sql?view=sql-server-ver16


WITH NamesIn_CTE(Name)
AS
(
select Name from name_coursename where coursename = 'C#'
)


--select name from NamesIn_CTE

select Name
from Name_CourseName
where coursename <> 'C#'
and [Name] not in (select name from NamesIn_CTE)	