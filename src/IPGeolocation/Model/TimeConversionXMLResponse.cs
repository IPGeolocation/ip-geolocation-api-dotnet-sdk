

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
    /// TimeConversionXMLResponse
    /// </summary>
    public partial class TimeConversionXMLResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeConversionXMLResponse" /> class.
        /// </summary>
        /// <param name="originalTime">originalTime</param>
        /// <param name="convertedTime">convertedTime</param>
        /// <param name="diffHour">diffHour</param>
        /// <param name="diffMin">diffMin</param>
        [JsonConstructor]
        public TimeConversionXMLResponse(Option<string?> originalTime = default, Option<string?> convertedTime = default, Option<float?> diffHour = default, Option<int?> diffMin = default)
        {
            OriginalTimeOption = originalTime;
            ConvertedTimeOption = convertedTime;
            DiffHourOption = diffHour;
            DiffMinOption = diffMin;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of OriginalTime
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> OriginalTimeOption { get; private set; }

        /// <summary>
        /// Gets or Sets OriginalTime
        /// </summary>
        /* <example>2024-12-08 11:00</example> */
        [JsonPropertyName("original_time")]
        public string? OriginalTime { get { return this.OriginalTimeOption; } set { this.OriginalTimeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of ConvertedTime
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ConvertedTimeOption { get; private set; }

        /// <summary>
        /// Gets or Sets ConvertedTime
        /// </summary>
        /* <example>2024-12-08 18:30:00</example> */
        [JsonPropertyName("converted_time")]
        public string? ConvertedTime { get { return this.ConvertedTimeOption; } set { this.ConvertedTimeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of DiffHour
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<float?> DiffHourOption { get; private set; }

        /// <summary>
        /// Gets or Sets DiffHour
        /// </summary>
        /* <example>7.5</example> */
        [JsonPropertyName("diff_hour")]
        public float? DiffHour { get { return this.DiffHourOption; } set { this.DiffHourOption = new Option<float?>(value); } }

        /// <summary>
        /// Used to track the state of DiffMin
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> DiffMinOption { get; private set; }

        /// <summary>
        /// Gets or Sets DiffMin
        /// </summary>
        /* <example>450</example> */
        [JsonPropertyName("diff_min")]
        public int? DiffMin { get { return this.DiffMinOption; } set { this.DiffMinOption = new Option<int?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TimeConversionXMLResponse {\n");
            sb.Append("  OriginalTime: ").Append(OriginalTime).Append("\n");
            sb.Append("  ConvertedTime: ").Append(ConvertedTime).Append("\n");
            sb.Append("  DiffHour: ").Append(DiffHour).Append("\n");
            sb.Append("  DiffMin: ").Append(DiffMin).Append("\n");
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
    /// A Json converter for type <see cref="TimeConversionXMLResponse" />
    /// </summary>
    public class TimeConversionXMLResponseJsonConverter : JsonConverter<TimeConversionXMLResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="TimeConversionXMLResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TimeConversionXMLResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> originalTime = default;
            Option<string?> convertedTime = default;
            Option<float?> diffHour = default;
            Option<int?> diffMin = default;

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
                        case "original_time":
                            originalTime = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "converted_time":
                            convertedTime = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "diff_hour":
                            diffHour = new Option<float?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (float?)null : (float)utf8JsonReader.GetDouble());
                            break;
                        case "diff_min":
                            diffMin = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (originalTime.IsSet && originalTime.Value == null)
                throw new ArgumentNullException(nameof(originalTime), "Property is not nullable for class TimeConversionXMLResponse.");

            if (convertedTime.IsSet && convertedTime.Value == null)
                throw new ArgumentNullException(nameof(convertedTime), "Property is not nullable for class TimeConversionXMLResponse.");

            if (diffHour.IsSet && diffHour.Value == null)
                throw new ArgumentNullException(nameof(diffHour), "Property is not nullable for class TimeConversionXMLResponse.");

            if (diffMin.IsSet && diffMin.Value == null)
                throw new ArgumentNullException(nameof(diffMin), "Property is not nullable for class TimeConversionXMLResponse.");

            return new TimeConversionXMLResponse(originalTime, convertedTime, diffHour, diffMin);
        }

        /// <summary>
        /// Serializes a <see cref="TimeConversionXMLResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="timeConversionXMLResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TimeConversionXMLResponse timeConversionXMLResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, timeConversionXMLResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TimeConversionXMLResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="timeConversionXMLResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TimeConversionXMLResponse timeConversionXMLResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (timeConversionXMLResponse.OriginalTimeOption.IsSet && timeConversionXMLResponse.OriginalTime == null)
                throw new ArgumentNullException(nameof(timeConversionXMLResponse.OriginalTime), "Property is required for class TimeConversionXMLResponse.");

            if (timeConversionXMLResponse.ConvertedTimeOption.IsSet && timeConversionXMLResponse.ConvertedTime == null)
                throw new ArgumentNullException(nameof(timeConversionXMLResponse.ConvertedTime), "Property is required for class TimeConversionXMLResponse.");

            if (timeConversionXMLResponse.OriginalTimeOption.IsSet)
                writer.WriteString("original_time", timeConversionXMLResponse.OriginalTime);

            if (timeConversionXMLResponse.ConvertedTimeOption.IsSet)
                writer.WriteString("converted_time", timeConversionXMLResponse.ConvertedTime);

            if (timeConversionXMLResponse.DiffHourOption.IsSet)
                writer.WriteNumber("diff_hour", timeConversionXMLResponse.DiffHourOption.Value!.Value);

            if (timeConversionXMLResponse.DiffMinOption.IsSet)
                writer.WriteNumber("diff_min", timeConversionXMLResponse.DiffMinOption.Value!.Value);
        }
    }
}
