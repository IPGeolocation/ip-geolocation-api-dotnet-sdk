using System;
using Newtonsoft.Json.Linq;

namespace IPGeolocation
{
    public class Geolocation
	{
        private int status;
        private String message;
        private String ip;
        private String continentCode;
        private String continentName;
        private String countryCode2;
        private String countryCode3;
        private String countryName;
        private String countryCapital;
        private String stateProvince;
        private String district;
        private String city;
        private String zipcode;
        private String latitude;
        private String longitude;
        private Boolean isEu { get; set; }
        private String callingCode;
        private String countryTld;
        private String languages;
        private String countryFlag;
        private String isp;
        private String connectionType;
        private String organization;
        private String geonameId;
        private GeolocationCurrency currency;
        private GeolocationTimezone timezone;

        public Geolocation(JObject json)
        {
            this.status = json.GetValue("status").ToObject<int>();

            JToken token = json.GetValue("message");
            String message = token != null ? token.ToObject<String>() : null;

            if (this.status != 200 || message != null)
            {
                this.message = message;
            }
            else
            {
                token = json.GetValue("ip");
                this.ip = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("continent_code");
                this.continentCode = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("continent_name");
                this.continentName = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("country_code2");
                this.countryCode2 = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("country_code3");
                this.countryCode3 = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("country_name");
                this.countryName = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("country_capital");
                this.countryCapital = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("state_prov");
                this.stateProvince = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("district");
                this.district = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("city");
                this.city = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("zipcode");
                this.zipcode = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("latitude");
                this.latitude = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("longitude");
                this.longitude = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("is_eu");
                this.isEu = token != null ? token.ToObject<Boolean>() : false;

                token = json.GetValue("calling_code");
                this.callingCode = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("country_tld");
                this.countryTld = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("languages");
                this.languages = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("country_flag");
                this.countryFlag = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("isp");
                this.isp = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("connection_type");
                this.connectionType = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("organization");
                this.organization = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("geoname_id");
                this.geonameId = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("currency");
                JObject currencyJson = token != null ? token.ToObject<JObject>() : null;
                this.currency = new GeolocationCurrency(currencyJson);

                token = json.GetValue("time_zone");
                JObject timezoneJson = token != null ? token.ToObject<JObject>() : null;
                this.timezone = new GeolocationTimezone(timezoneJson);
            }
        }

        public int GetStatus()
        {
            return status;
        }

        public String GetMessage()
        {
            return message;
        }

        public String GetIp()
        {
            return ip;
        }

        public String GetContinentCode()
        {
            return continentCode;
        }

        public String GetContinentName()
        {
            return continentName;
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

        public String GetCountryCapital()
        {
            return countryCapital;
        }

        public String GetStateProvince()
        {
            return stateProvince;
        }
        public String GetDistrict()
        {

            return district;
        }
        public String GetCity()
        {
            return city;
        }

        public String GetZipcode()
        {
            return zipcode;
        }

        public String GetLatitude()
        {
            return latitude;
        }

        public String GetLongitude()
        {
            return longitude;
        }
        public String GetCallingCode()
        {
            return callingCode;
        }

        public String GetCountryTld()
        {
            return countryTld;
        }

        public String GetLanguages()
        {
            return languages;
        }

        public String GetCountryFlag()
        {
            return countryFlag;
        }

        public String GetIsp()
        {
            return isp;
        }

        public String GetConnectionType()
        {
            return connectionType;
        }

        public String GetOrganization()
        {
            return organization;
        }

        public String GetGeonameId()
        {
            return geonameId;
        }

        public GeolocationCurrency GetCurrency()
        {
            return currency;
        }

        public GeolocationTimezone GetTimezone()
        {
            return timezone;
        }
    }
}
