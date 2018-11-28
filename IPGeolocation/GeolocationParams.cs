using System;
namespace IPGeolocation
{
    public class GeolocationParams
	{
        private String ip;
        private String fields;
        private String[] ips;
        private String lang;

        public GeolocationParams()
        {
            this.ip = "";
            this.fields = "";
            this.ips = new String[0];
            this.lang = "en";
        }

        public void SetIPAddress(String ip)
        {
            this.ip = Strings.NullToEmpty(ip);
        }

        public String GetIPAddress()
        {
            return ip;
        }

        public void SetFields(String fields)
        {
            this.fields = Strings.NullToEmpty(fields);
        }

        public String GetFields()
        {
            return fields;
        }

        public void SetIPAddresses(String[] ips)
        {
            if (ips.Length > 50)
            {
                throw new ArgumentException("Max. number of IP addresses cannot be more than 50.");
            }
            else
            {
                this.ips = ips;
            }
        }

        public String[] GetIPAddresses()
        {
            return ips;
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
