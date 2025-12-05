/* case */
DECLARE @topSalary INT
SELECT
    CASE 
        WHEN (SELECT Count(*) FROM employee) <=1 THEN NULL
        ELSE (
                SELECT TOP 1 salary
                FROM (SELECT DISTINCT TOP 2 *  FROM Employee ORDER BY salary DESC) emptop2
                ORDER BY salary ASC
             )
    END AS SecondHighestSalary


-- second try with variable and agg func 'MAX' to return NULL if no result

/* case */

DECLARE @topSalary INT = (SELECT MAX(Salary) FROM Employee)

SELECT MAX(salary) AS SecondHighestSalary
FROM (SELECT DISTINCT TOP 2 * FROM Employee ORDER BY salary DESC) emptop2
WHERE salary <> @topSalary
ORDER BY SecondHighestSalary ASC

-- ACCEPTED third try no need internal top 2 select or orderby  #BEST memory

DECLARE @topSalary INT = (SELECT MAX(Salary) FROM Employee)

SELECT MAX(salary) AS SecondHighestSalary
FROM Employee
WHERE salary <> @topSalary


-- #ACCEPTED fourth try using common table expression
WITH highest_salary AS (
    SELECT MAX(salary) AS salary
    FROM Employee
)
SELECT MAX(salary) AS SecondHighestSalary
FROM Employee
WHERE salary < (SELECT salary FROM highest_salary);
	


