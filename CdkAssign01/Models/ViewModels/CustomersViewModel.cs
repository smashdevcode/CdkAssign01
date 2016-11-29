using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CdkAssign01.Models
{

    public class CustomerViewModel
    {
        public bool IsValidCustomer { get; set; }

        // FEEDBACK: I'm assuming that you were trying to 
        // keep your DTO objects from reaching the view so 
        // you decided to repeat the customer DTO properties 
        // here. If you let go of that idea, you could have 
        // had one "Customer" entity and replaced these properties
        // with an instance of that Customer entity.
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string PostalCode { get; set; }
    }
}
