Use CDK
GO

INSERT INTO dbo.Orders
(
  OrderId
, CustomerID
, Make
, Model
, Color
, Year
, OwnershipType
)
Values
  (2000,1000,'Honda','Accord','Blue',2003,'Lease')
, (2001,1000,'Audi','A4','Black',2006,'Own')
, (2002,1001,'Volkswagen','Jetta','Red',2005,'Lease')
, (2003,1001,'Volkswagen','Passat','Green',2010,'Own')

Go


