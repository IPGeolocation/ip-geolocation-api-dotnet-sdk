using System;
using Newtonsoft.Json.Linq;

namespace IPGeolocation
{
    public class GeolocationTimezone
    {
        private String name;
        private Double offset;
        private String currentTime;
        private Double currentTimeUnix;
        private Boolean dst;
        private Double dstSavings;

        public GeolocationTimezone() { }
        public GeolocationTimezone(JObject json)
        {
            JToken token = json.GetValue("name");
            this.name = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("offset");
            this.offset = token != null ? token.ToObject<Double>() : 0.0;

            token = json.GetValue("current_time");
            this.currentTime = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("current_time_unix");
            this.currentTimeUnix = token != null ? token.ToObject<Double>() : 0.0;

            token = json.GetValue("is_dst");
            this.dst = token != null ? token.ToObject<Boolean>() : false;

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

        public Double GetCurrentTimeUnix()
        {
            return currentTimeUnix;
        }

        public Boolean IsDST(){
            return dst;
        }

        public Double GetDSTSavings()
        {
            return dstSavings;
        }
    }
}
