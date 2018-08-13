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
        private String date;
        private String dateTime;
        private String dateTimeTxt;
        private String dateTimeWti;
        private String dateTimeYmd;
        private String time24;
        private String time12;
        private String week;
        private String month;
        private String year;
        private String yearAbbr;
        private Boolean isDst { get; set; }
        private Double dstSavings;
        private TimezoneGeo timezoneGeo;

        public Timezone(JObject json)
        {
            this.status = json.GetValue("status").ToObject<int>();

            JToken token = json.GetValue("message");
            String message = token != null ? token.ToObject<String>() : null;

            if (this.status != 200 || message != null)
            {
                this.message = message;
            }
            else
            {
                token = json.GetValue("timezone");
                this.timezone = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("timezone_offset");
                this.timezoneOffset = token != null ? token.ToObject<Double>() : 0.0;

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

                token = json.GetValue("time_24");
                this.time24 = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("time_12");
                this.time12 = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("week");
                this.week = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("month");
                this.month = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("year");
                this.year = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("year_abbr");
                this.yearAbbr = token != null ? token.ToObject<String>() : null;

                token = json.GetValue("is_dst");
                this.isDst = token != null ? token.ToObject<Boolean>() : false;

                token = json.GetValue("dst_savings");
                this.dstSavings = token != null ? token.ToObject<Double>() : 0.0;

                token = json.GetValue("geo");
                JObject geoJson = token != null ? token.ToObject<JObject>() : null;
                this.timezoneGeo = new TimezoneGeo(geoJson);

            }
            this.status = int.Parse((String)json.GetValue("status"));
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

        public String GetTime24()
        {
            return time24;
        }

        public String GetTime12()
        {
            return time12;
        }

        public String GetWeek()
        {
            return week;
        }

        public String GetMonth()
        {
            return month;
        }

        public String GetYear()
        {
            return year;
        }

        public String GetYearAbbr()
        {
            return yearAbbr;
        }

        public Double GetDstSavings()
        {
            return dstSavings;
        }

        public TimezoneGeo GetTimezoneGeo()
        {
            return timezoneGeo;
        }
    }
}
