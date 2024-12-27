--select * from Cars_Branch_A
--union
--select * from Cars_Branch_B

select model from Cars_Branch_A
where model not in (select model from Cars_Branch_B)
union
select model from Cars_Branch_B
where model not in (select model from Cars_Branch_A)