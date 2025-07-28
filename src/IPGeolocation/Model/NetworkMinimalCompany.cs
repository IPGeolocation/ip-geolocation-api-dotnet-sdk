

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
    /// NetworkMinimalCompany
    /// </summary>
    public partial class NetworkMinimalCompany : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkMinimalCompany" /> class.
        /// </summary>
        /// <param name="name">name</param>
        [JsonConstructor]
        public NetworkMinimalCompany(Option<string?> name = default)
        {
            NameOption = name;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NetworkMinimalCompany {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
    /// A Json converter for type <see cref="NetworkMinimalCompany" />
    /// </summary>
    public class NetworkMinimalCompanyJsonConverter : JsonConverter<NetworkMinimalCompany>
    {
        /// <summary>
        /// Deserializes json to <see cref="NetworkMinimalCompany" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override NetworkMinimalCompany Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> name = default;

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
                        default:
                            break;
                    }
                }
            }

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class NetworkMinimalCompany.");

            return new NetworkMinimalCompany(name);
        }

        /// <summary>
        /// Serializes a <see cref="NetworkMinimalCompany" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="networkMinimalCompany"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, NetworkMinimalCompany networkMinimalCompany, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, networkMinimalCompany, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="NetworkMinimalCompany" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="networkMinimalCompany"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, NetworkMinimalCompany networkMinimalCompany, JsonSerializerOptions jsonSerializerOptions)
        {
            if (networkMinimalCompany.NameOption.IsSet && networkMinimalCompany.Name == null)
                throw new ArgumentNullException(nameof(networkMinimalCompany.Name), "Property is required for class NetworkMinimalCompany.");

            if (networkMinimalCompany.NameOption.IsSet)
                writer.WriteString("name", networkMinimalCompany.Name);
        }
    }
}
