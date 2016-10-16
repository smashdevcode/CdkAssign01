using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


using CdkAssign01.Models.DTO;
using CdkAssign01.DAL;
using CdkAssign01.Utility;

namespace CdkAssign01.BAL
{
    public class OrdersRepository
    {


        public static OrdersDTO GetOrdersForCustomer(int customerId)
        {
            DataSet ds = OrdersEngine.GetOrdersForCustomer(customerId);

            OrdersDTO ordersDTO = new OrdersDTO();

            DataTable table = ds.Tables[0];

            foreach (DataRow row in table.Rows)
            {
                OrderDTO orderDTO = new OrderDTO();

                orderDTO.OrderId = SqlHelper.GetSafeInt(row["OrderId"]);
                orderDTO.CustomerId = SqlHelper.GetSafeInt(row["CustomerId"]);
                orderDTO.Make = SqlHelper.GetSafeString(row["Make"]);
                orderDTO.Model = SqlHelper.GetSafeString(row["Model"]);
                orderDTO.Color = SqlHelper.GetSafeString(row["Color"]);
                orderDTO.Year = SqlHelper.GetSafeInt(row["Year"]);
                orderDTO.OwnershipType = SqlHelper.GetSafeString(row["OwnershipType"]);

                ordersDTO.Orders.Add(orderDTO);
            }

            return ordersDTO;
        }

    }

}