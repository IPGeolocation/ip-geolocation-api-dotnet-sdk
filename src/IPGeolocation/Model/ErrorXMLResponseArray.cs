

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
    /// ErrorXMLResponseArray
    /// </summary>
    public partial class ErrorXMLResponseArray : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorXMLResponseArray" /> class.
        /// </summary>
        /// <param name="message">message</param>
        [JsonConstructor]
        public ErrorXMLResponseArray(Option<string?> message = default)
        {
            MessageOption = message;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Message
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> MessageOption { get; private set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        /* <example>The Message showing the error</example> */
        [JsonPropertyName("message")]
        public string? Message { get { return this.MessageOption; } set { this.MessageOption = new Option<string?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ErrorXMLResponseArray {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
    /// A Json converter for type <see cref="ErrorXMLResponseArray" />
    /// </summary>
    public class ErrorXMLResponseArrayJsonConverter : JsonConverter<ErrorXMLResponseArray>
    {
        /// <summary>
        /// Deserializes json to <see cref="ErrorXMLResponseArray" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ErrorXMLResponseArray Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> message = default;

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
                        case "message":
                            message = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (message.IsSet && message.Value == null)
                throw new ArgumentNullException(nameof(message), "Property is not nullable for class ErrorXMLResponseArray.");

            return new ErrorXMLResponseArray(message);
        }

        /// <summary>
        /// Serializes a <see cref="ErrorXMLResponseArray" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="errorXMLResponseArray"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ErrorXMLResponseArray errorXMLResponseArray, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, errorXMLResponseArray, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ErrorXMLResponseArray" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="errorXMLResponseArray"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ErrorXMLResponseArray errorXMLResponseArray, JsonSerializerOptions jsonSerializerOptions)
        {
            if (errorXMLResponseArray.MessageOption.IsSet && errorXMLResponseArray.Message == null)
                throw new ArgumentNullException(nameof(errorXMLResponseArray.Message), "Property is required for class ErrorXMLResponseArray.");

            if (errorXMLResponseArray.MessageOption.IsSet)
                writer.WriteString("message", errorXMLResponseArray.Message);
        }
    }
}
