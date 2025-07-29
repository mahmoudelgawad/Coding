--self join table, when use (inner,right,left) joins with same table

select c1.CustomerName as Customer,
	c2.CustomerName as Customer
from Table_Customer as c1 
inner join Table_cutomer as c2
on c1.ID = c2.FK_referenceID