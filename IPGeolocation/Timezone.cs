using System;
using Newtonsoft.Json.Linq;

namespace IPGeolocation
{
    public class Timezone
    {
        private int status;
        private String message;
        private String timezone;
        private Double timezoneOffset;
        private Double timezoneOffsetWithDST;
        private String date;
        private String dateTime;
        private String dateTimeTxt;
        private String dateTimeWti;
        private String dateTimeYmd;
        private Double dateTimeUnix;
        private String time24;
        private String time12;
        private int week;
        private int month;
        private int year;
        private String yearAbbr;
        private Boolean dst;
        private Double dstSavings;
        private TimezoneGeo timezoneGeo;

        public Timezone(JObject json)
        {
            JToken token = json.GetValue("status");
            this.status = token != null ? token.ToObject<int>() : null;

            JToken token = json.GetValue("message");
            this.message = token != null ? token.ToObject<String>() :null;
            
            JToken token = json.GetValue("timezone");
            this.timezone = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("timezone_offset");
            this.timezoneOffset = token != null ? token.ToObject<Double>() : 0.0;

            token = json.GetValue("timezone_offset_with_dst");
            this.timezoneOffsetWithDST = token != null ? token.ToObject<Double>() : 0.0;

            token = json.GetValue("date");
            this.date = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("date_time");
            this.dateTime = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("date_time_txt");
            this.dateTimeTxt = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("date_time_wti");
            this.dateTimeWti = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("date_time_ymd");
            this.dateTimeYmd = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("date_time_unix");
            this.dateTimeUnix = token != null ? token.ToObject<Double>() : 0.0;

            token = json.GetValue("time_24");
            this.time24 = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("time_12");
            this.time12 = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("week");
            this.week = token != null ? token.ToObject<int>() : 0;

            token = json.GetValue("month");
            this.month = token != null ? token.ToObject<int>() : 0;

            token = json.GetValue("year");
            this.year = token != null ? token.ToObject<int>() : 0;

            token = json.GetValue("year_abbr");
            this.yearAbbr = token != null ? token.ToObject<String>() : null;

            token = json.GetValue("is_dst");
            this.dst = token != null ? token.ToObject<Boolean>() : false;

            token = json.GetValue("dst_savings");
            this.dstSavings = token != null ? token.ToObject<Double>() : 0.0;

            token = json.GetValue("geo");
            JObject geoJson = token != null ? token.ToObject<JObject>() : null;
            
            if (geoJson == null)
            {
                this.timezoneGeo = new TimezoneGeo();
            }
            else
            {
                this.timezoneGeo = new TimezoneGeo(geoJson);
            }
        }

        public int GetStatus()
        {
            return status;
        }
        public String GetMessage()
        {
            return message;
        }

        public String GetTimezone()
        {
            return timezone;
        }

        public Double GetTimezoneOffset()
        {
            return timezoneOffset;
        }

        public Double GetTimezoneOffsetWithDST()
        {
            return timezoneOffsetWithDST;
        }

        public String GetDate()
        {
            return date;
        }

        public String GetDateTime()
        {
            return dateTime;
        }

        public String GetDateTimeTxt()
        {
            return dateTimeTxt;
        }

        public String GetDateTimeWti()
        {
            return dateTimeWti;
        }

        public String GetDateTimeYmd()
        {
            return dateTimeYmd;
        }

        public Double GetDateTimeUnix()
        {
            return dateTimeUnix;
        }

        public String GetTime24()
        {
            return time24;
        }

        public String GetTime12()
        {
            return time12;
        }

        public int GetWeek()
        {
            return week;
        }

        public int GetMonth()
        {
            return month;
        }

        public int GetYear()
        {
            return year;
        }

        public String GetYearAbbr()
        {
            return yearAbbr;
        }

        public Boolean IsDST()
        {
            return dst;
        }

        public Double GetDSTSavings()
        {
            return dstSavings;
        }

        public TimezoneGeo GetTimezoneGeo()
        {
            return timezoneGeo;
        }
    }
}
