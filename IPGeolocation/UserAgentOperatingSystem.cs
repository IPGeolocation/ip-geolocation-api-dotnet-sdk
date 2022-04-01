using System;
using Newtonsoft.Json.Linq;

namespace IPGeolocation
{
    public class UserAgentOperatingSystem
    {
        private String name;
        private String type;
        private String version;
        private String versionMajor;

        public UserAgentOperatingSystem(JObject json)
        {
            JToken token = json.GetValue("name");
            this.name = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("type");
            this.type = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("version");
            this.version = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("versionMajor");
            this.versionMajor = token != null ? token.ToObject<String>() : null;
        }

        public String GetName()
        {
            return name;
        }

        public new String GetType()
        {
            return type;
        }

        public String GetVersion()
        {
            return version;
        }

        public String GetVersionMajor()
        {
            return versionMajor;
        }
    }
}