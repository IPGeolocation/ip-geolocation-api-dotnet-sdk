using System;
namespace IPGeolocation
{
    public class TimezoneParams
    {
        private String ipAddress;
        private String timezone;
        private String lang;
        private Double latitude;
        private Double longitude;
        private String location;
        public TimezoneParams()
        {
            ipAddress = "";
            timezone = "";
            this.lang = "en";
            latitude = 1000.0;
            latitude = 1000.0;
            location = "";
        }

        public void SetIPAddress(String ipAddress)
        {
            this.ipAddress = Strings.NullToEmpty(ipAddress);
        }

        public String GetIPAddress()
        {
            return ipAddress;
        }

        public void SetTimezone(String timezone)
        {
            this.timezone = Strings.NullToEmpty(timezone);
        }

        public String GetTimezone()
        {
            return timezone;
        }

        public void SetCoordinates(Double latitude, Double longitude)
        {
            if ((latitude >= -90 && latitude <= 90) && (longitude >= -180 && longitude <= 180))
            {
                this.latitude = latitude;
                this.longitude = longitude;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Coordinate value is out of range!");
            }
        }

        public void SetLang(String lang)
        {
            this.lang = Strings.NullToEmpty(lang);
        }

        public String GetLang()
        {
            return lang;
        }

        public Double GetLatitude()
        {
            return latitude;
        }

        public Double GetLongitude()
        {
            return longitude;
        }

        public void SetLocation(String location)
        {
            this.location = location;
        }

        public String GetLocation()
        {
            return location;
        }
    }
}
