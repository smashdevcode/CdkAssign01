If OBJECT_ID('GetOrdersForCustomers', 'P') Is Not Null
	Drop Procedure GetOrdersForCustomers;
Go

Create Procedure GetOrdersForCustomers 
  @CustomerId	Int 
As
Begin

	Select 
	  OrderId
	, CustomerID
	, Make
	, Model
	, Color
	, [Year]
	, OwnershipType
	From Orders ord
	Where ord.CustomerID = @CustomerId

	If Not Exists (Select 1 From Customers cu Where cu.CustomerId = @CustomerId)
		Return 1;

End
Go
