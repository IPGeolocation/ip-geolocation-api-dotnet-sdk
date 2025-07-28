

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
    /// NetworkMinimalAsn
    /// </summary>
    public partial class NetworkMinimalAsn : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkMinimalAsn" /> class.
        /// </summary>
        /// <param name="asNumber">asNumber</param>
        /// <param name="organization">organization</param>
        /// <param name="country">country</param>
        [JsonConstructor]
        public NetworkMinimalAsn(Option<string?> asNumber = default, Option<string?> organization = default, Option<string?> country = default)
        {
            AsNumberOption = asNumber;
            OrganizationOption = organization;
            CountryOption = country;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of AsNumber
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> AsNumberOption { get; private set; }

        /// <summary>
        /// Gets or Sets AsNumber
        /// </summary>
        /* <example>AS15169</example> */
        [JsonPropertyName("as_number")]
        public string? AsNumber { get { return this.AsNumberOption; } set { this.AsNumberOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Organization
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> OrganizationOption { get; private set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        /* <example>Google LLC</example> */
        [JsonPropertyName("organization")]
        public string? Organization { get { return this.OrganizationOption; } set { this.OrganizationOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Country
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CountryOption { get; private set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        /* <example>US</example> */
        [JsonPropertyName("country")]
        public string? Country { get { return this.CountryOption; } set { this.CountryOption = new Option<string?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NetworkMinimalAsn {\n");
            sb.Append("  AsNumber: ").Append(AsNumber).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
    /// A Json converter for type <see cref="NetworkMinimalAsn" />
    /// </summary>
    public class NetworkMinimalAsnJsonConverter : JsonConverter<NetworkMinimalAsn>
    {
        /// <summary>
        /// Deserializes json to <see cref="NetworkMinimalAsn" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override NetworkMinimalAsn Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> asNumber = default;
            Option<string?> organization = default;
            Option<string?> country = default;

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
                        case "as_number":
                            asNumber = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "organization":
                            organization = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "country":
                            country = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (asNumber.IsSet && asNumber.Value == null)
                throw new ArgumentNullException(nameof(asNumber), "Property is not nullable for class NetworkMinimalAsn.");

            if (organization.IsSet && organization.Value == null)
                throw new ArgumentNullException(nameof(organization), "Property is not nullable for class NetworkMinimalAsn.");

            if (country.IsSet && country.Value == null)
                throw new ArgumentNullException(nameof(country), "Property is not nullable for class NetworkMinimalAsn.");

            return new NetworkMinimalAsn(asNumber, organization, country);
        }

        /// <summary>
        /// Serializes a <see cref="NetworkMinimalAsn" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="networkMinimalAsn"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, NetworkMinimalAsn networkMinimalAsn, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, networkMinimalAsn, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="NetworkMinimalAsn" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="networkMinimalAsn"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, NetworkMinimalAsn networkMinimalAsn, JsonSerializerOptions jsonSerializerOptions)
        {
            if (networkMinimalAsn.AsNumberOption.IsSet && networkMinimalAsn.AsNumber == null)
                throw new ArgumentNullException(nameof(networkMinimalAsn.AsNumber), "Property is required for class NetworkMinimalAsn.");

            if (networkMinimalAsn.OrganizationOption.IsSet && networkMinimalAsn.Organization == null)
                throw new ArgumentNullException(nameof(networkMinimalAsn.Organization), "Property is required for class NetworkMinimalAsn.");

            if (networkMinimalAsn.CountryOption.IsSet && networkMinimalAsn.Country == null)
                throw new ArgumentNullException(nameof(networkMinimalAsn.Country), "Property is required for class NetworkMinimalAsn.");

            if (networkMinimalAsn.AsNumberOption.IsSet)
                writer.WriteString("as_number", networkMinimalAsn.AsNumber);

            if (networkMinimalAsn.OrganizationOption.IsSet)
                writer.WriteString("organization", networkMinimalAsn.Organization);

            if (networkMinimalAsn.CountryOption.IsSet)
                writer.WriteString("country", networkMinimalAsn.Country);
        }
    }
}
