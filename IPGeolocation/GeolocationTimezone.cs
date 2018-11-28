using System;
using Newtonsoft.Json.Linq;

namespace IPGeolocation
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
            JToken token = json.GetValue("name");
            this.name = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("offset");
            this.offset = token != null ? token.ToObject<Double>() : 0.0;

            token = json.GetValue("current_time");
            this.currentTime = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("is_dst");
            this.isDST = token != null ? token.ToObject<Boolean>() : false;

            token = json.GetValue("dst_savings");
            this.dstSavings = token != null ? token.ToObject<Double>() : 0.0;
        }

        public String GetName()
        {
            return name;
        }

        public Double GetOffset()
        {
            return offset;
        }

        public String GetCurrentTime()
        {
            return currentTime;
        }

        public Double GetDSTSavings()
        {
            return dstSavings;
        }
    }
}
