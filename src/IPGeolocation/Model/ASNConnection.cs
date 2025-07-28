

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
    /// ASNConnection
    /// </summary>
    public partial class ASNConnection : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ASNConnection" /> class.
        /// </summary>
        /// <param name="asNumber">asNumber</param>
        /// <param name="description">description</param>
        /// <param name="country">country</param>
        [JsonConstructor]
        public ASNConnection(Option<string?> asNumber = default, Option<string?> description = default, Option<string?> country = default)
        {
            AsNumberOption = asNumber;
            DescriptionOption = description;
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
        /* <example>AS12779</example> */
        [JsonPropertyName("as_number")]
        public string? AsNumber { get { return this.AsNumberOption; } set { this.AsNumberOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Description
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DescriptionOption { get; private set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        /* <example>IT.Gate S.p.A.</example> */
        [JsonPropertyName("description")]
        public string? Description { get { return this.DescriptionOption; } set { this.DescriptionOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Country
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CountryOption { get; private set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        /* <example>IT</example> */
        [JsonPropertyName("country")]
        public string? Country { get { return this.CountryOption; } set { this.CountryOption = new Option<string?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ASNConnection {\n");
            sb.Append("  AsNumber: ").Append(AsNumber).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
    /// A Json converter for type <see cref="ASNConnection" />
    /// </summary>
    public class ASNConnectionJsonConverter : JsonConverter<ASNConnection>
    {
        /// <summary>
        /// Deserializes json to <see cref="ASNConnection" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ASNConnection Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> asNumber = default;
            Option<string?> description = default;
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
                        case "description":
                            description = new Option<string?>(utf8JsonReader.GetString()!);
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
                throw new ArgumentNullException(nameof(asNumber), "Property is not nullable for class ASNConnection.");

            if (description.IsSet && description.Value == null)
                throw new ArgumentNullException(nameof(description), "Property is not nullable for class ASNConnection.");

            if (country.IsSet && country.Value == null)
                throw new ArgumentNullException(nameof(country), "Property is not nullable for class ASNConnection.");

            return new ASNConnection(asNumber, description, country);
        }

        /// <summary>
        /// Serializes a <see cref="ASNConnection" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="aSNConnection"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ASNConnection aSNConnection, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, aSNConnection, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ASNConnection" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="aSNConnection"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ASNConnection aSNConnection, JsonSerializerOptions jsonSerializerOptions)
        {
            if (aSNConnection.AsNumberOption.IsSet && aSNConnection.AsNumber == null)
                throw new ArgumentNullException(nameof(aSNConnection.AsNumber), "Property is required for class ASNConnection.");

            if (aSNConnection.DescriptionOption.IsSet && aSNConnection.Description == null)
                throw new ArgumentNullException(nameof(aSNConnection.Description), "Property is required for class ASNConnection.");

            if (aSNConnection.CountryOption.IsSet && aSNConnection.Country == null)
                throw new ArgumentNullException(nameof(aSNConnection.Country), "Property is required for class ASNConnection.");

            if (aSNConnection.AsNumberOption.IsSet)
                writer.WriteString("as_number", aSNConnection.AsNumber);

            if (aSNConnection.DescriptionOption.IsSet)
                writer.WriteString("description", aSNConnection.Description);

            if (aSNConnection.CountryOption.IsSet)
                writer.WriteString("country", aSNConnection.Country);
        }
    }
}
