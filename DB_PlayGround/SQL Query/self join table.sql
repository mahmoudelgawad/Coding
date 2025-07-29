--selft reference table
--table have same primary key and foreign key, points to same table 

create table Table_Customer
(
[ID]	uniqueidentifier not null,
[CustomerName] nvarchar(200) not null,
Col3	nvarchar(20)	null,
Col4	nvarchar(20)	null,
FK_ReferenceID uniqueidentifier not null
)