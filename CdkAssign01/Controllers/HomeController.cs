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

        public ActionResult Lookup(string myDesiredCustomerId)
        {

            OrdersListViewModel ordersListViewModel;

            int customerId = 0;
            bool success = int.TryParse(myDesiredCustomerId, out customerId);
            if (success)
            {
                OrdersDTO ordersDTO = CdkAssign01.BAL.OrdersRepository.GetOrdersForCustomer(customerId);
                ordersListViewModel = ConvertOrdersDTOToOrdersListViewModel(ordersDTO);
            }
            else
            {
                ordersListViewModel = new OrdersListViewModel() { Message = "Not a valid customer ID" };
            }

            return View("Index", ordersListViewModel);
        }

        private OrdersListViewModel ConvertOrdersDTOToOrdersListViewModel(OrdersDTO ordersDTO)
        {
            OrdersListViewModel ordersListViewModel = new OrdersListViewModel();

            foreach (OrderDTO orderDTO in ordersDTO.Orders)
            {
                OrderViewModel orderViewModel = new OrderViewModel();

                orderViewModel.OrderId = orderDTO.OrderId.ToString();
                orderViewModel.CustomerId = orderDTO.CustomerId.ToString();
                orderViewModel.Make = orderDTO.Make;
                orderViewModel.Make = orderDTO.Make;
                orderViewModel.Color = orderDTO.Color;
                orderViewModel.Year = orderDTO.Year.ToString();
                orderViewModel.OwnershipType = orderDTO.OwnershipType;

                ordersListViewModel.Orders.Add(orderViewModel);
            }

            return ordersListViewModel;
        }

    }
}