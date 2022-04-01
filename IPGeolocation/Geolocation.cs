using System;
using Newtonsoft.Json.Linq;

namespace IPGeolocation
{
    public class Geolocation
    {
        private String domain;
        private String ipAddress;
        private String hostname;
        private String continentCode;
        private String continentName;
        private String countryCode2;
        private String countryCode3;
        private String countryName;
        private String countryCapital;
        private String stateProvince;
        private String district;
        private String city;
        private String zipCode;
        private String latitude;
        private String longitude;
        private Boolean isEU;
        private String callingCode;
        private String countryTLD;
        private String languages;
        private String countryFlag;
        private String isp;
        private String connectionType;
        private String organization;
        private String asn;
        private String geonameID;
        private GeolocationCurrency currency;
        private GeolocationTimezone timezone;
        private GeolocationSecurity security;
        private UserAgent userAgentDetail;

        public Geolocation(JObject json)
        {
            JToken token = json.GetValue("domain");
            this.domain = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("ip");
            this.ipAddress = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("hostname");
            this.hostname = token != null ? token.ToObject<String>() : null;

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
            this.zipCode = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("latitude");
            this.latitude = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("longitude");
            this.longitude = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("is_eu");
            this.isEU = token != null ? token.ToObject<Boolean>() : false;

            token = json.GetValue("calling_code");
            this.callingCode = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("country_tld");
            this.countryTLD = token != null ? token.ToObject<String>() : null;

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
            this.geonameID = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("asn");
            this.asn = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("currency");
            JObject currencyJson = token != null ? token.ToObject<JObject>() : null;

            if (currencyJson == null)
            {
                this.currency = new GeolocationCurrency();
            }
            else
            {
                this.currency = new GeolocationCurrency(currencyJson);
            }

            token = json.GetValue("time_zone");

            JObject timezoneJson = token != null ? token.ToObject<JObject>() : null;
            
            if (timezoneJson == null)
            {
                this.timezone = new GeolocationTimezone();
            }
            else
            {
                this.timezone = new GeolocationTimezone(timezoneJson);
            }

            token = json.GetValue("security");

            JObject securityJson = token != null ? token.ToObject<JObject>() : null;
            
            if (securityJson == null)
            {
                this.security = new GeolocationSecurity();
            }
            else
            {
                this.security = new GeolocationSecurity(securityJson);
            }

            token = json.GetValue("user_agent");

            JObject userAgentJson = token != null ? token.ToObject<JObject>() : null;
            
            if (userAgentJson == null)
            {
                this.userAgentDetail = new UserAgent();
            }
            else
            {
                this.userAgentDetail = new UserAgent(userAgentJson);
            }
        }

        public String GetDomain()
        {
            return domain;
        }
        public String GetIPAddress()
        {
            return ipAddress;
        }
        public String GetHostname()
        {
            return hostname;
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

        public Boolean IsEU()
        {
            return isEU;
        }

        public GeolocationTimezone GetTimezone()
        {
            return timezone;
        }
        public String GetCallingCode()
        {
            return callingCode;
        }

        public String GetCountryTLD()
        {
            return countryTLD;
        }

        public String GetLanguages()
        {
            return languages;
        }

        public String GetCountryFlag()
        {
            return countryFlag;
        }

        public String GetISP()
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

        public String GetGeonameID()
        {
            return geonameID;
        }

        public String GetASN()
        {
            return asn;
        }

        public GeolocationCurrency GetCurrency()
        {
            return currency;
        }

        public GeolocationSecurity GetSecurity()
        {
            return security;
        }

        public UserAgent GetUserAgent()
        {
            return userAgentDetail;
        }
    }
}
