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
    public class CustomersEngine
    {
        public static DataSet GetCustomerById(int customerId)
        {
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

            var result = returnParameter.Value;

            return ds;
        }
    }

}