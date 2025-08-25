--#windows Vs function
	--#window: it represents set of rows or result set (group as (ORDER BY)) like 'Results' window tap
	--#function: logic/calculation operates over that set of rows

 USE DB_PlayGround;


  --#The function 'ROW_NUMBER' must have an OVER clause.
 SELECT ROW_NUMBER() OVER (ORDER BY FirstName) AS RowNumber_ID, FirstName 
 FROM Employee
 

 --need search what is OVER clause should use order by ? yes
 --# partition clause will divide rows into separate groups/windows and then apply calculation on
 --# on that rows set like (ORDER BY)
 SELECT  ROW_NUMBER() OVER (PARTITION BY FirstName ORDER BY FirstName) AS RowNumber_Partition_ID,
		 FirstName
 FROM Employee

 --#to rank for examble student by grade,
 --#but here will rank according ASC order alphabetical
 --#rank vs dense_rank both these function applicable when you have ties(dublicate values)
 --#rank() will include gaps in ranking (1,1,3,4,4) notice no (2) number
 SELECT RANK() OVER (ORDER BY FirstName) as Rank_ID,
		FirstName
 FROM Employee

 --#but dense_rank() not include gaps in ranking (1,1,2,3,4,4,5,5)
SELECT DENSE_RANK() OVER (ORDER BY FirstName) as Desnse_Rank_ID,
		FirstName
 FROM Employee


