using System;
namespace IPGeolocation
{
    public class GeolocationParams
    {
        private String ipAddress;
        private String[] ipAddresses;
        private String lang;
        private String fields;
        private Boolean includeHostname;
        private Boolean includeHostnameFallbackLive;
        private Boolean includeLiveHostname;
        private Boolean includeSecurity;
        private Boolean includeUserAgentDetail;

        private String excludes;

        public GeolocationParams()
        {
            this.ipAddress = "";
            this.ipAddresses = new String[0];
            this.lang = "en";
            this.fields = "";
            this.excludes = "";
            this.includeHostname = false;
            this.includeHostnameFallbackLive = false;
            this.includeLiveHostname = false;
        }

        public void SetIPAddress(String ipAddress)
        {
            this.ipAddress = Strings.NullToEmpty(ipAddress);
        }

        public String GetIPAddress()
        {
            return ipAddress;
        }

        public void SetIPAddresses(String[] ipAddresses)
        {
            if (ipAddresses.Length > 50)
            {
                throw new ArgumentException("Max. number of IP addresses cannot be more than 50.");
            }
            else
            {
                this.ipAddresses = ipAddresses;
            }
        }

        public String[] GetIPAddresses()
        {
            return ipAddresses;
        }

        public void SetLang(String lang)
        {
            this.lang = Strings.NullToEmpty(lang);
        }

        public String GetLang()
        {
            return lang;
        }

        public void SetFields(String fields)
        {
            this.fields = Strings.NullToEmpty(fields);
        }

        public String GetFields()
        {
            return fields;
        }

        public void SetIncludeHostname(Boolean includeHostname)
        {
            this.includeHostname = includeHostname;
        }

        public Boolean IsIncludeHostname()
        {
            return includeHostname;
        }

        public void SetIncludeHostnameFallbackLive(Boolean includeHostnameFallbackLive)
        {
            this.includeHostnameFallbackLive = includeHostnameFallbackLive;
        }

        public Boolean IsIncludeHostnameFallbackLive()
        {
            return includeHostnameFallbackLive;
        }

        public void SetIncludeLiveHostname(Boolean includeLiveHostname)
        {
            this.includeLiveHostname = includeLiveHostname;
        }

        public Boolean IsIncludeLiveHostname()
        {
            return includeLiveHostname;
        }

        public void SetIncludeSecurity(Boolean includeSecurity)
        {
            this.includeSecurity = includeSecurity;
        }

        public Boolean IsIncludeSecurity()
        {
            return includeSecurity;
        }

        public void SetIncludeUserAgentDetail(Boolean includeUserAgentDetail)
        {
            this.includeUserAgentDetail = includeUserAgentDetail;
        }

        public Boolean IsIncludeUserAgentDetail()
        {
            return includeUserAgentDetail;
        }

        public void SetExcludes(String excludes)
        {
            this.excludes = Strings.NullToEmpty(excludes);
        }
        public String GetExcludes()
        {
            return excludes;
        }
    }
}
