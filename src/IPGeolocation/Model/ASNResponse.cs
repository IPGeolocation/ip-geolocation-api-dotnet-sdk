

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
    /// ASNResponse
    /// </summary>
    public partial class ASNResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ASNResponse" /> class.
        /// </summary>
        /// <param name="ip">IP address for which ASN information is returned. Present if the &#39;ip&#39; query parameter is used or no IP is specified (defaults to requester&#39;s IP).</param>
        /// <param name="asn">asn</param>
        [JsonConstructor]
        public ASNResponse(Option<string?> ip = default, Option<ASNResponseAsn?> asn = default)
        {
            IpOption = ip;
            AsnOption = asn;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Ip
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IpOption { get; private set; }

        /// <summary>
        /// IP address for which ASN information is returned. Present if the &#39;ip&#39; query parameter is used or no IP is specified (defaults to requester&#39;s IP).
        /// </summary>
        /// <value>IP address for which ASN information is returned. Present if the &#39;ip&#39; query parameter is used or no IP is specified (defaults to requester&#39;s IP).</value>
        /* <example>81.73.154.79</example> */
        [JsonPropertyName("ip")]
        public string? Ip { get { return this.IpOption; } set { this.IpOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Asn
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<ASNResponseAsn?> AsnOption { get; private set; }

        /// <summary>
        /// Gets or Sets Asn
        /// </summary>
        [JsonPropertyName("asn")]
        public ASNResponseAsn? Asn { get { return this.AsnOption; } set { this.AsnOption = new Option<ASNResponseAsn?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ASNResponse {\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Asn: ").Append(Asn).Append("\n");
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
    /// A Json converter for type <see cref="ASNResponse" />
    /// </summary>
    public class ASNResponseJsonConverter : JsonConverter<ASNResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="ASNResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ASNResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> ip = default;
            Option<ASNResponseAsn?> asn = default;

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
                        case "ip":
                            ip = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "asn":
                            asn = new Option<ASNResponseAsn?>(JsonSerializer.Deserialize<ASNResponseAsn>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (ip.IsSet && ip.Value == null)
                throw new ArgumentNullException(nameof(ip), "Property is not nullable for class ASNResponse.");

            if (asn.IsSet && asn.Value == null)
                throw new ArgumentNullException(nameof(asn), "Property is not nullable for class ASNResponse.");

            return new ASNResponse(ip, asn);
        }

        /// <summary>
        /// Serializes a <see cref="ASNResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="aSNResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ASNResponse aSNResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, aSNResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ASNResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="aSNResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ASNResponse aSNResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (aSNResponse.IpOption.IsSet && aSNResponse.Ip == null)
                throw new ArgumentNullException(nameof(aSNResponse.Ip), "Property is required for class ASNResponse.");

            if (aSNResponse.AsnOption.IsSet && aSNResponse.Asn == null)
                throw new ArgumentNullException(nameof(aSNResponse.Asn), "Property is required for class ASNResponse.");

            if (aSNResponse.IpOption.IsSet)
                writer.WriteString("ip", aSNResponse.Ip);

            if (aSNResponse.AsnOption.IsSet)
            {
                writer.WritePropertyName("asn");
                JsonSerializer.Serialize(writer, aSNResponse.Asn, jsonSerializerOptions);
            }
        }
    }
}
