CREATE TABLE [dbo].[Customers] (
    [CustomerId] INT          NOT NULL,
    [FirstName]  VARCHAR (35) NULL,
    [LastName]   VARCHAR (35) NULL,
    [City] VARCHAR(45) NULL, 
    [StateCode] CHAR(2) NULL, 
    [PostalCode] VARCHAR(9) NULL, 
    PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

