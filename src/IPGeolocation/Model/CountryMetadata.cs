

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
    /// CountryMetadata
    /// </summary>
    public partial class CountryMetadata : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryMetadata" /> class.
        /// </summary>
        /// <param name="callingCode">callingCode</param>
        /// <param name="tld">tld</param>
        /// <param name="languages">languages</param>
        [JsonConstructor]
        public CountryMetadata(Option<string?> callingCode = default, Option<string?> tld = default, Option<List<string>?> languages = default)
        {
            CallingCodeOption = callingCode;
            TldOption = tld;
            LanguagesOption = languages;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of CallingCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CallingCodeOption { get; private set; }

        /// <summary>
        /// Gets or Sets CallingCode
        /// </summary>
        /* <example>+1</example> */
        [JsonPropertyName("calling_code")]
        public string? CallingCode { get { return this.CallingCodeOption; } set { this.CallingCodeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Tld
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TldOption { get; private set; }

        /// <summary>
        /// Gets or Sets Tld
        /// </summary>
        /* <example>.us</example> */
        [JsonPropertyName("tld")]
        public string? Tld { get { return this.TldOption; } set { this.TldOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Languages
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> LanguagesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        /* <example>[&quot;en-US&quot;,&quot;es-US&quot;,&quot;haw&quot;,&quot;fr&quot;]</example> */
        [JsonPropertyName("languages")]
        public List<string>? Languages { get { return this.LanguagesOption; } set { this.LanguagesOption = new Option<List<string>?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CountryMetadata {\n");
            sb.Append("  CallingCode: ").Append(CallingCode).Append("\n");
            sb.Append("  Tld: ").Append(Tld).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
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
    /// A Json converter for type <see cref="CountryMetadata" />
    /// </summary>
    public class CountryMetadataJsonConverter : JsonConverter<CountryMetadata>
    {
        /// <summary>
        /// Deserializes json to <see cref="CountryMetadata" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CountryMetadata Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> callingCode = default;
            Option<string?> tld = default;
            Option<List<string>?> languages = default;

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
                        case "calling_code":
                            callingCode = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "tld":
                            tld = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "languages":
                            languages = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (callingCode.IsSet && callingCode.Value == null)
                throw new ArgumentNullException(nameof(callingCode), "Property is not nullable for class CountryMetadata.");

            if (tld.IsSet && tld.Value == null)
                throw new ArgumentNullException(nameof(tld), "Property is not nullable for class CountryMetadata.");

            if (languages.IsSet && languages.Value == null)
                throw new ArgumentNullException(nameof(languages), "Property is not nullable for class CountryMetadata.");

            return new CountryMetadata(callingCode, tld, languages);
        }

        /// <summary>
        /// Serializes a <see cref="CountryMetadata" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="countryMetadata"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CountryMetadata countryMetadata, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, countryMetadata, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CountryMetadata" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="countryMetadata"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, CountryMetadata countryMetadata, JsonSerializerOptions jsonSerializerOptions)
        {
            if (countryMetadata.CallingCodeOption.IsSet && countryMetadata.CallingCode == null)
                throw new ArgumentNullException(nameof(countryMetadata.CallingCode), "Property is required for class CountryMetadata.");

            if (countryMetadata.TldOption.IsSet && countryMetadata.Tld == null)
                throw new ArgumentNullException(nameof(countryMetadata.Tld), "Property is required for class CountryMetadata.");

            if (countryMetadata.LanguagesOption.IsSet && countryMetadata.Languages == null)
                throw new ArgumentNullException(nameof(countryMetadata.Languages), "Property is required for class CountryMetadata.");

            if (countryMetadata.CallingCodeOption.IsSet)
                writer.WriteString("calling_code", countryMetadata.CallingCode);

            if (countryMetadata.TldOption.IsSet)
                writer.WriteString("tld", countryMetadata.Tld);

            if (countryMetadata.LanguagesOption.IsSet)
            {
                writer.WritePropertyName("languages");
                JsonSerializer.Serialize(writer, countryMetadata.Languages, jsonSerializerOptions);
            }
        }
    }
}
