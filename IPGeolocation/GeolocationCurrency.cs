using System;
using Newtonsoft.Json.Linq;

namespace IPGeolocation
{
    public class GeolocationCurrency
    {
        private String name;
        private String code;
        private String symbol;

        public GeolocationCurrency() { }
        public GeolocationCurrency(JObject json)
        {
            JToken token = json.GetValue("name");
            this.name = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("code");
            this.code = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("symbol");
            this.symbol = token != null ? token.ToObject<String>() : null;
        }

        public String GetName()
        {
            return name;
        }

        public String GetCode()
        {
            return code;
        }

        public String GetSymbol()
        {
            return symbol;
        }

    }
}
