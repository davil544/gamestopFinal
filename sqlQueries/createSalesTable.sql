drop table SalesInfo;

create table SalesInfo (
SalesID int IDENTITY PRIMARY KEY,
CustID int FOREIGN KEY REFERENCES CustomerInfo(CustID),
ProductIDs varchar(10), 
ItemQuantity int,
TotalCost real,
);
check (cartContentsID IN('0','1','2')),
INSERT INTO SalesInfo (CustID, ProductIDs, ItemQuantity, TotalCost)
Values (1, '2,3,4', 1, 49.99);