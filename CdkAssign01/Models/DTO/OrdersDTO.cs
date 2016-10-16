using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CdkAssign01.Models.DTO
{

    public class OrdersDTO
    {
        List<OrderDTO> Orders;
    }

    public class OrderDTO
    {
        public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string PostalCode { get; set; }
    }

}