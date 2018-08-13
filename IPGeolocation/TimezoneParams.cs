using System;
namespace IPGeolocation
{
    public class TimezoneParams
	{
        private String timezone;
        private String ip;
        private Double latitude;
        private Double longitude;

        public TimezoneParams()
        {
            timezone = "";
            ip = "";
            latitude = 1000.0;
            latitude = 1000.0;
        }

        public void SetTimezone(String timezone)
        {
            this.timezone = Strings.NullToEmpty(timezone);
        }

        public String GetTimezone()
        {
            return timezone;
        }

        public void SetIp(String ip)
        {
            this.ip = Strings.NullToEmpty(ip);
        }

        public String GetIp()
        {
            return ip;
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
    }
}
