drop table Products;

/****** Script to create Product Table  ******/
create table Products (
ProductID int IDENTITY primary key,
ProductName varchar (40),
ProductDescription varchar(200),
ProductPrice float,
ProductImage varbinary(max)
);