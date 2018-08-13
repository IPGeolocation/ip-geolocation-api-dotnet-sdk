using System;
namespace IPGeolocation
{
    public class Strings
	{
        public static String NullToEmpty(String s)
        {
            if (s == null)
            {
                s = "";
            }
            return s;
        }

        public static Boolean IsNullOrEmpty(String s)
        {
            return s == null || s.Equals("");
        }
    }
}
