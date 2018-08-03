using System;
using Newtonsoft.Json.Linq;
namespace ipgeolocation
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
            this.status = (int)json.GetValue("status");
            String message = (String) json.GetValue("message");
			if (this.status != 200 || message != null)
            {
				this.message = message;
            }
            else
            {
				this.ip = (String)json.GetValue("ip");
				this.continentCode = (String)json.GetValue("continent_code");
				this.continentName = (String)json.GetValue("continent_name");
				this.countryCode2 = (String)json.GetValue("country_code2");
				this.countryCode3 = (String)json.GetValue("country_code3");
				this.countryName = (String)json.GetValue("country_name");
				this.countryCapital = (String)json.GetValue("country_capital");
				this.stateProvince = (String)json.GetValue("state_province");
                this.district = (String) json.GetValue("district");
				this.city = (String)json.GetValue("city");
				this.zipcode = (String)json.GetValue("zipcode");
				this.latitude = (String)json.GetValue("latitude");
				this.longitude = (String)json.GetValue("longitude");
				this.isEu = (Boolean)json.GetValue("is_eu");
				this.callingCode = (String)json.GetValue("calling_code");
				this.countryTld = (String)json.GetValue("country_tld");
				this.languages = (String)json.GetValue("languages");
				this.countryFlag = (String)json.GetValue("country_flag");
				this.isp = (String)json.GetValue("isp");
				this.connectionType = (String)json.GetValue("connection_type");
				this.organization = (String)json.GetValue("organization");
				this.geonameId = (String)json.GetValue("geoname_id");
                JObject currencyJson = (JObject)json.GetValue("currency");
                this.currency = new GeolocationCurrency(currencyJson);
                JObject timezoneJson = (JObject)json.GetValue("time_zone");
                this.timezone = new GeolocationTimezone(timezoneJson);
            }
			this.status = int.Parse((String)json.GetValue("status"));
        }

        public int getStatus()
        {
            return status;
        }

        public String getMessage()
        {
            return message;
        }

        public String getIp()
        {
            return ip;
        }

        public String getContinentCode()
        {
            return continentCode;
        }

        public String getContinentName()
        {
            return continentName;
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

        public String getCountryCapital()
        {
            return countryCapital;
        }

        public String getStateProvince()
        {
            return stateProvince;
        }
        public String getDistrict() {
           
            return district;
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
        public String getCallingCode()
        {
            return callingCode;
        }

        public String getCountryTld()
        {
            return countryTld;
        }

        public String getLanguages()
        {
            return languages;
        }

        public String getCountryFlag()
        {
            return countryFlag;
        }

        public String getIsp()
        {
            return isp;
        }

        public String getConnectionType()
        {
            return connectionType;
        }

        public String getOrganization()
        {
            return organization;
        }

        public String getGeonameId()
        {
            return geonameId;
        }

        public GeolocationCurrency getCurrency()
        {
            return currency;
        }

        public GeolocationTimezone getTimezone()
        {
            return timezone;
        }
    }
}
