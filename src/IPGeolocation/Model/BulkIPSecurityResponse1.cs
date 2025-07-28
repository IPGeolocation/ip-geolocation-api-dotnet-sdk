

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
    /// BulkIPSecurityResponse1
    /// </summary>
    public partial class BulkIPSecurityResponse1 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkIPSecurityResponse1" /> class.
        /// </summary>
        /// <param name="securityAPIXMLResponseArray"></param>
        public BulkIPSecurityResponse1(SecurityAPIXMLResponseArray securityAPIXMLResponseArray)
        {
            SecurityAPIXMLResponseArray = securityAPIXMLResponseArray;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkIPSecurityResponse1" /> class.
        /// </summary>
        /// <param name="errorXMLResponseArray"></param>
        public BulkIPSecurityResponse1(ErrorXMLResponseArray errorXMLResponseArray)
        {
            ErrorXMLResponseArray = errorXMLResponseArray;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets SecurityAPIXMLResponseArray
        /// </summary>
        public SecurityAPIXMLResponseArray? SecurityAPIXMLResponseArray { get; set; }

        /// <summary>
        /// Gets or Sets ErrorXMLResponseArray
        /// </summary>
        public ErrorXMLResponseArray? ErrorXMLResponseArray { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BulkIPSecurityResponse1 {\n");
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
    /// A Json converter for type <see cref="BulkIPSecurityResponse1" />
    /// </summary>
    public class BulkIPSecurityResponse1JsonConverter : JsonConverter<BulkIPSecurityResponse1>
    {
        /// <summary>
        /// Deserializes json to <see cref="BulkIPSecurityResponse1" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override BulkIPSecurityResponse1 Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            SecurityAPIXMLResponseArray? securityAPIXMLResponseArray = default;
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
                    Utf8JsonReader utf8JsonReaderSecurityAPIXMLResponseArray = utf8JsonReader;
                    ClientUtils.TryDeserialize<SecurityAPIXMLResponseArray?>(ref utf8JsonReaderSecurityAPIXMLResponseArray, jsonSerializerOptions, out securityAPIXMLResponseArray);

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
                        default:
                            break;
                    }
                }
            }

            if (securityAPIXMLResponseArray != null)
                return new BulkIPSecurityResponse1(securityAPIXMLResponseArray);

            if (errorXMLResponseArray != null)
                return new BulkIPSecurityResponse1(errorXMLResponseArray);

            throw new JsonException();
        }

        /// <summary>
        /// Serializes a <see cref="BulkIPSecurityResponse1" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="bulkIPSecurityResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, BulkIPSecurityResponse1 bulkIPSecurityResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, bulkIPSecurityResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="BulkIPSecurityResponse1" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="bulkIPSecurityResponse1"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, BulkIPSecurityResponse1 bulkIPSecurityResponse1, JsonSerializerOptions jsonSerializerOptions)
        {

        }
    }
}
