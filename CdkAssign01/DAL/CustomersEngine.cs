using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using CdkAssign01.Models.DTO;

namespace CdkAssign01.DAL
{
    // FEEDBACK: If a class only has static methods 
    // I'd go ahead and make the class static too.
    public class CustomersEngine
    {
        // FEEDBACK: This method is almost identical to the GetOrdersForCustomer method
        // in the OrdersEngine class. You could have used a "GetDataSet" method
        // that accepted the stored procedure name to call. This is an example of DRY.
        public static DataSet GetCustomerById(int customerId)
        {
            // FEEDBACK: This is a bit of a nitpick 
            // but since there's only a single result set
            // I'd use a DataTable here instead of a DataSet 
            // (a bit less overhead).
            DataSet ds = new DataSet();
            var constr = ConfigurationManager.ConnectionStrings["CDKConnection"].ConnectionString;
            var conn = new SqlConnection(constr);
            var cmd = new SqlCommand("GetCustomerById", conn);

            cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = customerId;

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            var da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.StoredProcedure;
            da.Fill(ds);

            // FEEDBACK: I like how you're checking if the customer ID exists
            // but you're not doing anything with the return value.
            var result = returnParameter.Value;

            return ds;
        }
    }

}