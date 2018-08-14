using System;
namespace IPGeolocation
{
    public class GeolocationParams
	{
        private String ip;
        private String fields;
        private String[] ips;

        public GeolocationParams()
        {
            this.ip = "";
            this.fields = "";
            this.ips = new String[0];
        }

        public void SetIp(String ip)
        {
            this.ip = Strings.NullToEmpty(ip);
        }

        public String GetIp()
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

        public void SetIps(String[] ips)
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

        public String[] GetIps()
        {
            return ips;
        }
    }
}
