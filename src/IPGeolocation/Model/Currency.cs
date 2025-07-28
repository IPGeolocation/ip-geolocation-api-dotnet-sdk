

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
    /// Currency
    /// </summary>
    public partial class Currency : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Currency" /> class.
        /// </summary>
        /// <param name="code">code</param>
        /// <param name="name">name</param>
        /// <param name="symbol">symbol</param>
        [JsonConstructor]
        public Currency(Option<string?> code = default, Option<string?> name = default, Option<string?> symbol = default)
        {
            CodeOption = code;
            NameOption = name;
            SymbolOption = symbol;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Code
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CodeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        /* <example>USD</example> */
        [JsonPropertyName("code")]
        public string? Code { get { return this.CodeOption; } set { this.CodeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NameOption { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /* <example>US Dollar</example> */
        [JsonPropertyName("name")]
        public string? Name { get { return this.NameOption; } set { this.NameOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Symbol
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> SymbolOption { get; private set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        /* <example>$</example> */
        [JsonPropertyName("symbol")]
        public string? Symbol { get { return this.SymbolOption; } set { this.SymbolOption = new Option<string?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Currency {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
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
    /// A Json converter for type <see cref="Currency" />
    /// </summary>
    public class CurrencyJsonConverter : JsonConverter<Currency>
    {
        /// <summary>
        /// Deserializes json to <see cref="Currency" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Currency Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> code = default;
            Option<string?> name = default;
            Option<string?> symbol = default;

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
                        case "code":
                            code = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "symbol":
                            symbol = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (code.IsSet && code.Value == null)
                throw new ArgumentNullException(nameof(code), "Property is not nullable for class Currency.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class Currency.");

            if (symbol.IsSet && symbol.Value == null)
                throw new ArgumentNullException(nameof(symbol), "Property is not nullable for class Currency.");

            return new Currency(code, name, symbol);
        }

        /// <summary>
        /// Serializes a <see cref="Currency" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="currency"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Currency currency, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, currency, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Currency" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="currency"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Currency currency, JsonSerializerOptions jsonSerializerOptions)
        {
            if (currency.CodeOption.IsSet && currency.Code == null)
                throw new ArgumentNullException(nameof(currency.Code), "Property is required for class Currency.");

            if (currency.NameOption.IsSet && currency.Name == null)
                throw new ArgumentNullException(nameof(currency.Name), "Property is required for class Currency.");

            if (currency.SymbolOption.IsSet && currency.Symbol == null)
                throw new ArgumentNullException(nameof(currency.Symbol), "Property is required for class Currency.");

            if (currency.CodeOption.IsSet)
                writer.WriteString("code", currency.Code);

            if (currency.NameOption.IsSet)
                writer.WriteString("name", currency.Name);

            if (currency.SymbolOption.IsSet)
                writer.WriteString("symbol", currency.Symbol);
        }
    }
}
