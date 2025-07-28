

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
    /// UserAgentData
    /// </summary>
    public partial class UserAgentData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAgentData" /> class.
        /// </summary>
        /// <param name="userAgentString">userAgentString</param>
        /// <param name="name">name</param>
        /// <param name="type">type</param>
        /// <param name="varVersion">varVersion</param>
        /// <param name="versionMajor">versionMajor</param>
        /// <param name="device">device</param>
        /// <param name="engine">engine</param>
        /// <param name="varOperatingSystem">varOperatingSystem</param>
        [JsonConstructor]
        public UserAgentData(Option<string?> userAgentString = default, Option<string?> name = default, Option<string?> type = default, Option<string?> varVersion = default, Option<string?> versionMajor = default, Option<UserAgentDataDevice?> device = default, Option<UserAgentDataEngine?> engine = default, Option<UserAgentDataOperatingSystem?> varOperatingSystem = default)
        {
            UserAgentStringOption = userAgentString;
            NameOption = name;
            TypeOption = type;
            VarVersionOption = varVersion;
            VersionMajorOption = versionMajor;
            DeviceOption = device;
            EngineOption = engine;
            VarOperatingSystemOption = varOperatingSystem;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of UserAgentString
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> UserAgentStringOption { get; private set; }

        /// <summary>
        /// Gets or Sets UserAgentString
        /// </summary>
        [JsonPropertyName("user_agent_string")]
        public string? UserAgentString { get { return this.UserAgentStringOption; } set { this.UserAgentStringOption = new Option<string?>(value); } }

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
        /// Used to track the state of VarVersion
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> VarVersionOption { get; private set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [JsonPropertyName("version")]
        public string? VarVersion { get { return this.VarVersionOption; } set { this.VarVersionOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of VersionMajor
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> VersionMajorOption { get; private set; }

        /// <summary>
        /// Gets or Sets VersionMajor
        /// </summary>
        [JsonPropertyName("version_major")]
        public string? VersionMajor { get { return this.VersionMajorOption; } set { this.VersionMajorOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Device
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<UserAgentDataDevice?> DeviceOption { get; private set; }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [JsonPropertyName("device")]
        public UserAgentDataDevice? Device { get { return this.DeviceOption; } set { this.DeviceOption = new Option<UserAgentDataDevice?>(value); } }

        /// <summary>
        /// Used to track the state of Engine
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<UserAgentDataEngine?> EngineOption { get; private set; }

        /// <summary>
        /// Gets or Sets Engine
        /// </summary>
        [JsonPropertyName("engine")]
        public UserAgentDataEngine? Engine { get { return this.EngineOption; } set { this.EngineOption = new Option<UserAgentDataEngine?>(value); } }

        /// <summary>
        /// Used to track the state of VarOperatingSystem
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<UserAgentDataOperatingSystem?> VarOperatingSystemOption { get; private set; }

        /// <summary>
        /// Gets or Sets VarOperatingSystem
        /// </summary>
        [JsonPropertyName("operating_system")]
        public UserAgentDataOperatingSystem? VarOperatingSystem { get { return this.VarOperatingSystemOption; } set { this.VarOperatingSystemOption = new Option<UserAgentDataOperatingSystem?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserAgentData {\n");
            sb.Append("  UserAgentString: ").Append(UserAgentString).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  VersionMajor: ").Append(VersionMajor).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  Engine: ").Append(Engine).Append("\n");
            sb.Append("  VarOperatingSystem: ").Append(VarOperatingSystem).Append("\n");
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
    /// A Json converter for type <see cref="UserAgentData" />
    /// </summary>
    public class UserAgentDataJsonConverter : JsonConverter<UserAgentData>
    {
        /// <summary>
        /// Deserializes json to <see cref="UserAgentData" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UserAgentData Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> userAgentString = default;
            Option<string?> name = default;
            Option<string?> type = default;
            Option<string?> varVersion = default;
            Option<string?> versionMajor = default;
            Option<UserAgentDataDevice?> device = default;
            Option<UserAgentDataEngine?> engine = default;
            Option<UserAgentDataOperatingSystem?> varOperatingSystem = default;

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
                        case "user_agent_string":
                            userAgentString = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "type":
                            type = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "version":
                            varVersion = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "version_major":
                            versionMajor = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "device":
                            device = new Option<UserAgentDataDevice?>(JsonSerializer.Deserialize<UserAgentDataDevice>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "engine":
                            engine = new Option<UserAgentDataEngine?>(JsonSerializer.Deserialize<UserAgentDataEngine>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "operating_system":
                            varOperatingSystem = new Option<UserAgentDataOperatingSystem?>(JsonSerializer.Deserialize<UserAgentDataOperatingSystem>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (userAgentString.IsSet && userAgentString.Value == null)
                throw new ArgumentNullException(nameof(userAgentString), "Property is not nullable for class UserAgentData.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class UserAgentData.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class UserAgentData.");

            if (varVersion.IsSet && varVersion.Value == null)
                throw new ArgumentNullException(nameof(varVersion), "Property is not nullable for class UserAgentData.");

            if (versionMajor.IsSet && versionMajor.Value == null)
                throw new ArgumentNullException(nameof(versionMajor), "Property is not nullable for class UserAgentData.");

            if (device.IsSet && device.Value == null)
                throw new ArgumentNullException(nameof(device), "Property is not nullable for class UserAgentData.");

            if (engine.IsSet && engine.Value == null)
                throw new ArgumentNullException(nameof(engine), "Property is not nullable for class UserAgentData.");

            if (varOperatingSystem.IsSet && varOperatingSystem.Value == null)
                throw new ArgumentNullException(nameof(varOperatingSystem), "Property is not nullable for class UserAgentData.");

            return new UserAgentData(userAgentString, name, type, varVersion, versionMajor, device, engine, varOperatingSystem);
        }

        /// <summary>
        /// Serializes a <see cref="UserAgentData" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userAgentData"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UserAgentData userAgentData, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, userAgentData, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UserAgentData" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userAgentData"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UserAgentData userAgentData, JsonSerializerOptions jsonSerializerOptions)
        {
            if (userAgentData.UserAgentStringOption.IsSet && userAgentData.UserAgentString == null)
                throw new ArgumentNullException(nameof(userAgentData.UserAgentString), "Property is required for class UserAgentData.");

            if (userAgentData.NameOption.IsSet && userAgentData.Name == null)
                throw new ArgumentNullException(nameof(userAgentData.Name), "Property is required for class UserAgentData.");

            if (userAgentData.TypeOption.IsSet && userAgentData.Type == null)
                throw new ArgumentNullException(nameof(userAgentData.Type), "Property is required for class UserAgentData.");

            if (userAgentData.VarVersionOption.IsSet && userAgentData.VarVersion == null)
                throw new ArgumentNullException(nameof(userAgentData.VarVersion), "Property is required for class UserAgentData.");

            if (userAgentData.VersionMajorOption.IsSet && userAgentData.VersionMajor == null)
                throw new ArgumentNullException(nameof(userAgentData.VersionMajor), "Property is required for class UserAgentData.");

            if (userAgentData.DeviceOption.IsSet && userAgentData.Device == null)
                throw new ArgumentNullException(nameof(userAgentData.Device), "Property is required for class UserAgentData.");

            if (userAgentData.EngineOption.IsSet && userAgentData.Engine == null)
                throw new ArgumentNullException(nameof(userAgentData.Engine), "Property is required for class UserAgentData.");

            if (userAgentData.VarOperatingSystemOption.IsSet && userAgentData.VarOperatingSystem == null)
                throw new ArgumentNullException(nameof(userAgentData.VarOperatingSystem), "Property is required for class UserAgentData.");

            if (userAgentData.UserAgentStringOption.IsSet)
                writer.WriteString("user_agent_string", userAgentData.UserAgentString);

            if (userAgentData.NameOption.IsSet)
                writer.WriteString("name", userAgentData.Name);

            if (userAgentData.TypeOption.IsSet)
                writer.WriteString("type", userAgentData.Type);

            if (userAgentData.VarVersionOption.IsSet)
                writer.WriteString("version", userAgentData.VarVersion);

            if (userAgentData.VersionMajorOption.IsSet)
                writer.WriteString("version_major", userAgentData.VersionMajor);

            if (userAgentData.DeviceOption.IsSet)
            {
                writer.WritePropertyName("device");
                JsonSerializer.Serialize(writer, userAgentData.Device, jsonSerializerOptions);
            }
            if (userAgentData.EngineOption.IsSet)
            {
                writer.WritePropertyName("engine");
                JsonSerializer.Serialize(writer, userAgentData.Engine, jsonSerializerOptions);
            }
            if (userAgentData.VarOperatingSystemOption.IsSet)
            {
                writer.WritePropertyName("operating_system");
                JsonSerializer.Serialize(writer, userAgentData.VarOperatingSystem, jsonSerializerOptions);
            }
        }
    }
}
