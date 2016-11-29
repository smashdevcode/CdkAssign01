using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CdkAssign01.Utility
{
    public class SqlHelper
    {

        // FEEDBACK: How necessary is it to shield yourself against 
        // the possibility that the column name you're trying to reference 
        // doesn't exist? And if the column doesn't exist, what do you 
        // want to have happen? With your implementation, the user just 
        // wouldn't see that value. I would argue that maybe you'd want to 
        // have an exception happen so that you'd know (very early) that 
        // you'd mistyped a column name in your code.

        public static int GetSafeInt(object item)
        {
            return item == null ? 0 : (int)item;
        }

        public static string GetSafeString(object item)
        {
            return item == null ? "" : (string)item;
        }

    }
}