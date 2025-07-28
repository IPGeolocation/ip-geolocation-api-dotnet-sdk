

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using IPGeolocation.Client;

namespace IPGeolocation.Model
{
    /// <summary>
    /// TimezoneDetail
    /// </summary>
    public partial class TimezoneDetail : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimezoneDetail" /> class.
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="offset">offset</param>
        /// <param name="offsetWithDst">offsetWithDst</param>
        /// <param name="date">date</param>
        /// <param name="dateTime">dateTime</param>
        /// <param name="dateTimeTxt">dateTimeTxt</param>
        /// <param name="dateTimeWti">dateTimeWti</param>
        /// <param name="dateTimeYmd">dateTimeYmd</param>
        /// <param name="dateTimeUnix">dateTimeUnix</param>
        /// <param name="time24">time24</param>
        /// <param name="time12">time12</param>
        /// <param name="week">week</param>
        /// <param name="month">month</param>
        /// <param name="year">year</param>
        /// <param name="yearAbbr">yearAbbr</param>
        /// <param name="isDst">isDst</param>
        /// <param name="dstSavings">dstSavings</param>
        /// <param name="dstExists">dstExists</param>
        /// <param name="dstStart">dstStart</param>
        /// <param name="dstEnd">dstEnd</param>
        [JsonConstructor]
        public TimezoneDetail(Option<string?> name = default, Option<int?> offset = default, Option<int?> offsetWithDst = default, Option<DateTimeOffset?> date = default, Option<string?> dateTime = default, Option<string?> dateTimeTxt = default, Option<string?> dateTimeWti = default, Option<DateTimeOffset?> dateTimeYmd = default, Option<double?> dateTimeUnix = default, Option<string?> time24 = default, Option<string?> time12 = default, Option<int?> week = default, Option<int?> month = default, Option<int?> year = default, Option<string?> yearAbbr = default, Option<bool?> isDst = default, Option<int?> dstSavings = default, Option<bool?> dstExists = default, Option<TimezoneDetailDstStart?> dstStart = default, Option<TimezoneDetailDstEnd?> dstEnd = default)
        {
            NameOption = name;
            OffsetOption = offset;
            OffsetWithDstOption = offsetWithDst;
            DateOption = date;
            DateTimeOption = dateTime;
            DateTimeTxtOption = dateTimeTxt;
            DateTimeWtiOption = dateTimeWti;
            DateTimeYmdOption = dateTimeYmd;
            DateTimeUnixOption = dateTimeUnix;
            Time24Option = time24;
            Time12Option = time12;
            WeekOption = week;
            MonthOption = month;
            YearOption = year;
            YearAbbrOption = yearAbbr;
            IsDstOption = isDst;
            DstSavingsOption = dstSavings;
            DstExistsOption = dstExists;
            DstStartOption = dstStart;
            DstEndOption = dstEnd;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NameOption { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /* <example>America/Los_Angeles</example> */
        [JsonPropertyName("name")]
        public string? Name { get { return this.NameOption; } set { this.NameOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Offset
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> OffsetOption { get; private set; }

        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        /* <example>-8</example> */
        [JsonPropertyName("offset")]
        public int? Offset { get { return this.OffsetOption; } set { this.OffsetOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of OffsetWithDst
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> OffsetWithDstOption { get; private set; }

        /// <summary>
        /// Gets or Sets OffsetWithDst
        /// </summary>
        /* <example>-7</example> */
        [JsonPropertyName("offset_with_dst")]
        public int? OffsetWithDst { get { return this.OffsetWithDstOption; } set { this.OffsetWithDstOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of Date
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTimeOffset?> DateOption { get; private set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        /* <example>Thu Apr 24 05:00:00 PKT 2025</example> */
        [JsonPropertyName("date")]
        public DateTimeOffset? Date { get { return this.DateOption; } set { this.DateOption = new Option<DateTimeOffset?>(value); } }

        /// <summary>
        /// Used to track the state of DateTime
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DateTimeOption { get; private set; }

        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        /* <example>2025-04-24 11:30:12</example> */
        [JsonPropertyName("date_time")]
        public string? DateTime { get { return this.DateTimeOption; } set { this.DateTimeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of DateTimeTxt
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DateTimeTxtOption { get; private set; }

        /// <summary>
        /// Gets or Sets DateTimeTxt
        /// </summary>
        /* <example>Thursday, April 24, 2025 11:30:12</example> */
        [JsonPropertyName("date_time_txt")]
        public string? DateTimeTxt { get { return this.DateTimeTxtOption; } set { this.DateTimeTxtOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of DateTimeWti
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DateTimeWtiOption { get; private set; }

        /// <summary>
        /// Gets or Sets DateTimeWti
        /// </summary>
        /* <example>Thu, 24 Apr 2025 11:30:12 -0700</example> */
        [JsonPropertyName("date_time_wti")]
        public string? DateTimeWti { get { return this.DateTimeWtiOption; } set { this.DateTimeWtiOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of DateTimeYmd
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTimeOffset?> DateTimeYmdOption { get; private set; }

        /// <summary>
        /// Gets or Sets DateTimeYmd
        /// </summary>
        [JsonPropertyName("date_time_ymd")]
        public DateTimeOffset? DateTimeYmd { get { return this.DateTimeYmdOption; } set { this.DateTimeYmdOption = new Option<DateTimeOffset?>(value); } }

        /// <summary>
        /// Used to track the state of DateTimeUnix
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> DateTimeUnixOption { get; private set; }

        /// <summary>
        /// Gets or Sets DateTimeUnix
        /// </summary>
        /* <example>1745519412.353</example> */
        [JsonPropertyName("date_time_unix")]
        public double? DateTimeUnix { get { return this.DateTimeUnixOption; } set { this.DateTimeUnixOption = new Option<double?>(value); } }

        /// <summary>
        /// Used to track the state of Time24
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> Time24Option { get; private set; }

        /// <summary>
        /// Gets or Sets Time24
        /// </summary>
        /* <example>41412</example> */
        [JsonPropertyName("time_24")]
        public string? Time24 { get { return this.Time24Option; } set { this.Time24Option = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Time12
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> Time12Option { get; private set; }

        /// <summary>
        /// Gets or Sets Time12
        /// </summary>
        /* <example>11:30:12 AM</example> */
        [JsonPropertyName("time_12")]
        public string? Time12 { get { return this.Time12Option; } set { this.Time12Option = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Week
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> WeekOption { get; private set; }

        /// <summary>
        /// Gets or Sets Week
        /// </summary>
        /* <example>17</example> */
        [JsonPropertyName("week")]
        public int? Week { get { return this.WeekOption; } set { this.WeekOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of Month
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> MonthOption { get; private set; }

        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        /* <example>4</example> */
        [JsonPropertyName("month")]
        public int? Month { get { return this.MonthOption; } set { this.MonthOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of Year
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> YearOption { get; private set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        /* <example>2025</example> */
        [JsonPropertyName("year")]
        public int? Year { get { return this.YearOption; } set { this.YearOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of YearAbbr
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> YearAbbrOption { get; private set; }

        /// <summary>
        /// Gets or Sets YearAbbr
        /// </summary>
        /* <example>25</example> */
        [JsonPropertyName("year_abbr")]
        public string? YearAbbr { get { return this.YearAbbrOption; } set { this.YearAbbrOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of IsDst
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsDstOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsDst
        /// </summary>
        [JsonPropertyName("is_dst")]
        public bool? IsDst { get { return this.IsDstOption; } set { this.IsDstOption = new Option<bool?>(value); } }

        /// <summary>
        /// Used to track the state of DstSavings
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> DstSavingsOption { get; private set; }

        /// <summary>
        /// Gets or Sets DstSavings
        /// </summary>
        [JsonPropertyName("dst_savings")]
        public int? DstSavings { get { return this.DstSavingsOption; } set { this.DstSavingsOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of DstExists
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> DstExistsOption { get; private set; }

        /// <summary>
        /// Gets or Sets DstExists
        /// </summary>
        [JsonPropertyName("dst_exists")]
        public bool? DstExists { get { return this.DstExistsOption; } set { this.DstExistsOption = new Option<bool?>(value); } }

        /// <summary>
        /// Used to track the state of DstStart
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<TimezoneDetailDstStart?> DstStartOption { get; private set; }

        /// <summary>
        /// Gets or Sets DstStart
        /// </summary>
        [JsonPropertyName("dst_start")]
        public TimezoneDetailDstStart? DstStart { get { return this.DstStartOption; } set { this.DstStartOption = new Option<TimezoneDetailDstStart?>(value); } }

        /// <summary>
        /// Used to track the state of DstEnd
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<TimezoneDetailDstEnd?> DstEndOption { get; private set; }

        /// <summary>
        /// Gets or Sets DstEnd
        /// </summary>
        [JsonPropertyName("dst_end")]
        public TimezoneDetailDstEnd? DstEnd { get { return this.DstEndOption; } set { this.DstEndOption = new Option<TimezoneDetailDstEnd?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TimezoneDetail {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  OffsetWithDst: ").Append(OffsetWithDst).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  DateTimeTxt: ").Append(DateTimeTxt).Append("\n");
            sb.Append("  DateTimeWti: ").Append(DateTimeWti).Append("\n");
            sb.Append("  DateTimeYmd: ").Append(DateTimeYmd).Append("\n");
            sb.Append("  DateTimeUnix: ").Append(DateTimeUnix).Append("\n");
            sb.Append("  Time24: ").Append(Time24).Append("\n");
            sb.Append("  Time12: ").Append(Time12).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  YearAbbr: ").Append(YearAbbr).Append("\n");
            sb.Append("  IsDst: ").Append(IsDst).Append("\n");
            sb.Append("  DstSavings: ").Append(DstSavings).Append("\n");
            sb.Append("  DstExists: ").Append(DstExists).Append("\n");
            sb.Append("  DstStart: ").Append(DstStart).Append("\n");
            sb.Append("  DstEnd: ").Append(DstEnd).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="TimezoneDetail" />
    /// </summary>
    public class TimezoneDetailJsonConverter : JsonConverter<TimezoneDetail>
    {
        /// <summary>
        /// The format to use to serialize Date
        /// </summary>
        public static string DateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// The format to use to serialize DateTimeYmd
        /// </summary>
        public static string DateTimeYmdFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="TimezoneDetail" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TimezoneDetail Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> name = default;
            Option<int?> offset = default;
            Option<int?> offsetWithDst = default;
            Option<DateTimeOffset?> date = default;
            Option<string?> dateTime = default;
            Option<string?> dateTimeTxt = default;
            Option<string?> dateTimeWti = default;
            Option<DateTimeOffset?> dateTimeYmd = default;
            Option<double?> dateTimeUnix = default;
            Option<string?> time24 = default;
            Option<string?> time12 = default;
            Option<int?> week = default;
            Option<int?> month = default;
            Option<int?> year = default;
            Option<string?> yearAbbr = default;
            Option<bool?> isDst = default;
            Option<int?> dstSavings = default;
            Option<bool?> dstExists = default;
            Option<TimezoneDetailDstStart?> dstStart = default;
            Option<TimezoneDetailDstEnd?> dstEnd = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "offset":
                            offset = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "offset_with_dst":
                            offsetWithDst = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "date":
                            date = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "date_time":
                            dateTime = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "date_time_txt":
                            dateTimeTxt = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "date_time_wti":
                            dateTimeWti = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "date_time_ymd":
                            dateTimeYmd = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "date_time_unix":
                            dateTimeUnix = new Option<double?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (double?)null : utf8JsonReader.GetDouble());
                            break;
                        case "time_24":
                            time24 = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "time_12":
                            time12 = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "week":
                            week = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "month":
                            month = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "year":
                            year = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "year_abbr":
                            yearAbbr = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "is_dst":
                            isDst = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "dst_savings":
                            dstSavings = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "dst_exists":
                            dstExists = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "dst_start":
                            dstStart = new Option<TimezoneDetailDstStart?>(JsonSerializer.Deserialize<TimezoneDetailDstStart>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "dst_end":
                            dstEnd = new Option<TimezoneDetailDstEnd?>(JsonSerializer.Deserialize<TimezoneDetailDstEnd>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class TimezoneDetail.");

            if (offset.IsSet && offset.Value == null)
                throw new ArgumentNullException(nameof(offset), "Property is not nullable for class TimezoneDetail.");

            if (offsetWithDst.IsSet && offsetWithDst.Value == null)
                throw new ArgumentNullException(nameof(offsetWithDst), "Property is not nullable for class TimezoneDetail.");

            if (date.IsSet && date.Value == null)
                throw new ArgumentNullException(nameof(date), "Property is not nullable for class TimezoneDetail.");

            if (dateTime.IsSet && dateTime.Value == null)
                throw new ArgumentNullException(nameof(dateTime), "Property is not nullable for class TimezoneDetail.");

            if (dateTimeTxt.IsSet && dateTimeTxt.Value == null)
                throw new ArgumentNullException(nameof(dateTimeTxt), "Property is not nullable for class TimezoneDetail.");

            if (dateTimeWti.IsSet && dateTimeWti.Value == null)
                throw new ArgumentNullException(nameof(dateTimeWti), "Property is not nullable for class TimezoneDetail.");

            if (dateTimeYmd.IsSet && dateTimeYmd.Value == null)
                throw new ArgumentNullException(nameof(dateTimeYmd), "Property is not nullable for class TimezoneDetail.");

            if (dateTimeUnix.IsSet && dateTimeUnix.Value == null)
                throw new ArgumentNullException(nameof(dateTimeUnix), "Property is not nullable for class TimezoneDetail.");

            if (time24.IsSet && time24.Value == null)
                throw new ArgumentNullException(nameof(time24), "Property is not nullable for class TimezoneDetail.");

            if (time12.IsSet && time12.Value == null)
                throw new ArgumentNullException(nameof(time12), "Property is not nullable for class TimezoneDetail.");

            if (week.IsSet && week.Value == null)
                throw new ArgumentNullException(nameof(week), "Property is not nullable for class TimezoneDetail.");

            if (month.IsSet && month.Value == null)
                throw new ArgumentNullException(nameof(month), "Property is not nullable for class TimezoneDetail.");

            if (year.IsSet && year.Value == null)
                throw new ArgumentNullException(nameof(year), "Property is not nullable for class TimezoneDetail.");

            if (yearAbbr.IsSet && yearAbbr.Value == null)
                throw new ArgumentNullException(nameof(yearAbbr), "Property is not nullable for class TimezoneDetail.");

            if (isDst.IsSet && isDst.Value == null)
                throw new ArgumentNullException(nameof(isDst), "Property is not nullable for class TimezoneDetail.");

            if (dstSavings.IsSet && dstSavings.Value == null)
                throw new ArgumentNullException(nameof(dstSavings), "Property is not nullable for class TimezoneDetail.");

            if (dstExists.IsSet && dstExists.Value == null)
                throw new ArgumentNullException(nameof(dstExists), "Property is not nullable for class TimezoneDetail.");

            if (dstStart.IsSet && dstStart.Value == null)
                throw new ArgumentNullException(nameof(dstStart), "Property is not nullable for class TimezoneDetail.");

            if (dstEnd.IsSet && dstEnd.Value == null)
                throw new ArgumentNullException(nameof(dstEnd), "Property is not nullable for class TimezoneDetail.");

            return new TimezoneDetail(name, offset, offsetWithDst, date, dateTime, dateTimeTxt, dateTimeWti, dateTimeYmd, dateTimeUnix, time24, time12, week, month, year, yearAbbr, isDst, dstSavings, dstExists, dstStart, dstEnd);
        }

        /// <summary>
        /// Serializes a <see cref="TimezoneDetail" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="timezoneDetail"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TimezoneDetail timezoneDetail, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, timezoneDetail, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TimezoneDetail" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="timezoneDetail"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TimezoneDetail timezoneDetail, JsonSerializerOptions jsonSerializerOptions)
        {
            if (timezoneDetail.NameOption.IsSet && timezoneDetail.Name == null)
                throw new ArgumentNullException(nameof(timezoneDetail.Name), "Property is required for class TimezoneDetail.");

            if (timezoneDetail.DateTimeOption.IsSet && timezoneDetail.DateTime == null)
                throw new ArgumentNullException(nameof(timezoneDetail.DateTime), "Property is required for class TimezoneDetail.");

            if (timezoneDetail.DateTimeTxtOption.IsSet && timezoneDetail.DateTimeTxt == null)
                throw new ArgumentNullException(nameof(timezoneDetail.DateTimeTxt), "Property is required for class TimezoneDetail.");

            if (timezoneDetail.DateTimeWtiOption.IsSet && timezoneDetail.DateTimeWti == null)
                throw new ArgumentNullException(nameof(timezoneDetail.DateTimeWti), "Property is required for class TimezoneDetail.");

            if (timezoneDetail.Time24Option.IsSet && timezoneDetail.Time24 == null)
                throw new ArgumentNullException(nameof(timezoneDetail.Time24), "Property is required for class TimezoneDetail.");

            if (timezoneDetail.Time12Option.IsSet && timezoneDetail.Time12 == null)
                throw new ArgumentNullException(nameof(timezoneDetail.Time12), "Property is required for class TimezoneDetail.");

            if (timezoneDetail.YearAbbrOption.IsSet && timezoneDetail.YearAbbr == null)
                throw new ArgumentNullException(nameof(timezoneDetail.YearAbbr), "Property is required for class TimezoneDetail.");

            if (timezoneDetail.DstStartOption.IsSet && timezoneDetail.DstStart == null)
                throw new ArgumentNullException(nameof(timezoneDetail.DstStart), "Property is required for class TimezoneDetail.");

            if (timezoneDetail.DstEndOption.IsSet && timezoneDetail.DstEnd == null)
                throw new ArgumentNullException(nameof(timezoneDetail.DstEnd), "Property is required for class TimezoneDetail.");

            if (timezoneDetail.NameOption.IsSet)
                writer.WriteString("name", timezoneDetail.Name);

            if (timezoneDetail.OffsetOption.IsSet)
                writer.WriteNumber("offset", timezoneDetail.OffsetOption.Value!.Value);

            if (timezoneDetail.OffsetWithDstOption.IsSet)
                writer.WriteNumber("offset_with_dst", timezoneDetail.OffsetWithDstOption.Value!.Value);

            if (timezoneDetail.DateOption.IsSet)
                writer.WriteString("date", timezoneDetail.DateOption.Value!.Value.ToString(DateFormat));

            if (timezoneDetail.DateTimeOption.IsSet)
                writer.WriteString("date_time", timezoneDetail.DateTime);

            if (timezoneDetail.DateTimeTxtOption.IsSet)
                writer.WriteString("date_time_txt", timezoneDetail.DateTimeTxt);

            if (timezoneDetail.DateTimeWtiOption.IsSet)
                writer.WriteString("date_time_wti", timezoneDetail.DateTimeWti);

            if (timezoneDetail.DateTimeYmdOption.IsSet)
                writer.WriteString("date_time_ymd", timezoneDetail.DateTimeYmdOption.Value!.Value.ToString(DateTimeYmdFormat));

            if (timezoneDetail.DateTimeUnixOption.IsSet)
                writer.WriteNumber("date_time_unix", timezoneDetail.DateTimeUnixOption.Value!.Value);

            if (timezoneDetail.Time24Option.IsSet)
                writer.WriteString("time_24", timezoneDetail.Time24);

            if (timezoneDetail.Time12Option.IsSet)
                writer.WriteString("time_12", timezoneDetail.Time12);

            if (timezoneDetail.WeekOption.IsSet)
                writer.WriteNumber("week", timezoneDetail.WeekOption.Value!.Value);

            if (timezoneDetail.MonthOption.IsSet)
                writer.WriteNumber("month", timezoneDetail.MonthOption.Value!.Value);

            if (timezoneDetail.YearOption.IsSet)
                writer.WriteNumber("year", timezoneDetail.YearOption.Value!.Value);

            if (timezoneDetail.YearAbbrOption.IsSet)
                writer.WriteString("year_abbr", timezoneDetail.YearAbbr);

            if (timezoneDetail.IsDstOption.IsSet)
                writer.WriteBoolean("is_dst", timezoneDetail.IsDstOption.Value!.Value);

            if (timezoneDetail.DstSavingsOption.IsSet)
                writer.WriteNumber("dst_savings", timezoneDetail.DstSavingsOption.Value!.Value);

            if (timezoneDetail.DstExistsOption.IsSet)
                writer.WriteBoolean("dst_exists", timezoneDetail.DstExistsOption.Value!.Value);

            if (timezoneDetail.DstStartOption.IsSet)
            {
                writer.WritePropertyName("dst_start");
                JsonSerializer.Serialize(writer, timezoneDetail.DstStart, jsonSerializerOptions);
            }
            if (timezoneDetail.DstEndOption.IsSet)
            {
                writer.WritePropertyName("dst_end");
                JsonSerializer.Serialize(writer, timezoneDetail.DstEnd, jsonSerializerOptions);
            }
        }
    }
}
