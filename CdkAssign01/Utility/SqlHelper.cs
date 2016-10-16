using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CdkAssign01.Utility
{
    public class SqlHelper
    {

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