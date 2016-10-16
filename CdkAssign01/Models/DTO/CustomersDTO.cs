using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CdkAssign01.Models.DTO
{

    public class CustomersDTO
    {
        public List<CustomerDTO> Customers;

        public CustomersDTO()
        {
            Customers = new List<CustomerDTO>();
        }
    }

    public class CustomerDTO
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string PostalCode { get; set; }
    }

}