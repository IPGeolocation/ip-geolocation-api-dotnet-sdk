

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
    /// BulkUserAgentRequest
    /// </summary>
    public partial class BulkUserAgentRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUserAgentRequest" /> class.
        /// </summary>
        /// <param name="uaStrings">uaStrings</param>
        [JsonConstructor]
        public BulkUserAgentRequest(Option<List<string>?> uaStrings = default)
        {
            UaStringsOption = uaStrings;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of UaStrings
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> UaStringsOption { get; private set; }

        /// <summary>
        /// Gets or Sets UaStrings
        /// </summary>
        /* <example>[&quot;Mozilla/5.0 (Linux; Android 8.0.0; SM-G960F Build/R16NW) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.84 Mobile Safari/537.36&quot;,&quot;Mozilla/5.0 (X11; U; Linux armv7l like Android; en-us) AppleWebKit/531.2+ (KHTML, like Gecko) Version/5.0 Safari/533.2+ Kindle/3.0+&quot;,&quot;Mozilla/5.0 (Linux; U; en-US) AppleWebKit/528.5+ (KHTML, like Gecko, Safari/528.5+) Version/4.0 Kindle/3.0 (screen 600x800; rotate)&quot;]</example> */
        [JsonPropertyName("uaStrings")]
        public List<string>? UaStrings { get { return this.UaStringsOption; } set { this.UaStringsOption = new Option<List<string>?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BulkUserAgentRequest {\n");
            sb.Append("  UaStrings: ").Append(UaStrings).Append("\n");
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
    /// A Json converter for type <see cref="BulkUserAgentRequest" />
    /// </summary>
    public class BulkUserAgentRequestJsonConverter : JsonConverter<BulkUserAgentRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="BulkUserAgentRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override BulkUserAgentRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<string>?> uaStrings = default;

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
                        case "uaStrings":
                            uaStrings = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (uaStrings.IsSet && uaStrings.Value == null)
                throw new ArgumentNullException(nameof(uaStrings), "Property is not nullable for class BulkUserAgentRequest.");

            return new BulkUserAgentRequest(uaStrings);
        }

        /// <summary>
        /// Serializes a <see cref="BulkUserAgentRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="bulkUserAgentRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, BulkUserAgentRequest bulkUserAgentRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, bulkUserAgentRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="BulkUserAgentRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="bulkUserAgentRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, BulkUserAgentRequest bulkUserAgentRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (bulkUserAgentRequest.UaStringsOption.IsSet && bulkUserAgentRequest.UaStrings == null)
                throw new ArgumentNullException(nameof(bulkUserAgentRequest.UaStrings), "Property is required for class BulkUserAgentRequest.");

            if (bulkUserAgentRequest.UaStringsOption.IsSet)
            {
                writer.WritePropertyName("uaStrings");
                JsonSerializer.Serialize(writer, bulkUserAgentRequest.UaStrings, jsonSerializerOptions);
            }
        }
    }
}
