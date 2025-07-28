

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
    /// TimezoneDetailDstStart
    /// </summary>
    public partial class TimezoneDetailDstStart : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimezoneDetailDstStart" /> class.
        /// </summary>
        /// <param name="utcTime">utcTime</param>
        /// <param name="duration">duration</param>
        /// <param name="gap">gap</param>
        /// <param name="dateTimeAfter">dateTimeAfter</param>
        /// <param name="dateTimeBefore">dateTimeBefore</param>
        /// <param name="overlap">overlap</param>
        [JsonConstructor]
        public TimezoneDetailDstStart(Option<string?> utcTime = default, Option<string?> duration = default, Option<bool?> gap = default, Option<string?> dateTimeAfter = default, Option<string?> dateTimeBefore = default, Option<bool?> overlap = default)
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
        /* <example>2025-03-09 TIME 10</example> */
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
        /* <example>+1H</example> */
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
        /* <example>2025-03-09 TIME 03</example> */
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
        /* <example>2025-03-09 TIME 02</example> */
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
        [JsonPropertyName("overlap")]
        public bool? Overlap { get { return this.OverlapOption; } set { this.OverlapOption = new Option<bool?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TimezoneDetailDstStart {\n");
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
    /// A Json converter for type <see cref="TimezoneDetailDstStart" />
    /// </summary>
    public class TimezoneDetailDstStartJsonConverter : JsonConverter<TimezoneDetailDstStart>
    {
        /// <summary>
        /// Deserializes json to <see cref="TimezoneDetailDstStart" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TimezoneDetailDstStart Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
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
                throw new ArgumentNullException(nameof(utcTime), "Property is not nullable for class TimezoneDetailDstStart.");

            if (duration.IsSet && duration.Value == null)
                throw new ArgumentNullException(nameof(duration), "Property is not nullable for class TimezoneDetailDstStart.");

            if (gap.IsSet && gap.Value == null)
                throw new ArgumentNullException(nameof(gap), "Property is not nullable for class TimezoneDetailDstStart.");

            if (dateTimeAfter.IsSet && dateTimeAfter.Value == null)
                throw new ArgumentNullException(nameof(dateTimeAfter), "Property is not nullable for class TimezoneDetailDstStart.");

            if (dateTimeBefore.IsSet && dateTimeBefore.Value == null)
                throw new ArgumentNullException(nameof(dateTimeBefore), "Property is not nullable for class TimezoneDetailDstStart.");

            if (overlap.IsSet && overlap.Value == null)
                throw new ArgumentNullException(nameof(overlap), "Property is not nullable for class TimezoneDetailDstStart.");

            return new TimezoneDetailDstStart(utcTime, duration, gap, dateTimeAfter, dateTimeBefore, overlap);
        }

        /// <summary>
        /// Serializes a <see cref="TimezoneDetailDstStart" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="timezoneDetailDstStart"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TimezoneDetailDstStart timezoneDetailDstStart, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, timezoneDetailDstStart, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TimezoneDetailDstStart" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="timezoneDetailDstStart"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TimezoneDetailDstStart timezoneDetailDstStart, JsonSerializerOptions jsonSerializerOptions)
        {
            if (timezoneDetailDstStart.UtcTimeOption.IsSet && timezoneDetailDstStart.UtcTime == null)
                throw new ArgumentNullException(nameof(timezoneDetailDstStart.UtcTime), "Property is required for class TimezoneDetailDstStart.");

            if (timezoneDetailDstStart.DurationOption.IsSet && timezoneDetailDstStart.Duration == null)
                throw new ArgumentNullException(nameof(timezoneDetailDstStart.Duration), "Property is required for class TimezoneDetailDstStart.");

            if (timezoneDetailDstStart.DateTimeAfterOption.IsSet && timezoneDetailDstStart.DateTimeAfter == null)
                throw new ArgumentNullException(nameof(timezoneDetailDstStart.DateTimeAfter), "Property is required for class TimezoneDetailDstStart.");

            if (timezoneDetailDstStart.DateTimeBeforeOption.IsSet && timezoneDetailDstStart.DateTimeBefore == null)
                throw new ArgumentNullException(nameof(timezoneDetailDstStart.DateTimeBefore), "Property is required for class TimezoneDetailDstStart.");

            if (timezoneDetailDstStart.UtcTimeOption.IsSet)
                writer.WriteString("utc_time", timezoneDetailDstStart.UtcTime);

            if (timezoneDetailDstStart.DurationOption.IsSet)
                writer.WriteString("duration", timezoneDetailDstStart.Duration);

            if (timezoneDetailDstStart.GapOption.IsSet)
                writer.WriteBoolean("gap", timezoneDetailDstStart.GapOption.Value!.Value);

            if (timezoneDetailDstStart.DateTimeAfterOption.IsSet)
                writer.WriteString("date_time_after", timezoneDetailDstStart.DateTimeAfter);

            if (timezoneDetailDstStart.DateTimeBeforeOption.IsSet)
                writer.WriteString("date_time_before", timezoneDetailDstStart.DateTimeBefore);

            if (timezoneDetailDstStart.OverlapOption.IsSet)
                writer.WriteBoolean("overlap", timezoneDetailDstStart.OverlapOption.Value!.Value);
        }
    }
}
