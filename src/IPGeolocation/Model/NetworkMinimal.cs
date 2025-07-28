

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
    /// NetworkMinimal
    /// </summary>
    public partial class NetworkMinimal : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkMinimal" /> class.
        /// </summary>
        /// <param name="asn">asn</param>
        /// <param name="company">company</param>
        [JsonConstructor]
        public NetworkMinimal(Option<NetworkMinimalAsn?> asn = default, Option<NetworkMinimalCompany?> company = default)
        {
            AsnOption = asn;
            CompanyOption = company;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Asn
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<NetworkMinimalAsn?> AsnOption { get; private set; }

        /// <summary>
        /// Gets or Sets Asn
        /// </summary>
        [JsonPropertyName("asn")]
        public NetworkMinimalAsn? Asn { get { return this.AsnOption; } set { this.AsnOption = new Option<NetworkMinimalAsn?>(value); } }

        /// <summary>
        /// Used to track the state of Company
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<NetworkMinimalCompany?> CompanyOption { get; private set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [JsonPropertyName("company")]
        public NetworkMinimalCompany? Company { get { return this.CompanyOption; } set { this.CompanyOption = new Option<NetworkMinimalCompany?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NetworkMinimal {\n");
            sb.Append("  Asn: ").Append(Asn).Append("\n");
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
    /// A Json converter for type <see cref="NetworkMinimal" />
    /// </summary>
    public class NetworkMinimalJsonConverter : JsonConverter<NetworkMinimal>
    {
        /// <summary>
        /// Deserializes json to <see cref="NetworkMinimal" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override NetworkMinimal Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<NetworkMinimalAsn?> asn = default;
            Option<NetworkMinimalCompany?> company = default;

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
                            asn = new Option<NetworkMinimalAsn?>(JsonSerializer.Deserialize<NetworkMinimalAsn>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "company":
                            company = new Option<NetworkMinimalCompany?>(JsonSerializer.Deserialize<NetworkMinimalCompany>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (asn.IsSet && asn.Value == null)
                throw new ArgumentNullException(nameof(asn), "Property is not nullable for class NetworkMinimal.");

            if (company.IsSet && company.Value == null)
                throw new ArgumentNullException(nameof(company), "Property is not nullable for class NetworkMinimal.");

            return new NetworkMinimal(asn, company);
        }

        /// <summary>
        /// Serializes a <see cref="NetworkMinimal" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="networkMinimal"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, NetworkMinimal networkMinimal, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, networkMinimal, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="NetworkMinimal" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="networkMinimal"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, NetworkMinimal networkMinimal, JsonSerializerOptions jsonSerializerOptions)
        {
            if (networkMinimal.AsnOption.IsSet && networkMinimal.Asn == null)
                throw new ArgumentNullException(nameof(networkMinimal.Asn), "Property is required for class NetworkMinimal.");

            if (networkMinimal.CompanyOption.IsSet && networkMinimal.Company == null)
                throw new ArgumentNullException(nameof(networkMinimal.Company), "Property is required for class NetworkMinimal.");

            if (networkMinimal.AsnOption.IsSet)
            {
                writer.WritePropertyName("asn");
                JsonSerializer.Serialize(writer, networkMinimal.Asn, jsonSerializerOptions);
            }
            if (networkMinimal.CompanyOption.IsSet)
            {
                writer.WritePropertyName("company");
                JsonSerializer.Serialize(writer, networkMinimal.Company, jsonSerializerOptions);
            }
        }
    }
}
