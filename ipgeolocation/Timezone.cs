using System;
using Newtonsoft.Json.Linq;

namespace ipgeolocation
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
			if (!json.GetValue("status").Equals("200"))
            {
				this.message = (String)json.GetValue("message");
            }
            else
            {
				this.timezone = (String)json.GetValue("timezone");
				this.timezoneOffset = (Double)json.GetValue("timezone_offset");
				this.date = (String)json.GetValue("date");
				this.dateTime = (String)json.GetValue("date_time");
				this.dateTimeTxt = (String)json.GetValue("date_time_txt");
				this.dateTimeWti = (String)json.GetValue("date_time_wti");
				this.dateTimeYmd = (String)json.GetValue("date_time_ymd");
				this.time24 = (String)json.GetValue("time_24");
				this.time12 = (String)json.GetValue("time_12");
				this.week = (String)json.GetValue("week");
				this.month = (String)json.GetValue("month");
				this.year = (String)json.GetValue("year");
				this.yearAbbr = (String)json.GetValue("year_abbr");
				this.isDst = (Boolean)json.GetValue("is_dst");
				this.dstSavings = (Double)json.GetValue("dst_savings");
                JObject geoJson = (JObject)json.GetValue("geo");
                this.timezoneGeo = new TimezoneGeo(geoJson);

            }
			this.status = int.Parse((String)json.GetValue("status"));
        }

		public int getStatus()
        {
            return status;
        }

        public String getMessage()
        {
            return message;
        }

        public String getTimezone()
        {
            return timezone;
        }

        public Double getTimezoneOffset()
        {
            return timezoneOffset;
        }

        public String getDate()
        {
            return date;
        }

        public String getDateTime()
        {
            return dateTime;
        }

        public String getDateTimeTxt()
        {
            return dateTimeTxt;
        }

        public String getDateTimeWti()
        {
            return dateTimeWti;
        }

        public String getDateTimeYmd()
        {
            return dateTimeYmd;
        }

        public String getTime24()
        {
            return time24;
        }

        public String getTime12()
        {
            return time12;
        }

        public String getWeek()
        {
            return week;
        }

        public String getMonth()
        {
            return month;
        }

        public String getYear()
        {
            return year;
        }

        public String getYearAbbr()
        {
            return yearAbbr;
        }

        public Double getDstSavings()
        {
            return dstSavings;
        }

        public TimezoneGeo getTimezoneGeo()
        {
            return timezoneGeo;
        }
    }
}
