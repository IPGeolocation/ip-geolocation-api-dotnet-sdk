

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
    /// UserAgentDataDevice
    /// </summary>
    public partial class UserAgentDataDevice : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAgentDataDevice" /> class.
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="type">type</param>
        /// <param name="brand">brand</param>
        /// <param name="cpu">cpu</param>
        [JsonConstructor]
        public UserAgentDataDevice(Option<string?> name = default, Option<string?> type = default, Option<string?> brand = default, Option<string?> cpu = default)
        {
            NameOption = name;
            TypeOption = type;
            BrandOption = brand;
            CpuOption = cpu;
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
        [JsonPropertyName("type")]
        public string? Type { get { return this.TypeOption; } set { this.TypeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Brand
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> BrandOption { get; private set; }

        /// <summary>
        /// Gets or Sets Brand
        /// </summary>
        [JsonPropertyName("brand")]
        public string? Brand { get { return this.BrandOption; } set { this.BrandOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Cpu
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CpuOption { get; private set; }

        /// <summary>
        /// Gets or Sets Cpu
        /// </summary>
        [JsonPropertyName("cpu")]
        public string? Cpu { get { return this.CpuOption; } set { this.CpuOption = new Option<string?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserAgentDataDevice {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  Cpu: ").Append(Cpu).Append("\n");
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
    /// A Json converter for type <see cref="UserAgentDataDevice" />
    /// </summary>
    public class UserAgentDataDeviceJsonConverter : JsonConverter<UserAgentDataDevice>
    {
        /// <summary>
        /// Deserializes json to <see cref="UserAgentDataDevice" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UserAgentDataDevice Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> name = default;
            Option<string?> type = default;
            Option<string?> brand = default;
            Option<string?> cpu = default;

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
                        case "brand":
                            brand = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "cpu":
                            cpu = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class UserAgentDataDevice.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class UserAgentDataDevice.");

            if (brand.IsSet && brand.Value == null)
                throw new ArgumentNullException(nameof(brand), "Property is not nullable for class UserAgentDataDevice.");

            if (cpu.IsSet && cpu.Value == null)
                throw new ArgumentNullException(nameof(cpu), "Property is not nullable for class UserAgentDataDevice.");

            return new UserAgentDataDevice(name, type, brand, cpu);
        }

        /// <summary>
        /// Serializes a <see cref="UserAgentDataDevice" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userAgentDataDevice"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UserAgentDataDevice userAgentDataDevice, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, userAgentDataDevice, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UserAgentDataDevice" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userAgentDataDevice"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UserAgentDataDevice userAgentDataDevice, JsonSerializerOptions jsonSerializerOptions)
        {
            if (userAgentDataDevice.NameOption.IsSet && userAgentDataDevice.Name == null)
                throw new ArgumentNullException(nameof(userAgentDataDevice.Name), "Property is required for class UserAgentDataDevice.");

            if (userAgentDataDevice.TypeOption.IsSet && userAgentDataDevice.Type == null)
                throw new ArgumentNullException(nameof(userAgentDataDevice.Type), "Property is required for class UserAgentDataDevice.");

            if (userAgentDataDevice.BrandOption.IsSet && userAgentDataDevice.Brand == null)
                throw new ArgumentNullException(nameof(userAgentDataDevice.Brand), "Property is required for class UserAgentDataDevice.");

            if (userAgentDataDevice.CpuOption.IsSet && userAgentDataDevice.Cpu == null)
                throw new ArgumentNullException(nameof(userAgentDataDevice.Cpu), "Property is required for class UserAgentDataDevice.");

            if (userAgentDataDevice.NameOption.IsSet)
                writer.WriteString("name", userAgentDataDevice.Name);

            if (userAgentDataDevice.TypeOption.IsSet)
                writer.WriteString("type", userAgentDataDevice.Type);

            if (userAgentDataDevice.BrandOption.IsSet)
                writer.WriteString("brand", userAgentDataDevice.Brand);

            if (userAgentDataDevice.CpuOption.IsSet)
                writer.WriteString("cpu", userAgentDataDevice.Cpu);
        }
    }
}
