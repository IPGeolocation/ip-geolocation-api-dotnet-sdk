

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
    /// BulkGeolocationResponse
    /// </summary>
    public partial class BulkGeolocationResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkGeolocationResponse" /> class.
        /// </summary>
        /// <param name="errorResponse"></param>
        /// <param name="varTimeZone">varTimeZone</param>
        public BulkGeolocationResponse(ErrorResponse errorResponse, Option<ModelTimeZone?> varTimeZone = default)
        {
            ErrorResponse = errorResponse;
            VarTimeZoneOption = varTimeZone;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkGeolocationResponse" /> class.
        /// </summary>
        /// <param name="geolocationResponse"></param>
        /// <param name="varTimeZone">varTimeZone</param>
        public BulkGeolocationResponse(GeolocationResponse geolocationResponse, Option<ModelTimeZone?> varTimeZone = default)
        {
            GeolocationResponse = geolocationResponse;
            VarTimeZoneOption = varTimeZone;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets ErrorResponse
        /// </summary>
        public ErrorResponse? ErrorResponse { get; set; }

        /// <summary>
        /// Gets or Sets GeolocationResponse
        /// </summary>
        public GeolocationResponse? GeolocationResponse { get; set; }

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
            sb.Append("class BulkGeolocationResponse {\n");
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
    /// A Json converter for type <see cref="BulkGeolocationResponse" />
    /// </summary>
    public class BulkGeolocationResponseJsonConverter : JsonConverter<BulkGeolocationResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="BulkGeolocationResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override BulkGeolocationResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<ModelTimeZone?> varTimeZone = default;

            ErrorResponse? errorResponse = default;
            GeolocationResponse? geolocationResponse = default;

            Utf8JsonReader utf8JsonReaderOneOf = utf8JsonReader;
            while (utf8JsonReaderOneOf.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReaderOneOf.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReaderOneOf.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReaderOneOf.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReaderOneOf.CurrentDepth)
                    break;

                if (utf8JsonReaderOneOf.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReaderOneOf.CurrentDepth - 1)
                {
                    string? propertyName = utf8JsonReaderOneOf.GetString();

                    switch (propertyName)
                    {
                        case "message":
                            Utf8JsonReader utf8JsonReaderErrorResponse = utf8JsonReader;
                            ClientUtils.TryDeserialize<ErrorResponse?>(ref utf8JsonReaderErrorResponse, jsonSerializerOptions, out errorResponse);
                            break;
                        default:
                            Utf8JsonReader utf8JsonReaderGeolocationResponse = utf8JsonReader;
                            ClientUtils.TryDeserialize<GeolocationResponse?>(ref utf8JsonReaderGeolocationResponse, jsonSerializerOptions, out geolocationResponse);
                            break;

                    }
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
                throw new ArgumentNullException(nameof(varTimeZone), "Property is not nullable for class BulkGeolocationResponse.");

            if (errorResponse != null)
                return new BulkGeolocationResponse(errorResponse, varTimeZone);

            if (geolocationResponse != null)
                return new BulkGeolocationResponse(geolocationResponse, varTimeZone);

            throw new JsonException();
        }

        /// <summary>
        /// Serializes a <see cref="BulkGeolocationResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="bulkGeolocationResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, BulkGeolocationResponse bulkGeolocationResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, bulkGeolocationResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="BulkGeolocationResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="bulkGeolocationResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, BulkGeolocationResponse bulkGeolocationResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (bulkGeolocationResponse.VarTimeZoneOption.IsSet && bulkGeolocationResponse.VarTimeZone == null)
                throw new ArgumentNullException(nameof(bulkGeolocationResponse.VarTimeZone), "Property is required for class BulkGeolocationResponse.");

            if (bulkGeolocationResponse.VarTimeZoneOption.IsSet)
            {
                writer.WritePropertyName("time_zone");
                JsonSerializer.Serialize(writer, bulkGeolocationResponse.VarTimeZone, jsonSerializerOptions);
            }
        }
    }
}
