using System;
using Newtonsoft.Json.Linq;

namespace IPGeolocation
{
    public class UserAgent
    {
        private String userAgentString;
        private String name;
        private String type;
        private String version;
        private String versionMajor;
        private UserAgentDevice device;
        private UserAgentEngine engine;
        private UserAgentOperatingSystem operatingSystem;

        public UserAgent()
        {

        }
        public UserAgent(JObject json)
        {
            JToken token = json.GetValue("userAgentString");
            this.userAgentString = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("name");
            this.name = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("type");
            this.type = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("version");
            this.version = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("versionMajor");
            this.versionMajor = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("device");
            JObject deviceJson = token != null ? token.ToObject<JObject>() : null;
            this.device = new UserAgentDevice(deviceJson);

            token = json.GetValue("engine");
            JObject engineJson = token != null ? token.ToObject<JObject>() : null;
            this.engine = new UserAgentEngine(engineJson);

            token = json.GetValue("operatingSystem");
            JObject operatingSystemJson = token != null ? token.ToObject<JObject>() : null;
            this.operatingSystem = new UserAgentOperatingSystem(operatingSystemJson);
        }

        public String GetUserAgentString()
        {
            return userAgentString;
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

        public UserAgentDevice GetUserAgentDevice()
        {
            return device;
        }

        public UserAgentEngine GetUserAgentEngine()
        {
            return engine;
        }

        public UserAgentOperatingSystem GetUserAgentOperatingSystem()
        {
            return operatingSystem;
        }

    }
}