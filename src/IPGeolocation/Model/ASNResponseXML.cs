

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
    /// ASNResponseXML
    /// </summary>
    public partial class ASNResponseXML : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ASNResponseXML" /> class.
        /// </summary>
        /// <param name="ip">ip</param>
        /// <param name="asn">asn</param>
        [JsonConstructor]
        public ASNResponseXML(Option<string?> ip = default, Option<ASNResponseXMLAsn?> asn = default)
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
        /// Gets or Sets Ip
        /// </summary>
        /* <example>81.73.154.79</example> */
        [JsonPropertyName("ip")]
        public string? Ip { get { return this.IpOption; } set { this.IpOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Asn
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<ASNResponseXMLAsn?> AsnOption { get; private set; }

        /// <summary>
        /// Gets or Sets Asn
        /// </summary>
        [JsonPropertyName("asn")]
        public ASNResponseXMLAsn? Asn { get { return this.AsnOption; } set { this.AsnOption = new Option<ASNResponseXMLAsn?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ASNResponseXML {\n");
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
    /// A Json converter for type <see cref="ASNResponseXML" />
    /// </summary>
    public class ASNResponseXMLJsonConverter : JsonConverter<ASNResponseXML>
    {
        /// <summary>
        /// Deserializes json to <see cref="ASNResponseXML" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ASNResponseXML Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> ip = default;
            Option<ASNResponseXMLAsn?> asn = default;

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
                            asn = new Option<ASNResponseXMLAsn?>(JsonSerializer.Deserialize<ASNResponseXMLAsn>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (ip.IsSet && ip.Value == null)
                throw new ArgumentNullException(nameof(ip), "Property is not nullable for class ASNResponseXML.");

            if (asn.IsSet && asn.Value == null)
                throw new ArgumentNullException(nameof(asn), "Property is not nullable for class ASNResponseXML.");

            return new ASNResponseXML(ip, asn);
        }

        /// <summary>
        /// Serializes a <see cref="ASNResponseXML" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="aSNResponseXML"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ASNResponseXML aSNResponseXML, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, aSNResponseXML, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ASNResponseXML" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="aSNResponseXML"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ASNResponseXML aSNResponseXML, JsonSerializerOptions jsonSerializerOptions)
        {
            if (aSNResponseXML.IpOption.IsSet && aSNResponseXML.Ip == null)
                throw new ArgumentNullException(nameof(aSNResponseXML.Ip), "Property is required for class ASNResponseXML.");

            if (aSNResponseXML.AsnOption.IsSet && aSNResponseXML.Asn == null)
                throw new ArgumentNullException(nameof(aSNResponseXML.Asn), "Property is required for class ASNResponseXML.");

            if (aSNResponseXML.IpOption.IsSet)
                writer.WriteString("ip", aSNResponseXML.Ip);

            if (aSNResponseXML.AsnOption.IsSet)
            {
                writer.WritePropertyName("asn");
                JsonSerializer.Serialize(writer, aSNResponseXML.Asn, jsonSerializerOptions);
            }
        }
    }
}
