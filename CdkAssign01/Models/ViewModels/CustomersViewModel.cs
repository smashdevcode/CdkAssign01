using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CdkAssign01.Models
{

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
