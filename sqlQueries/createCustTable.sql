drop table CustomerInfo;

create table CustomerInfo (
CustID int IDENTITY Primary Key,
FirstName varchar (20),
LastName varchar(20),
Address varchar(30),
Address2 varchar(30),
City varchar(20),
State varchar(2),
zip int,
);