using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CdkAssign01.Models
{

    public class OrderViewModel
    {
        public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Year { get; set; }
        public string OwnershipType { get; set; }
    }

    public class OrdersListViewModel
    {
        public string Message { get; set; }
        public CustomerViewModel Customer;
        public List<OrderViewModel> Orders;

        public OrdersListViewModel()
        {
            Message = "";
            Customer = new CustomerViewModel();
            Orders = new List<OrderViewModel>();
        }
    }

    public class CustomerViewModel
    {
        public bool IsValidCustomer { get; set; }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string PostalCode { get; set; }
    }
}
