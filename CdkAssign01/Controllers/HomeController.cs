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

        public ActionResult Lookup()
        {
            var ordersListViewModel = GetMockOrdersListViewModel();

            return View("OrdersList",ordersListViewModel);
        }

        private OrdersListViewModel GetMockOrdersListViewModel()
        {
            var ordersListViewModel = new OrdersListViewModel();
            ordersListViewModel.Orders = new List<OrderViewModel>();

            OrderViewModel order;

            order = new OrderViewModel();
            order.OrderId = "1000";
            order.CustomerId = "9000";
            ordersListViewModel.Orders.Add(order);

            order = new OrderViewModel();
            order.OrderId = "1001";
            order.CustomerId = "9001";
            ordersListViewModel.Orders.Add(order);

            return ordersListViewModel;
        }

    }
}