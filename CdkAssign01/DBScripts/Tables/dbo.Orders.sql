If OBJECT_ID('dbo.Orders', 'U') Is Not Null
	Drop Table dbo.Orders;

CREATE TABLE [dbo].[Orders]
(
  OrderId		INT			NOT NULL	PRIMARY KEY 
, CustomerID	INT			NOT NULL 
, Make			VARCHAR(40)	NULL 
, Model			VARCHAR(40)	NULL 
, Color			VARCHAR(20)	NULL 
, Year			INT			NULL 
, OwnershipType	VARCHAR(16)	NULL 
, CONSTRAINT [FK_Orders_To_Customers] FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)
)
