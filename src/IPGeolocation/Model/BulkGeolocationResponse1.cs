

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
    /// BulkGeolocationResponse1
    /// </summary>
    public partial class BulkGeolocationResponse1 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkGeolocationResponse1" /> class.
        /// </summary>
        /// <param name="geolocationXMLResponseArray"></param>
        /// <param name="varTimeZone">varTimeZone</param>
        public BulkGeolocationResponse1(GeolocationXMLResponseArray geolocationXMLResponseArray, Option<ModelTimeZone?> varTimeZone = default)
        {
            GeolocationXMLResponseArray = geolocationXMLResponseArray;
            VarTimeZoneOption = varTimeZone;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkGeolocationResponse1" /> class.
        /// </summary>
        /// <param name="errorXMLResponseArray"></param>
        /// <param name="varTimeZone">varTimeZone</param>
        public BulkGeolocationResponse1(ErrorXMLResponseArray errorXMLResponseArray, Option<ModelTimeZone?> varTimeZone = default)
        {
            ErrorXMLResponseArray = errorXMLResponseArray;
            VarTimeZoneOption = varTimeZone;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets GeolocationXMLResponseArray
        /// </summary>
        public GeolocationXMLResponseArray? GeolocationXMLResponseArray { get; set; }

        /// <summary>
        /// Gets or Sets ErrorXMLResponseArray
        /// </summary>
        public ErrorXMLResponseArray? ErrorXMLResponseArray { get; set; }

        /// <summary>
        /// Used to track the state of VarTimeZone
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<ModelTimeZone?> VarTimeZoneOption { get; private set; }

        /// <summary>
        /// Gets or Sets VarTimeZone
        /// </summary>
        [JsonPropertyName("time_zone")]
        public ModelTimeZone? VarTimeZone { get { return this.VarTimeZoneOption; } set { this.VarTimeZoneOption = new Option<ModelTimeZone?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BulkGeolocationResponse1 {\n");
            sb.Append("  VarTimeZone: ").Append(VarTimeZone).Append("\n");
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
    /// A Json converter for type <see cref="BulkGeolocationResponse1" />
    /// </summary>
    public class BulkGeolocationResponse1JsonConverter : JsonConverter<BulkGeolocationResponse1>
    {
        /// <summary>
        /// Deserializes json to <see cref="BulkGeolocationResponse1" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override BulkGeolocationResponse1 Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<ModelTimeZone?> varTimeZone = default;

            GeolocationXMLResponseArray? geolocationXMLResponseArray = default;
            ErrorXMLResponseArray? errorXMLResponseArray = default;

            Utf8JsonReader utf8JsonReaderOneOf = utf8JsonReader;
            while (utf8JsonReaderOneOf.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReaderOneOf.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReaderOneOf.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReaderOneOf.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReaderOneOf.CurrentDepth)
                    break;

                if (utf8JsonReaderOneOf.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReaderOneOf.CurrentDepth - 1)
                {
                    Utf8JsonReader utf8JsonReaderGeolocationXMLResponseArray = utf8JsonReader;
                    ClientUtils.TryDeserialize<GeolocationXMLResponseArray?>(ref utf8JsonReaderGeolocationXMLResponseArray, jsonSerializerOptions, out geolocationXMLResponseArray);

                    Utf8JsonReader utf8JsonReaderErrorXMLResponseArray = utf8JsonReader;
                    ClientUtils.TryDeserialize<ErrorXMLResponseArray?>(ref utf8JsonReaderErrorXMLResponseArray, jsonSerializerOptions, out errorXMLResponseArray);
                }
            }

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
                        case "time_zone":
                            varTimeZone = new Option<ModelTimeZone?>(JsonSerializer.Deserialize<ModelTimeZone>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (varTimeZone.IsSet && varTimeZone.Value == null)
                throw new ArgumentNullException(nameof(varTimeZone), "Property is not nullable for class BulkGeolocationResponse1.");

            if (geolocationXMLResponseArray != null)
                return new BulkGeolocationResponse1(geolocationXMLResponseArray, varTimeZone);

            if (errorXMLResponseArray != null)
                return new BulkGeolocationResponse1(errorXMLResponseArray, varTimeZone);

            throw new JsonException();
        }

        /// <summary>
        /// Serializes a <see cref="BulkGeolocationResponse1" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="bulkGeolocationResponse1"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, BulkGeolocationResponse1 bulkGeolocationResponse1, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, bulkGeolocationResponse1, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="BulkGeolocationResponse1" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="bulkGeolocationResponse1"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, BulkGeolocationResponse1 bulkGeolocationResponse1, JsonSerializerOptions jsonSerializerOptions)
        {
            if (bulkGeolocationResponse1.VarTimeZoneOption.IsSet && bulkGeolocationResponse1.VarTimeZone == null)
                throw new ArgumentNullException(nameof(bulkGeolocationResponse1.VarTimeZone), "Property is required for class BulkGeolocationResponse1.");

            if (bulkGeolocationResponse1.VarTimeZoneOption.IsSet)
            {
                writer.WritePropertyName("time_zone");
                JsonSerializer.Serialize(writer, bulkGeolocationResponse1.VarTimeZone, jsonSerializerOptions);
            }
        }
    }
}
