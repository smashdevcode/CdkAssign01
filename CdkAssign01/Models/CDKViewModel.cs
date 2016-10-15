using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CdkAssign01.Models
{

    public class OrderViewModel
    {
        public string OrderId { get; set; }
        public string CustomerId { get; set; }
    }

    public class OrdersListViewModel
    {
        public List<OrderViewModel> Orders;
    }

}
