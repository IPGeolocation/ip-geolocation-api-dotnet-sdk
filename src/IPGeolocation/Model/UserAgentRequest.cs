

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
    /// UserAgentRequest
    /// </summary>
    public partial class UserAgentRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAgentRequest" /> class.
        /// </summary>
        /// <param name="uaString">uaString</param>
        [JsonConstructor]
        public UserAgentRequest(Option<string?> uaString = default)
        {
            UaStringOption = uaString;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of UaString
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> UaStringOption { get; private set; }

        /// <summary>
        /// Gets or Sets UaString
        /// </summary>
        /* <example>Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_2) AppleWebKit/601.3.9 (KHTML, like Gecko) Version/9.0.2 Safari/601.3.9</example> */
        [JsonPropertyName("uaString")]
        public string? UaString { get { return this.UaStringOption; } set { this.UaStringOption = new Option<string?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserAgentRequest {\n");
            sb.Append("  UaString: ").Append(UaString).Append("\n");
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
    /// A Json converter for type <see cref="UserAgentRequest" />
    /// </summary>
    public class UserAgentRequestJsonConverter : JsonConverter<UserAgentRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="UserAgentRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UserAgentRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> uaString = default;

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
                        case "uaString":
                            uaString = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (uaString.IsSet && uaString.Value == null)
                throw new ArgumentNullException(nameof(uaString), "Property is not nullable for class UserAgentRequest.");

            return new UserAgentRequest(uaString);
        }

        /// <summary>
        /// Serializes a <see cref="UserAgentRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userAgentRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UserAgentRequest userAgentRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, userAgentRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UserAgentRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userAgentRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UserAgentRequest userAgentRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (userAgentRequest.UaStringOption.IsSet && userAgentRequest.UaString == null)
                throw new ArgumentNullException(nameof(userAgentRequest.UaString), "Property is required for class UserAgentRequest.");

            if (userAgentRequest.UaStringOption.IsSet)
                writer.WriteString("uaString", userAgentRequest.UaString);
        }
    }
}
