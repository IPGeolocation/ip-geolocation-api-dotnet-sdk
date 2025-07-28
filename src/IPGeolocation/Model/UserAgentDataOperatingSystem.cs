

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
    /// UserAgentDataOperatingSystem
    /// </summary>
    public partial class UserAgentDataOperatingSystem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAgentDataOperatingSystem" /> class.
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="type">type</param>
        /// <param name="varVersion">varVersion</param>
        /// <param name="versionMajor">versionMajor</param>
        /// <param name="build">build</param>
        [JsonConstructor]
        public UserAgentDataOperatingSystem(Option<string?> name = default, Option<string?> type = default, Option<string?> varVersion = default, Option<string?> versionMajor = default, Option<string?> build = default)
        {
            NameOption = name;
            TypeOption = type;
            VarVersionOption = varVersion;
            VersionMajorOption = versionMajor;
            BuildOption = build;
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
        /// Used to track the state of Build
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> BuildOption { get; private set; }

        /// <summary>
        /// Gets or Sets Build
        /// </summary>
        [JsonPropertyName("build")]
        public string? Build { get { return this.BuildOption; } set { this.BuildOption = new Option<string?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserAgentDataOperatingSystem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  VersionMajor: ").Append(VersionMajor).Append("\n");
            sb.Append("  Build: ").Append(Build).Append("\n");
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
    /// A Json converter for type <see cref="UserAgentDataOperatingSystem" />
    /// </summary>
    public class UserAgentDataOperatingSystemJsonConverter : JsonConverter<UserAgentDataOperatingSystem>
    {
        /// <summary>
        /// Deserializes json to <see cref="UserAgentDataOperatingSystem" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UserAgentDataOperatingSystem Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> name = default;
            Option<string?> type = default;
            Option<string?> varVersion = default;
            Option<string?> versionMajor = default;
            Option<string?> build = default;

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
                        case "version":
                            varVersion = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "version_major":
                            versionMajor = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "build":
                            build = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class UserAgentDataOperatingSystem.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class UserAgentDataOperatingSystem.");

            if (varVersion.IsSet && varVersion.Value == null)
                throw new ArgumentNullException(nameof(varVersion), "Property is not nullable for class UserAgentDataOperatingSystem.");

            if (versionMajor.IsSet && versionMajor.Value == null)
                throw new ArgumentNullException(nameof(versionMajor), "Property is not nullable for class UserAgentDataOperatingSystem.");

            if (build.IsSet && build.Value == null)
                throw new ArgumentNullException(nameof(build), "Property is not nullable for class UserAgentDataOperatingSystem.");

            return new UserAgentDataOperatingSystem(name, type, varVersion, versionMajor, build);
        }

        /// <summary>
        /// Serializes a <see cref="UserAgentDataOperatingSystem" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userAgentDataOperatingSystem"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UserAgentDataOperatingSystem userAgentDataOperatingSystem, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, userAgentDataOperatingSystem, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UserAgentDataOperatingSystem" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userAgentDataOperatingSystem"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UserAgentDataOperatingSystem userAgentDataOperatingSystem, JsonSerializerOptions jsonSerializerOptions)
        {
            if (userAgentDataOperatingSystem.NameOption.IsSet && userAgentDataOperatingSystem.Name == null)
                throw new ArgumentNullException(nameof(userAgentDataOperatingSystem.Name), "Property is required for class UserAgentDataOperatingSystem.");

            if (userAgentDataOperatingSystem.TypeOption.IsSet && userAgentDataOperatingSystem.Type == null)
                throw new ArgumentNullException(nameof(userAgentDataOperatingSystem.Type), "Property is required for class UserAgentDataOperatingSystem.");

            if (userAgentDataOperatingSystem.VarVersionOption.IsSet && userAgentDataOperatingSystem.VarVersion == null)
                throw new ArgumentNullException(nameof(userAgentDataOperatingSystem.VarVersion), "Property is required for class UserAgentDataOperatingSystem.");

            if (userAgentDataOperatingSystem.VersionMajorOption.IsSet && userAgentDataOperatingSystem.VersionMajor == null)
                throw new ArgumentNullException(nameof(userAgentDataOperatingSystem.VersionMajor), "Property is required for class UserAgentDataOperatingSystem.");

            if (userAgentDataOperatingSystem.BuildOption.IsSet && userAgentDataOperatingSystem.Build == null)
                throw new ArgumentNullException(nameof(userAgentDataOperatingSystem.Build), "Property is required for class UserAgentDataOperatingSystem.");

            if (userAgentDataOperatingSystem.NameOption.IsSet)
                writer.WriteString("name", userAgentDataOperatingSystem.Name);

            if (userAgentDataOperatingSystem.TypeOption.IsSet)
                writer.WriteString("type", userAgentDataOperatingSystem.Type);

            if (userAgentDataOperatingSystem.VarVersionOption.IsSet)
                writer.WriteString("version", userAgentDataOperatingSystem.VarVersion);

            if (userAgentDataOperatingSystem.VersionMajorOption.IsSet)
                writer.WriteString("version_major", userAgentDataOperatingSystem.VersionMajor);

            if (userAgentDataOperatingSystem.BuildOption.IsSet)
                writer.WriteString("build", userAgentDataOperatingSystem.Build);
        }
    }
}
