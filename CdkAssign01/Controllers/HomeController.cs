using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CdkAssign01.Models;

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
            var ordersListViewModel = GetMockOrdersListViewModel();

            //return View("OrdersList", ordersListViewModel);

            CdkAssign01.DAL.OrdersEngine.GetOrdersForCustomer(1000);

            return View("Index", ordersListViewModel);
        }

        private OrdersListViewModel GetMockOrdersListViewModel()
        {
            var ordersListViewModel = new OrdersListViewModel();
            ordersListViewModel.Orders = new List<OrderViewModel>();

            OrderViewModel order;

            order = new OrderViewModel();
            order.OrderId = "1001";
            order.CustomerId = "9000";
            order.FirstName = "Al";
            order.LastName = "Santaballa";
            order.City = "Portland";
            order.StateCode = "OR";
            order.PostalCode = "97209";
            ordersListViewModel.Orders.Add(order);

            order = new OrderViewModel();
            order.OrderId = "1002";
            order.CustomerId = "9000";
            order.FirstName = "Donald";
            order.LastName = "Knuth";
            order.City = "Portland";
            order.StateCode = "OR";
            order.PostalCode = "97209";
            ordersListViewModel.Orders.Add(order);

            order = new OrderViewModel();
            order.OrderId = "1003";
            order.CustomerId = "9001";
            order.FirstName = "Ward";
            order.LastName = "Cunningham";
            order.City = "Portland";
            order.StateCode = "OR";
            order.PostalCode = "97211";
            ordersListViewModel.Orders.Add(order);

            order = new OrderViewModel();
            order.OrderId = "1004";
            order.CustomerId = "9001";
            order.FirstName = "Grover";
            order.LastName = "Cleveland";
            order.City = "Portland";
            order.StateCode = "OR";
            order.PostalCode = "97212";
            ordersListViewModel.Orders.Add(order);

            return ordersListViewModel;
        }

    }
}