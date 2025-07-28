

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
    /// ModelTimeZone
    /// </summary>
    public partial class ModelTimeZone : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelTimeZone" /> class.
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="offset">offset</param>
        /// <param name="offsetWithDst">offsetWithDst</param>
        /// <param name="currentTime">currentTime</param>
        /// <param name="currentTimeUnix">currentTimeUnix</param>
        /// <param name="isDst">isDst</param>
        /// <param name="dstSavings">dstSavings</param>
        /// <param name="dstExists">dstExists</param>
        /// <param name="dstStart">dstStart</param>
        /// <param name="dstEnd">dstEnd</param>
        [JsonConstructor]
        public ModelTimeZone(Option<string?> name = default, Option<int?> offset = default, Option<int?> offsetWithDst = default, Option<string?> currentTime = default, Option<decimal?> currentTimeUnix = default, Option<bool?> isDst = default, Option<int?> dstSavings = default, Option<bool?> dstExists = default, Option<TimeZoneDstStart?> dstStart = default, Option<TimeZoneDstEnd?> dstEnd = default)
        {
            NameOption = name;
            OffsetOption = offset;
            OffsetWithDstOption = offsetWithDst;
            CurrentTimeOption = currentTime;
            CurrentTimeUnixOption = currentTimeUnix;
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
        /// Used to track the state of CurrentTime
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CurrentTimeOption { get; private set; }

        /// <summary>
        /// Gets or Sets CurrentTime
        /// </summary>
        /* <example>2025-04-22 06:19:40.951-0700</example> */
        [JsonPropertyName("current_time")]
        public string? CurrentTime { get { return this.CurrentTimeOption; } set { this.CurrentTimeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of CurrentTimeUnix
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> CurrentTimeUnixOption { get; private set; }

        /// <summary>
        /// Gets or Sets CurrentTimeUnix
        /// </summary>
        /* <example>1745327980.951</example> */
        [JsonPropertyName("current_time_unix")]
        public decimal? CurrentTimeUnix { get { return this.CurrentTimeUnixOption; } set { this.CurrentTimeUnixOption = new Option<decimal?>(value); } }

        /// <summary>
        /// Used to track the state of IsDst
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsDstOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsDst
        /// </summary>
        /* <example>true</example> */
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
        /* <example>1</example> */
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
        /* <example>true</example> */
        [JsonPropertyName("dst_exists")]
        public bool? DstExists { get { return this.DstExistsOption; } set { this.DstExistsOption = new Option<bool?>(value); } }

        /// <summary>
        /// Used to track the state of DstStart
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<TimeZoneDstStart?> DstStartOption { get; private set; }

        /// <summary>
        /// Gets or Sets DstStart
        /// </summary>
        [JsonPropertyName("dst_start")]
        public TimeZoneDstStart? DstStart { get { return this.DstStartOption; } set { this.DstStartOption = new Option<TimeZoneDstStart?>(value); } }

        /// <summary>
        /// Used to track the state of DstEnd
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<TimeZoneDstEnd?> DstEndOption { get; private set; }

        /// <summary>
        /// Gets or Sets DstEnd
        /// </summary>
        [JsonPropertyName("dst_end")]
        public TimeZoneDstEnd? DstEnd { get { return this.DstEndOption; } set { this.DstEndOption = new Option<TimeZoneDstEnd?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModelTimeZone {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  OffsetWithDst: ").Append(OffsetWithDst).Append("\n");
            sb.Append("  CurrentTime: ").Append(CurrentTime).Append("\n");
            sb.Append("  CurrentTimeUnix: ").Append(CurrentTimeUnix).Append("\n");
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
    /// A Json converter for type <see cref="ModelTimeZone" />
    /// </summary>
    public class ModelTimeZoneJsonConverter : JsonConverter<ModelTimeZone>
    {
        /// <summary>
        /// Deserializes json to <see cref="ModelTimeZone" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ModelTimeZone Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> name = default;
            Option<int?> offset = default;
            Option<int?> offsetWithDst = default;
            Option<string?> currentTime = default;
            Option<decimal?> currentTimeUnix = default;
            Option<bool?> isDst = default;
            Option<int?> dstSavings = default;
            Option<bool?> dstExists = default;
            Option<TimeZoneDstStart?> dstStart = default;
            Option<TimeZoneDstEnd?> dstEnd = default;

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
                        case "current_time":
                            currentTime = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "current_time_unix":
                            currentTimeUnix = new Option<decimal?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (decimal?)null : utf8JsonReader.GetDecimal());
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
                            dstStart = new Option<TimeZoneDstStart?>(JsonSerializer.Deserialize<TimeZoneDstStart>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "dst_end":
                            dstEnd = new Option<TimeZoneDstEnd?>(JsonSerializer.Deserialize<TimeZoneDstEnd>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class ModelTimeZone.");

            if (offset.IsSet && offset.Value == null)
                throw new ArgumentNullException(nameof(offset), "Property is not nullable for class ModelTimeZone.");

            if (offsetWithDst.IsSet && offsetWithDst.Value == null)
                throw new ArgumentNullException(nameof(offsetWithDst), "Property is not nullable for class ModelTimeZone.");

            if (currentTime.IsSet && currentTime.Value == null)
                throw new ArgumentNullException(nameof(currentTime), "Property is not nullable for class ModelTimeZone.");

            if (currentTimeUnix.IsSet && currentTimeUnix.Value == null)
                throw new ArgumentNullException(nameof(currentTimeUnix), "Property is not nullable for class ModelTimeZone.");

            if (isDst.IsSet && isDst.Value == null)
                throw new ArgumentNullException(nameof(isDst), "Property is not nullable for class ModelTimeZone.");

            if (dstSavings.IsSet && dstSavings.Value == null)
                throw new ArgumentNullException(nameof(dstSavings), "Property is not nullable for class ModelTimeZone.");

            if (dstExists.IsSet && dstExists.Value == null)
                throw new ArgumentNullException(nameof(dstExists), "Property is not nullable for class ModelTimeZone.");

            if (dstStart.IsSet && dstStart.Value == null)
                throw new ArgumentNullException(nameof(dstStart), "Property is not nullable for class ModelTimeZone.");

            if (dstEnd.IsSet && dstEnd.Value == null)
                throw new ArgumentNullException(nameof(dstEnd), "Property is not nullable for class ModelTimeZone.");

            return new ModelTimeZone(name, offset, offsetWithDst, currentTime, currentTimeUnix, isDst, dstSavings, dstExists, dstStart, dstEnd);
        }

        /// <summary>
        /// Serializes a <see cref="ModelTimeZone" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="modelTimeZone"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ModelTimeZone modelTimeZone, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, modelTimeZone, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ModelTimeZone" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="modelTimeZone"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ModelTimeZone modelTimeZone, JsonSerializerOptions jsonSerializerOptions)
        {
            if (modelTimeZone.NameOption.IsSet && modelTimeZone.Name == null)
                throw new ArgumentNullException(nameof(modelTimeZone.Name), "Property is required for class ModelTimeZone.");

            if (modelTimeZone.CurrentTimeOption.IsSet && modelTimeZone.CurrentTime == null)
                throw new ArgumentNullException(nameof(modelTimeZone.CurrentTime), "Property is required for class ModelTimeZone.");

            if (modelTimeZone.DstStartOption.IsSet && modelTimeZone.DstStart == null)
                throw new ArgumentNullException(nameof(modelTimeZone.DstStart), "Property is required for class ModelTimeZone.");

            if (modelTimeZone.DstEndOption.IsSet && modelTimeZone.DstEnd == null)
                throw new ArgumentNullException(nameof(modelTimeZone.DstEnd), "Property is required for class ModelTimeZone.");

            if (modelTimeZone.NameOption.IsSet)
                writer.WriteString("name", modelTimeZone.Name);

            if (modelTimeZone.OffsetOption.IsSet)
                writer.WriteNumber("offset", modelTimeZone.OffsetOption.Value!.Value);

            if (modelTimeZone.OffsetWithDstOption.IsSet)
                writer.WriteNumber("offset_with_dst", modelTimeZone.OffsetWithDstOption.Value!.Value);

            if (modelTimeZone.CurrentTimeOption.IsSet)
                writer.WriteString("current_time", modelTimeZone.CurrentTime);

            if (modelTimeZone.CurrentTimeUnixOption.IsSet)
                writer.WriteNumber("current_time_unix", modelTimeZone.CurrentTimeUnixOption.Value!.Value);

            if (modelTimeZone.IsDstOption.IsSet)
                writer.WriteBoolean("is_dst", modelTimeZone.IsDstOption.Value!.Value);

            if (modelTimeZone.DstSavingsOption.IsSet)
                writer.WriteNumber("dst_savings", modelTimeZone.DstSavingsOption.Value!.Value);

            if (modelTimeZone.DstExistsOption.IsSet)
                writer.WriteBoolean("dst_exists", modelTimeZone.DstExistsOption.Value!.Value);

            if (modelTimeZone.DstStartOption.IsSet)
            {
                writer.WritePropertyName("dst_start");
                JsonSerializer.Serialize(writer, modelTimeZone.DstStart, jsonSerializerOptions);
            }
            if (modelTimeZone.DstEndOption.IsSet)
            {
                writer.WritePropertyName("dst_end");
                JsonSerializer.Serialize(writer, modelTimeZone.DstEnd, jsonSerializerOptions);
            }
        }
    }
}
