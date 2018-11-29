using System;
namespace IPGeolocation
{
    public class GeolocationParams
	{
        private String ipAddress;
        private String fields;
        private String[] ipAddresses;
        private String lang;

        public GeolocationParams()
        {
            this.ipAddress = "";
            this.fields = "";
            this.ipAddresses = new String[0];
            this.lang = "en";
        }

        public void SetIPAddress(String ipAddress)
        {
            this.ipAddress = Strings.NullToEmpty(ipAddress);
        }

        public String GetIPAddress()
        {
            return ipAddress;
        }

        public void SetFields(String fields)
        {
            this.fields = Strings.NullToEmpty(fields);
        }

        public String GetFields()
        {
            return fields;
        }

        public void SetIPAddresses(String[] ipAddresses)
        {
            if (ipAddresses.Length > 50)
            {
                throw new ArgumentException("Max. number of IP addresses cannot be more than 50.");
            }
            else
            {
                this.ipAddresses = ipAddresses;
            }
        }

        public String[] GetIPAddresses()
        {
            return ipAddresses;
        }

        public void SetLang(String lang)
        {
            this.lang = Strings.NullToEmpty(lang);
        }

        public String GetLang()
        {
            return lang;
        }
    }
}
