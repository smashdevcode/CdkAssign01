CREATE TABLE [dbo].[Orders]
(
	[OrderId] INT NOT NULL PRIMARY KEY, 
    [CustomerID] INT NOT NULL, 
    [Make] VARCHAR(40) NULL, 
    [Model] VARCHAR(40) NULL, 
    [Color] VARCHAR(20) NULL, 
    [OwnershipTyp] VARCHAR(16) NULL, 
    CONSTRAINT [FK_Orders_To_Customers] FOREIGN KEY (CustomerId) REFERENCES [Customers]([CustomerId])
)
