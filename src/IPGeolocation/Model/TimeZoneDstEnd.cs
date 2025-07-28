

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
    /// TimeZoneDstEnd
    /// </summary>
    public partial class TimeZoneDstEnd : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeZoneDstEnd" /> class.
        /// </summary>
        /// <param name="utcTime">utcTime</param>
        /// <param name="duration">duration</param>
        /// <param name="gap">gap</param>
        /// <param name="dateTimeAfter">dateTimeAfter</param>
        /// <param name="dateTimeBefore">dateTimeBefore</param>
        /// <param name="overlap">overlap</param>
        [JsonConstructor]
        public TimeZoneDstEnd(Option<string?> utcTime = default, Option<string?> duration = default, Option<bool?> gap = default, Option<string?> dateTimeAfter = default, Option<string?> dateTimeBefore = default, Option<bool?> overlap = default)
        {
            UtcTimeOption = utcTime;
            DurationOption = duration;
            GapOption = gap;
            DateTimeAfterOption = dateTimeAfter;
            DateTimeBeforeOption = dateTimeBefore;
            OverlapOption = overlap;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of UtcTime
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> UtcTimeOption { get; private set; }

        /// <summary>
        /// Gets or Sets UtcTime
        /// </summary>
        /* <example>2025-11-02 TIME 09</example> */
        [JsonPropertyName("utc_time")]
        public string? UtcTime { get { return this.UtcTimeOption; } set { this.UtcTimeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Duration
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DurationOption { get; private set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        /* <example>-1H</example> */
        [JsonPropertyName("duration")]
        public string? Duration { get { return this.DurationOption; } set { this.DurationOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Gap
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> GapOption { get; private set; }

        /// <summary>
        /// Gets or Sets Gap
        /// </summary>
        /* <example>false</example> */
        [JsonPropertyName("gap")]
        public bool? Gap { get { return this.GapOption; } set { this.GapOption = new Option<bool?>(value); } }

        /// <summary>
        /// Used to track the state of DateTimeAfter
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DateTimeAfterOption { get; private set; }

        /// <summary>
        /// Gets or Sets DateTimeAfter
        /// </summary>
        /* <example>2025-11-02 TIME 01</example> */
        [JsonPropertyName("date_time_after")]
        public string? DateTimeAfter { get { return this.DateTimeAfterOption; } set { this.DateTimeAfterOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of DateTimeBefore
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DateTimeBeforeOption { get; private set; }

        /// <summary>
        /// Gets or Sets DateTimeBefore
        /// </summary>
        /* <example>2025-11-02 TIME 02</example> */
        [JsonPropertyName("date_time_before")]
        public string? DateTimeBefore { get { return this.DateTimeBeforeOption; } set { this.DateTimeBeforeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Overlap
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> OverlapOption { get; private set; }

        /// <summary>
        /// Gets or Sets Overlap
        /// </summary>
        /* <example>true</example> */
        [JsonPropertyName("overlap")]
        public bool? Overlap { get { return this.OverlapOption; } set { this.OverlapOption = new Option<bool?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TimeZoneDstEnd {\n");
            sb.Append("  UtcTime: ").Append(UtcTime).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Gap: ").Append(Gap).Append("\n");
            sb.Append("  DateTimeAfter: ").Append(DateTimeAfter).Append("\n");
            sb.Append("  DateTimeBefore: ").Append(DateTimeBefore).Append("\n");
            sb.Append("  Overlap: ").Append(Overlap).Append("\n");
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
    /// A Json converter for type <see cref="TimeZoneDstEnd" />
    /// </summary>
    public class TimeZoneDstEndJsonConverter : JsonConverter<TimeZoneDstEnd>
    {
        /// <summary>
        /// Deserializes json to <see cref="TimeZoneDstEnd" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TimeZoneDstEnd Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> utcTime = default;
            Option<string?> duration = default;
            Option<bool?> gap = default;
            Option<string?> dateTimeAfter = default;
            Option<string?> dateTimeBefore = default;
            Option<bool?> overlap = default;

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
                        case "utc_time":
                            utcTime = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "duration":
                            duration = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "gap":
                            gap = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "date_time_after":
                            dateTimeAfter = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "date_time_before":
                            dateTimeBefore = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "overlap":
                            overlap = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (utcTime.IsSet && utcTime.Value == null)
                throw new ArgumentNullException(nameof(utcTime), "Property is not nullable for class TimeZoneDstEnd.");

            if (duration.IsSet && duration.Value == null)
                throw new ArgumentNullException(nameof(duration), "Property is not nullable for class TimeZoneDstEnd.");

            if (gap.IsSet && gap.Value == null)
                throw new ArgumentNullException(nameof(gap), "Property is not nullable for class TimeZoneDstEnd.");

            if (dateTimeAfter.IsSet && dateTimeAfter.Value == null)
                throw new ArgumentNullException(nameof(dateTimeAfter), "Property is not nullable for class TimeZoneDstEnd.");

            if (dateTimeBefore.IsSet && dateTimeBefore.Value == null)
                throw new ArgumentNullException(nameof(dateTimeBefore), "Property is not nullable for class TimeZoneDstEnd.");

            if (overlap.IsSet && overlap.Value == null)
                throw new ArgumentNullException(nameof(overlap), "Property is not nullable for class TimeZoneDstEnd.");

            return new TimeZoneDstEnd(utcTime, duration, gap, dateTimeAfter, dateTimeBefore, overlap);
        }

        /// <summary>
        /// Serializes a <see cref="TimeZoneDstEnd" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="timeZoneDstEnd"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TimeZoneDstEnd timeZoneDstEnd, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, timeZoneDstEnd, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TimeZoneDstEnd" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="timeZoneDstEnd"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TimeZoneDstEnd timeZoneDstEnd, JsonSerializerOptions jsonSerializerOptions)
        {
            if (timeZoneDstEnd.UtcTimeOption.IsSet && timeZoneDstEnd.UtcTime == null)
                throw new ArgumentNullException(nameof(timeZoneDstEnd.UtcTime), "Property is required for class TimeZoneDstEnd.");

            if (timeZoneDstEnd.DurationOption.IsSet && timeZoneDstEnd.Duration == null)
                throw new ArgumentNullException(nameof(timeZoneDstEnd.Duration), "Property is required for class TimeZoneDstEnd.");

            if (timeZoneDstEnd.DateTimeAfterOption.IsSet && timeZoneDstEnd.DateTimeAfter == null)
                throw new ArgumentNullException(nameof(timeZoneDstEnd.DateTimeAfter), "Property is required for class TimeZoneDstEnd.");

            if (timeZoneDstEnd.DateTimeBeforeOption.IsSet && timeZoneDstEnd.DateTimeBefore == null)
                throw new ArgumentNullException(nameof(timeZoneDstEnd.DateTimeBefore), "Property is required for class TimeZoneDstEnd.");

            if (timeZoneDstEnd.UtcTimeOption.IsSet)
                writer.WriteString("utc_time", timeZoneDstEnd.UtcTime);

            if (timeZoneDstEnd.DurationOption.IsSet)
                writer.WriteString("duration", timeZoneDstEnd.Duration);

            if (timeZoneDstEnd.GapOption.IsSet)
                writer.WriteBoolean("gap", timeZoneDstEnd.GapOption.Value!.Value);

            if (timeZoneDstEnd.DateTimeAfterOption.IsSet)
                writer.WriteString("date_time_after", timeZoneDstEnd.DateTimeAfter);

            if (timeZoneDstEnd.DateTimeBeforeOption.IsSet)
                writer.WriteString("date_time_before", timeZoneDstEnd.DateTimeBefore);

            if (timeZoneDstEnd.OverlapOption.IsSet)
                writer.WriteBoolean("overlap", timeZoneDstEnd.OverlapOption.Value!.Value);
        }
    }
}
