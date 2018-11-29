using System;
namespace IPGeolocation
{
    public class TimezoneParams
	{
        private String timezone;
        private String ipAddress;
        private Double latitude;
        private Double longitude;
        private String lang;

        public TimezoneParams()
        {
            timezone = "";
            ipAddress = "";
            latitude = 1000.0;
            latitude = 1000.0;
            this.lang = "en";
        }

        public void SetTimezone(String timezone)
        {
            this.timezone = Strings.NullToEmpty(timezone);
        }

        public String GetTimezone()
        {
            return timezone;
        }

        public void SetIPAddress(String ipAddress)
        {
            this.ipAddress = Strings.NullToEmpty(ipAddress);
        }

        public String GetIPAddress()
        {
            return ipAddress;
        }

        public void SetLocation(Double latitude, Double longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public Double GetLatitude()
        {
            return latitude;
        }

        public Double GetLongitude()
        {
            return longitude;
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
