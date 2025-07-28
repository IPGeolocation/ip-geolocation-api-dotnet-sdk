

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
    /// AbuseResponse
    /// </summary>
    public partial class AbuseResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbuseResponse" /> class.
        /// </summary>
        /// <param name="ip">ip</param>
        /// <param name="abuse">abuse</param>
        [JsonConstructor]
        public AbuseResponse(Option<string?> ip = default, Option<Abuse?> abuse = default)
        {
            IpOption = ip;
            AbuseOption = abuse;
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
        /* <example>8.8.8.8</example> */
        [JsonPropertyName("ip")]
        public string? Ip { get { return this.IpOption; } set { this.IpOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Abuse
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Abuse?> AbuseOption { get; private set; }

        /// <summary>
        /// Gets or Sets Abuse
        /// </summary>
        [JsonPropertyName("abuse")]
        public Abuse? Abuse { get { return this.AbuseOption; } set { this.AbuseOption = new Option<Abuse?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AbuseResponse {\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Abuse: ").Append(Abuse).Append("\n");
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
    /// A Json converter for type <see cref="AbuseResponse" />
    /// </summary>
    public class AbuseResponseJsonConverter : JsonConverter<AbuseResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="AbuseResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AbuseResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> ip = default;
            Option<Abuse?> abuse = default;

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
                        case "abuse":
                            abuse = new Option<Abuse?>(JsonSerializer.Deserialize<Abuse>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (ip.IsSet && ip.Value == null)
                throw new ArgumentNullException(nameof(ip), "Property is not nullable for class AbuseResponse.");

            if (abuse.IsSet && abuse.Value == null)
                throw new ArgumentNullException(nameof(abuse), "Property is not nullable for class AbuseResponse.");

            return new AbuseResponse(ip, abuse);
        }

        /// <summary>
        /// Serializes a <see cref="AbuseResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="abuseResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AbuseResponse abuseResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, abuseResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AbuseResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="abuseResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AbuseResponse abuseResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (abuseResponse.IpOption.IsSet && abuseResponse.Ip == null)
                throw new ArgumentNullException(nameof(abuseResponse.Ip), "Property is required for class AbuseResponse.");

            if (abuseResponse.AbuseOption.IsSet && abuseResponse.Abuse == null)
                throw new ArgumentNullException(nameof(abuseResponse.Abuse), "Property is required for class AbuseResponse.");

            if (abuseResponse.IpOption.IsSet)
                writer.WriteString("ip", abuseResponse.Ip);

            if (abuseResponse.AbuseOption.IsSet)
            {
                writer.WritePropertyName("abuse");
                JsonSerializer.Serialize(writer, abuseResponse.Abuse, jsonSerializerOptions);
            }
        }
    }
}
