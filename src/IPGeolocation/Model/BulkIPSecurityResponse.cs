

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
    /// BulkIPSecurityResponse
    /// </summary>
    public partial class BulkIPSecurityResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkIPSecurityResponse" /> class.
        /// </summary>
        /// <param name="securityAPIResponse"></param>
        public BulkIPSecurityResponse(SecurityAPIResponse securityAPIResponse)
        {
            SecurityAPIResponse = securityAPIResponse;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkIPSecurityResponse" /> class.
        /// </summary>
        /// <param name="errorResponse"></param>
        public BulkIPSecurityResponse(ErrorResponse errorResponse)
        {
            ErrorResponse = errorResponse;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets SecurityAPIResponse
        /// </summary>
        public SecurityAPIResponse? SecurityAPIResponse { get; set; }

        /// <summary>
        /// Gets or Sets ErrorResponse
        /// </summary>
        public ErrorResponse? ErrorResponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BulkIPSecurityResponse {\n");
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
    /// A Json converter for type <see cref="BulkIPSecurityResponse" />
    /// </summary>
    public class BulkIPSecurityResponseJsonConverter : JsonConverter<BulkIPSecurityResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="BulkIPSecurityResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override BulkIPSecurityResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            SecurityAPIResponse? securityAPIResponse = default;
            ErrorResponse? errorResponse = default;

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
                            Utf8JsonReader utf8JsonReaderSecurityAPIResponse = utf8JsonReader;
                            ClientUtils.TryDeserialize<SecurityAPIResponse?>(ref utf8JsonReaderSecurityAPIResponse, jsonSerializerOptions, out securityAPIResponse);
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
                        default:
                            break;
                    }
                }
            }

            if (securityAPIResponse != null)
                return new BulkIPSecurityResponse(securityAPIResponse);

            if (errorResponse != null)
                return new BulkIPSecurityResponse(errorResponse);

            throw new JsonException();
        }

        /// <summary>
        /// Serializes a <see cref="BulkIPSecurityResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="bulkIPSecurityResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, BulkIPSecurityResponse bulkIPSecurityResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, bulkIPSecurityResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="BulkIPSecurityResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="bulkIPSecurityResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, BulkIPSecurityResponse bulkIPSecurityResponse, JsonSerializerOptions jsonSerializerOptions)
        {

        }
    }
}
