

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
    /// NetworkCompany
    /// </summary>
    public partial class NetworkCompany : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkCompany" /> class.
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="type">type</param>
        /// <param name="domain">domain</param>
        [JsonConstructor]
        public NetworkCompany(Option<string?> name = default, Option<string?> type = default, Option<string?> domain = default)
        {
            NameOption = name;
            TypeOption = type;
            DomainOption = domain;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NameOption { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /* <example>Google LLC</example> */
        [JsonPropertyName("name")]
        public string? Name { get { return this.NameOption; } set { this.NameOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Type
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /* <example>hosting</example> */
        [JsonPropertyName("type")]
        public string? Type { get { return this.TypeOption; } set { this.TypeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Domain
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DomainOption { get; private set; }

        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        /* <example>google.com</example> */
        [JsonPropertyName("domain")]
        public string? Domain { get { return this.DomainOption; } set { this.DomainOption = new Option<string?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NetworkCompany {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
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
    /// A Json converter for type <see cref="NetworkCompany" />
    /// </summary>
    public class NetworkCompanyJsonConverter : JsonConverter<NetworkCompany>
    {
        /// <summary>
        /// Deserializes json to <see cref="NetworkCompany" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override NetworkCompany Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> name = default;
            Option<string?> type = default;
            Option<string?> domain = default;

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
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "type":
                            type = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "domain":
                            domain = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class NetworkCompany.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class NetworkCompany.");

            if (domain.IsSet && domain.Value == null)
                throw new ArgumentNullException(nameof(domain), "Property is not nullable for class NetworkCompany.");

            return new NetworkCompany(name, type, domain);
        }

        /// <summary>
        /// Serializes a <see cref="NetworkCompany" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="networkCompany"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, NetworkCompany networkCompany, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, networkCompany, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="NetworkCompany" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="networkCompany"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, NetworkCompany networkCompany, JsonSerializerOptions jsonSerializerOptions)
        {
            if (networkCompany.NameOption.IsSet && networkCompany.Name == null)
                throw new ArgumentNullException(nameof(networkCompany.Name), "Property is required for class NetworkCompany.");

            if (networkCompany.TypeOption.IsSet && networkCompany.Type == null)
                throw new ArgumentNullException(nameof(networkCompany.Type), "Property is required for class NetworkCompany.");

            if (networkCompany.DomainOption.IsSet && networkCompany.Domain == null)
                throw new ArgumentNullException(nameof(networkCompany.Domain), "Property is required for class NetworkCompany.");

            if (networkCompany.NameOption.IsSet)
                writer.WriteString("name", networkCompany.Name);

            if (networkCompany.TypeOption.IsSet)
                writer.WriteString("type", networkCompany.Type);

            if (networkCompany.DomainOption.IsSet)
                writer.WriteString("domain", networkCompany.Domain);
        }
    }
}
