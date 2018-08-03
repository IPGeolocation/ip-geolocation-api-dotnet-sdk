using System;
using Newtonsoft.Json.Linq;
namespace ipgeolocation
{
    public class GeolocationTimezone
    {
		private String name;
        private Double offset;
        private String currentTime;
        private Boolean isDST { get; set; }
        private Double dstSavings;

		public GeolocationTimezone(JObject json)
        {
			this.name = (String)json.GetValue("name");
			this.offset = (Double)json.GetValue("offset");
			this.currentTime = (String)json.GetValue("current_time");
			this.isDST = (Boolean)json.GetValue("is_dst");
			this.dstSavings = (Double)json.GetValue("dst_savings");
        }

        public String getName()
        {
            return name;
        }

        public Double getOffset()
        {
            return offset;
        }

        public String getCurrentTime()
        {
            return currentTime;
        }

        public Double getDstSavings()
        {
            return dstSavings;
        }
    }
}
