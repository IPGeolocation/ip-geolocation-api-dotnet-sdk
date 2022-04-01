using System;
using Newtonsoft.Json.Linq;

namespace IPGeolocation
{
    public class GeolocationSecurity
    {
        private int threatScore;
        private Boolean isTor;
        private Boolean isProxy;
        private String proxyType;
        private Boolean isAnonymous;
        private Boolean isKnownAttacker;
        private Boolean isBot;
        private Boolean isSpam;
        private Boolean isCloudProvider;

        public GeolocationSecurity()
        {
        }

        public GeolocationSecurity(JObject json)
        {
            JToken token = json.GetValue("threat_score");
            this.threatScore = token != null ? token.ToObject<int>() : 0;

            token = json.GetValue("is_tor");
            this.isTor = token != null ? token.ToObject<Boolean>() : false;

            token = json.GetValue("is_proxy");
            this.isProxy = token != null ? token.ToObject<Boolean>() : false;

            token = json.GetValue("proxy_type");
            this.proxyType = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("is_anonymous");
            this.isAnonymous = token != null ? token.ToObject<Boolean>() : false;

            token = json.GetValue("is_known_attacker");
            this.isKnownAttacker = token != null ? token.ToObject<Boolean>() : false;

            token = json.GetValue("is_bot");
            this.isBot = token != null ? token.ToObject<Boolean>() : false;

            token = json.GetValue("is_spam");
            this.isSpam = token != null ? token.ToObject<Boolean>() : false;

            token = json.GetValue("is_cloud_provider");
            this.isCloudProvider = token != null ? token.ToObject<Boolean>() : false;
        }

        public int GetThreatScore()
        {
            return threatScore;
        }

        public String GetProxyType()
        {
            return proxyType;
        }

        public Boolean IsTor()
        {
            return isTor;
        }

        public Boolean IsProxy()
        {
            return isProxy;
        }

        public Boolean IsAnonymous()
        {
            return isAnonymous;
        }

        public Boolean IsKnownAttacker()
        {
            return isKnownAttacker;
        }

        public Boolean IsBot()
        {
            return isBot;
        }

        public Boolean IsSpam()
        {
            return isSpam;
        }

        public Boolean IsCloudProvider()
        {
            return isCloudProvider;
        }
    }
}
