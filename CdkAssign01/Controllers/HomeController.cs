using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CdkAssign01.Models;
using CdkAssign01.Models.DTO;
using CdkAssign01.BAL;

namespace CdkAssign01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // FEEDBACK: I'd add an [HttpPost] attribute here to 
        // make it clearer that this method is for processing POST 
        // requests from a form.
        // FEEDBACK: I'd use the desired data type for your parameter.
        // Model binding will handle parsing the form POST string value 
        // to an integer for you and if it can't do that, it'll set the 
        // ModelState.IsValid property to "false".
        public ActionResult Lookup(string myDesiredCustomerId)
        {
            OrdersViewModel ordersListViewModel;

            // FEEDBACK: This code could be eliminated by relying upon MVC's 
            // model binding. Instead of switching on the result of the int.TryParse
            // method, you could check if ModelState.IsValid is true/false.
            int customerId = 0;
            bool success = int.TryParse(myDesiredCustomerId, out customerId);
            if (success)
            {
                // FEEDBACK: I'd would have like to have seen the repository
                // classes be instance. I'd then instantiate an instance 
                // in the controller's constructor and use a private field to store 
                // the object reference. The advantage of doing that 
                // is that it sets you up to be able to more easily provide a mock 
                // of your repositories if/when you start writing unit tests.

                CustomerDTO customerDTO = CdkAssign01.BAL.CustomersRepository.GetCustomerById(customerId);
                // FEEDBACK: If the customer data didn't come back
                // then you don't need to make the call to get the customer orders.
                OrdersDTO ordersDTO = CdkAssign01.BAL.OrdersRepository.GetOrdersForCustomer(customerId);
                ordersListViewModel = ConvertOrdersDTOToOrdersListViewModel(ordersDTO);
                AddCustomerDTOToOrdersListViewModel(ordersListViewModel, customerDTO);
                if (!ordersListViewModel.Customer.IsValidCustomer)
                {
                    ordersListViewModel.Message = "No customer with that ID";
                }
                // FEEDBACK: You can use the Count property to get the number of
                // items from a List<T> collection. Calling the Count method
                // requires the collection to be enumerated.
                else if (ordersListViewModel.Orders.Count() == 0)
                {
                    ordersListViewModel.Message = "No orders found";
                }
            }
            else
            {
                ordersListViewModel = new OrdersViewModel() { Message = "Not a valid customer ID" };
            }

            return View("Index", ordersListViewModel);
        }


        private OrdersViewModel ConvertOrdersDTOToOrdersListViewModel(OrdersDTO ordersDTO)
        {
            OrdersViewModel ordersListViewModel = new OrdersViewModel();

            // FEEDBACK: As I've mentioned elsewhere, I'm not sure that it's
            // necessary to have the separation between DTO and view model objects.
            // But if you're going to do that, I'd look at using something like 
            // AutoMapper (http://automapper.org/) to move your data between the two structures.
            // Potentially another example of DRY.
            ordersListViewModel.Orders = ordersDTO.Orders.Select(r => new OrderViewModel
            {
              OrderId = r.OrderId.ToString()
            , CustomerId = r.CustomerId.ToString()
            , Make = r.Make
            , Model = r.Model
            , Color = r.Color
            , Year = r.Year.ToString()
            , OwnershipType = r.OwnershipType
            }).ToList();
            
            return ordersListViewModel;
        }

        private void AddCustomerDTOToOrdersListViewModel(OrdersViewModel ordersListViewModel, CustomerDTO customerDTO)
        {
            // FEEDBACK: Again, you could use something like AutoMapper 
            // to reduce this code down to a single method call.
            ordersListViewModel.Customer.IsValidCustomer = (customerDTO.CustomerId > 0);
            ordersListViewModel.Customer.CustomerId = customerDTO.CustomerId;
            ordersListViewModel.Customer.FirstName = customerDTO.FirstName;
            ordersListViewModel.Customer.LastName = customerDTO.LastName;
            ordersListViewModel.Customer.Address = customerDTO.Address;
            ordersListViewModel.Customer.City = customerDTO.City;
            ordersListViewModel.Customer.StateCode = customerDTO.StateCode;
            ordersListViewModel.Customer.PostalCode = customerDTO.PostalCode;
        }

    }
}