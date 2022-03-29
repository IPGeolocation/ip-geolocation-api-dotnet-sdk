using System;
using Newtonsoft.Json.Linq;

namespace IPGeolocation
{
    public class UserAgentDevice
    {
        private String name;
        private String type;
        private String brand;
        private String cpu;

        public UserAgentDevice(JObject json)
        {
            JToken token = json.GetValue("name");
            this.name = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("type");
            this.type = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("brand");
            this.brand = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("CPU");
            this.cpu = token != null ? token.ToObject<String>() : null;
        }

        public String GetName()
        {
            return name;
        }

        public new String GetType()
        {
            return type;
        }

        public String GetBrand()
        {
            return brand;
        }

        public String GetCPU()
        {
            return cpu;
        }

    }
}
