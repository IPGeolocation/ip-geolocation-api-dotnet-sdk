using System;
using Newtonsoft.Json.Linq;
namespace ipgeolocation
{
    public class TimezoneGeo
    {
		private String countryCode2;
        private String countryCode3;
        private String countryName;
        private String stateProvince;
        private String city;
        private String zipcode;
        private String latitude;
        private String longitude;

        public TimezoneGeo(JObject json)
        {
            this.countryCode2 = (String)json.GetValue("country_code2");
            this.countryCode3 = (String)json.GetValue("country_code3");
            this.countryName = (String)json.GetValue("country_name");
            this.stateProvince = (String)json.GetValue("state_prov");
            this.city = (String)json.GetValue("city");
            this.zipcode = (String)json.GetValue("zipcode");
            this.latitude = (String)json.GetValue("latitude");
            this.longitude = (String)json.GetValue("longitude");
        }

        public String getCountryCode2()
        {
            return countryCode2;
        }

        public String getCountryCode3()
        {
            return countryCode3;
        }

        public String getCountryName()
        {
            return countryName;
        }

        public String getStateProvince()
        {
            return stateProvince;
        }

        public String getCity()
        {
            return city;
        }

        public String getZipcode()
        {
            return zipcode;
        }

        public String getLatitude()
        {
            return latitude;
        }

        public String getLongitude()
        {
            return longitude;
        }
    }
}
