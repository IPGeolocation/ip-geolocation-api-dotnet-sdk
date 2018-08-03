using System;
namespace ipgeolocation
{
    public class Strings
    {

        public static String nullToEmpty(String s)
        {
            if (s == null)
            {
                s = "";
            }
            return s;
        }
        
        public static Boolean isNullOrEmpty(String str)
        {
			return str == null || str.Equals("");
        }
    }
}
