﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


using CdkAssign01.Models.DTO;
using CdkAssign01.DAL;
using CdkAssign01.Utility;

namespace CdkAssign01.BAL
{
    public class CustomersRepository
    {

        // FEEDBACK: Just out of curiosity, your project includes 
        // Entity Framework but you didn't use it; why not?
        // Using the EF Code First workflow (with an existing database)
        // would have saved you from writing some code.

        public static CustomerDTO GetCustomerById(int customerId)
        {
            DataSet ds = CustomersEngine.GetCustomerById(customerId);

            CustomerDTO customerDTO = new CustomerDTO();

            DataTable table = ds.Tables[0];

            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];

                customerDTO = new CustomerDTO
                {
                  CustomerId = SqlHelper.GetSafeInt(row["CustomerId"])
                , FirstName = SqlHelper.GetSafeString(row["FirstName"])
                , LastName = SqlHelper.GetSafeString(row["LastName"])
                , Address = SqlHelper.GetSafeString(row["Address"])
                , City = SqlHelper.GetSafeString(row["City"])
                , StateCode = SqlHelper.GetSafeString(row["StateCode"])
                , PostalCode = SqlHelper.GetSafeString(row["PostalCode"])
                };

            }

            return customerDTO;
        }

    }

}