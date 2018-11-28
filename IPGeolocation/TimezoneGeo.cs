using System;
using Newtonsoft.Json.Linq;
namespace IPGeolocation
{
    public class TimezoneGeo
	{
        private String countryCode2;
        private String countryCode3;
        private String countryName;
        private String stateProvince;
        private String city;
        private String zipCode;
        private String latitude;
        private String longitude;

        public TimezoneGeo(JObject json)
        {
            JToken token = json.GetValue("country_code2");
            this.countryCode2 = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("country_code3");
            this.countryCode3 = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("country_name");
            this.countryName = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("state_prov");
            this.stateProvince = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("city");
            this.city = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("zipcode");
            this.zipCode = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("latitude");
            this.latitude = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("longitude");
            this.longitude = token != null ? token.ToObject<String>() : null;
        }

        public String GetCountryCode2()
        {
            return countryCode2;
        }

        public String GetCountryCode3()
        {
            return countryCode3;
        }

        public String GetCountryName()
        {
            return countryName;
        }

        public String GetStateProvince()
        {
            return stateProvince;
        }

        public String GetCity()
        {
            return city;
        }

        public String GetZipCode()
        {
            return zipCode;
        }

        public String GetLatitude()
        {
            return latitude;
        }

        public String GetLongitude()
        {
            return longitude;
        }
    }
}
