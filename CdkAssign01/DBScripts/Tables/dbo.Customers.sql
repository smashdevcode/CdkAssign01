If OBJECT_ID('dbo.Customers', 'U') Is Not Null
	Drop Table dbo.Customers;
 
CREATE TABLE [dbo].[Customers] 
(
  CustomerId	INT			NOT NULL
, FirstName		VARCHAR(35)	NULL
, LastName		VARCHAR(35)	NULL
, Address		VARCHAR(70)	NULL
, City			VARCHAR(45)	NULL 
, StateCode		CHAR(2)		NULL 
, PostalCode	VARCHAR(9)	NULL 
, PRIMARY KEY CLUSTERED (CustomerId ASC)
);

