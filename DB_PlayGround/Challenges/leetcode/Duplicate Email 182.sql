--ms sql server, mysql, postgresql

SELECT email
FROM Person
GROUP BY email
HAVING COUNT(*) > 1 