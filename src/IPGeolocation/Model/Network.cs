

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
    /// Network
    /// </summary>
    public partial class Network : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Network" /> class.
        /// </summary>
        /// <param name="asn">asn</param>
        /// <param name="connectionType">connectionType</param>
        /// <param name="company">company</param>
        [JsonConstructor]
        public Network(Option<NetworkAsn?> asn = default, Option<string?> connectionType = default, Option<NetworkCompany?> company = default)
        {
            AsnOption = asn;
            ConnectionTypeOption = connectionType;
            CompanyOption = company;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Asn
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<NetworkAsn?> AsnOption { get; private set; }

        /// <summary>
        /// Gets or Sets Asn
        /// </summary>
        [JsonPropertyName("asn")]
        public NetworkAsn? Asn { get { return this.AsnOption; } set { this.AsnOption = new Option<NetworkAsn?>(value); } }

        /// <summary>
        /// Used to track the state of ConnectionType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ConnectionTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets ConnectionType
        /// </summary>
        /* <example>wired</example> */
        [JsonPropertyName("connection_type")]
        public string? ConnectionType { get { return this.ConnectionTypeOption; } set { this.ConnectionTypeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Company
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<NetworkCompany?> CompanyOption { get; private set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [JsonPropertyName("company")]
        public NetworkCompany? Company { get { return this.CompanyOption; } set { this.CompanyOption = new Option<NetworkCompany?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Network {\n");
            sb.Append("  Asn: ").Append(Asn).Append("\n");
            sb.Append("  ConnectionType: ").Append(ConnectionType).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
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
    /// A Json converter for type <see cref="Network" />
    /// </summary>
    public class NetworkJsonConverter : JsonConverter<Network>
    {
        /// <summary>
        /// Deserializes json to <see cref="Network" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Network Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<NetworkAsn?> asn = default;
            Option<string?> connectionType = default;
            Option<NetworkCompany?> company = default;

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
                        case "asn":
                            asn = new Option<NetworkAsn?>(JsonSerializer.Deserialize<NetworkAsn>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "connection_type":
                            connectionType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "company":
                            company = new Option<NetworkCompany?>(JsonSerializer.Deserialize<NetworkCompany>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (asn.IsSet && asn.Value == null)
                throw new ArgumentNullException(nameof(asn), "Property is not nullable for class Network.");

            if (connectionType.IsSet && connectionType.Value == null)
                throw new ArgumentNullException(nameof(connectionType), "Property is not nullable for class Network.");

            if (company.IsSet && company.Value == null)
                throw new ArgumentNullException(nameof(company), "Property is not nullable for class Network.");

            return new Network(asn, connectionType, company);
        }

        /// <summary>
        /// Serializes a <see cref="Network" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="network"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Network network, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, network, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Network" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="network"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Network network, JsonSerializerOptions jsonSerializerOptions)
        {
            if (network.AsnOption.IsSet && network.Asn == null)
                throw new ArgumentNullException(nameof(network.Asn), "Property is required for class Network.");

            if (network.ConnectionTypeOption.IsSet && network.ConnectionType == null)
                throw new ArgumentNullException(nameof(network.ConnectionType), "Property is required for class Network.");

            if (network.CompanyOption.IsSet && network.Company == null)
                throw new ArgumentNullException(nameof(network.Company), "Property is required for class Network.");

            if (network.AsnOption.IsSet)
            {
                writer.WritePropertyName("asn");
                JsonSerializer.Serialize(writer, network.Asn, jsonSerializerOptions);
            }
            if (network.ConnectionTypeOption.IsSet)
                writer.WriteString("connection_type", network.ConnectionType);

            if (network.CompanyOption.IsSet)
            {
                writer.WritePropertyName("company");
                JsonSerializer.Serialize(writer, network.Company, jsonSerializerOptions);
            }
        }
    }
}
