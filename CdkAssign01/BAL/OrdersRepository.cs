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
                ordersDTO.Orders.Add(new OrderDTO
                {
                    OrderId = SqlHelper.GetSafeInt(row["OrderId"]),
                    CustomerId = SqlHelper.GetSafeInt(row["CustomerId"]),
                    Make = SqlHelper.GetSafeString(row["Make"]),
                    Model = SqlHelper.GetSafeString(row["Model"]),
                    Color = SqlHelper.GetSafeString(row["Color"]),
                    Year = SqlHelper.GetSafeInt(row["Year"]),
                    OwnershipType = SqlHelper.GetSafeString(row["OwnershipType"])
                });
            }

            return ordersDTO;
        }

    }

}