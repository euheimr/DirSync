using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class ExtensionMethods
    {

        public static string ToDirSlashString(this string value)
        {
            value = value.TrimEnd();
            if (value.EndsWith("\\") == true)
            {
                return value;
            }
            else
            {
                return value.Trim() + "\\";
            }
        }

        public static string ToFileDateTimeString(this DateTime value)
        {
            return value.ToString("yyyy-MM-dd_hh-mm-ss-tt");
        }

        public static string ToDateTimeString(this DateTime value)
        {
            return value.ToString("MM/dd/yyyy hh:mm tt");
        }

    }
}
