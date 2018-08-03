using System;
using Newtonsoft.Json.Linq;
namespace ipgeolocation
{
    public class GeolocationCurrency
    {
		private String name;
        private String code;

		public GeolocationCurrency(JObject json)
        {
			this.name = (String)json.GetValue("name");
			this.code = (String)json.GetValue("code");
        }

        public String getName()
        {
             return name;
        }

        public String getCode()
        {
            return code;
        }
    }
}
