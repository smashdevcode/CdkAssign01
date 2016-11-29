using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CdkAssign01.Models
{

    public class OrderViewModel
    {
        // FEEDBACK: Same feedback as with the CustomersViewModel.
        // These properties could have been replaced with an 
        // instance of an "Order" entity.

        // FEEDBACK: Why not use "int" for the OrderId, CustomerId, and Year
        // property's data type?

        public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Year { get; set; }
        public string OwnershipType { get; set; }
    }

    public class OrdersViewModel
    {
        public string Message { get; set; }
        public CustomerViewModel Customer;
        public List<OrderViewModel> Orders;

        public OrdersViewModel()
        {
            Message = "";
            Customer = new CustomerViewModel();
            Orders = new List<OrderViewModel>();
        }
    }

}
