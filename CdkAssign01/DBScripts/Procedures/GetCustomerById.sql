If OBJECT_ID('GetCustomerById', 'P') Is Not Null
	Drop Procedure GetCustomerById;
Go

Create Procedure GetCustomerById 
  @CustomerId	Int 
As
Begin

	Select 
	  CustomerID
	, FirstName
	, LastName
	, Address
	, City
	, StateCode
	, PostalCode
	From Customers cus
	Where cus.CustomerID = @CustomerId

	If Not Exists (Select 1 From Customers cu Where cu.CustomerId = @CustomerId)
		Return 1;

End
Go
