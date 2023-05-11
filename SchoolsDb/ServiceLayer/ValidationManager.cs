using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public static class ValidationManager
    {
        public static bool IsValidString(string value)
        {
            if (value != null && value != string.Empty && value.Trim().Length > 0)
            {
                return true;
            }
            return false;
        }

    }
}
