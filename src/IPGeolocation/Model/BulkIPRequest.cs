

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
    /// BulkIPRequest
    /// </summary>
    public partial class BulkIPRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkIPRequest" /> class.
        /// </summary>
        /// <param name="ips">ips</param>
        [JsonConstructor]
        public BulkIPRequest(Option<List<string>?> ips = default)
        {
            IpsOption = ips;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Ips
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> IpsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Ips
        /// </summary>
        /* <example>[&quot;2.2.2.2&quot;,&quot;3.3.3.3&quot;]</example> */
        [JsonPropertyName("ips")]
        public List<string>? Ips { get { return this.IpsOption; } set { this.IpsOption = new Option<List<string>?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BulkIPRequest {\n");
            sb.Append("  Ips: ").Append(Ips).Append("\n");
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
    /// A Json converter for type <see cref="BulkIPRequest" />
    /// </summary>
    public class BulkIPRequestJsonConverter : JsonConverter<BulkIPRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="BulkIPRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override BulkIPRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<string>?> ips = default;

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
                        case "ips":
                            ips = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (ips.IsSet && ips.Value == null)
                throw new ArgumentNullException(nameof(ips), "Property is not nullable for class BulkIPRequest.");

            return new BulkIPRequest(ips);
        }

        /// <summary>
        /// Serializes a <see cref="BulkIPRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="bulkIPRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, BulkIPRequest bulkIPRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, bulkIPRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="BulkIPRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="bulkIPRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, BulkIPRequest bulkIPRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (bulkIPRequest.IpsOption.IsSet && bulkIPRequest.Ips == null)
                throw new ArgumentNullException(nameof(bulkIPRequest.Ips), "Property is required for class BulkIPRequest.");

            if (bulkIPRequest.IpsOption.IsSet)
            {
                writer.WritePropertyName("ips");
                JsonSerializer.Serialize(writer, bulkIPRequest.Ips, jsonSerializerOptions);
            }
        }
    }
}
