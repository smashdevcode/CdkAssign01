using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CdkAssign01.Models.DTO
{

    public class OrdersDTO
    {
        public List<OrderDTO> Orders;

        public OrdersDTO()
        {
            Orders = new List<OrderDTO>();
        }
    }

    public class OrderDTO
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string OwnershipType { get; set; }
    }

}