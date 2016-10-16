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
