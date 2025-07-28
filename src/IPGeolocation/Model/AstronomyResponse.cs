

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
    /// AstronomyResponse
    /// </summary>
    public partial class AstronomyResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AstronomyResponse" /> class.
        /// </summary>
        /// <param name="ip">ip</param>
        /// <param name="location">location</param>
        /// <param name="astronomy">astronomy</param>
        [JsonConstructor]
        public AstronomyResponse(Option<string?> ip = default, Option<AstronomyLocation?> location = default, Option<Astronomy?> astronomy = default)
        {
            IpOption = ip;
            LocationOption = location;
            AstronomyOption = astronomy;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Ip
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IpOption { get; private set; }

        /// <summary>
        /// Gets or Sets Ip
        /// </summary>
        /* <example>8.8.8.8</example> */
        [JsonPropertyName("ip")]
        public string? Ip { get { return this.IpOption; } set { this.IpOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Location
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<AstronomyLocation?> LocationOption { get; private set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [JsonPropertyName("location")]
        public AstronomyLocation? Location { get { return this.LocationOption; } set { this.LocationOption = new Option<AstronomyLocation?>(value); } }

        /// <summary>
        /// Used to track the state of Astronomy
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Astronomy?> AstronomyOption { get; private set; }

        /// <summary>
        /// Gets or Sets Astronomy
        /// </summary>
        [JsonPropertyName("astronomy")]
        public Astronomy? Astronomy { get { return this.AstronomyOption; } set { this.AstronomyOption = new Option<Astronomy?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AstronomyResponse {\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Astronomy: ").Append(Astronomy).Append("\n");
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
    /// A Json converter for type <see cref="AstronomyResponse" />
    /// </summary>
    public class AstronomyResponseJsonConverter : JsonConverter<AstronomyResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="AstronomyResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AstronomyResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> ip = default;
            Option<AstronomyLocation?> location = default;
            Option<Astronomy?> astronomy = default;

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
                        case "ip":
                            ip = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "location":
                            location = new Option<AstronomyLocation?>(JsonSerializer.Deserialize<AstronomyLocation>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "astronomy":
                            astronomy = new Option<Astronomy?>(JsonSerializer.Deserialize<Astronomy>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (ip.IsSet && ip.Value == null)
                throw new ArgumentNullException(nameof(ip), "Property is not nullable for class AstronomyResponse.");

            if (location.IsSet && location.Value == null)
                throw new ArgumentNullException(nameof(location), "Property is not nullable for class AstronomyResponse.");

            if (astronomy.IsSet && astronomy.Value == null)
                throw new ArgumentNullException(nameof(astronomy), "Property is not nullable for class AstronomyResponse.");

            return new AstronomyResponse(ip, location, astronomy);
        }

        /// <summary>
        /// Serializes a <see cref="AstronomyResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="astronomyResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AstronomyResponse astronomyResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, astronomyResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AstronomyResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="astronomyResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AstronomyResponse astronomyResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (astronomyResponse.IpOption.IsSet && astronomyResponse.Ip == null)
                throw new ArgumentNullException(nameof(astronomyResponse.Ip), "Property is required for class AstronomyResponse.");

            if (astronomyResponse.LocationOption.IsSet && astronomyResponse.Location == null)
                throw new ArgumentNullException(nameof(astronomyResponse.Location), "Property is required for class AstronomyResponse.");

            if (astronomyResponse.AstronomyOption.IsSet && astronomyResponse.Astronomy == null)
                throw new ArgumentNullException(nameof(astronomyResponse.Astronomy), "Property is required for class AstronomyResponse.");

            if (astronomyResponse.IpOption.IsSet)
                writer.WriteString("ip", astronomyResponse.Ip);

            if (astronomyResponse.LocationOption.IsSet)
            {
                writer.WritePropertyName("location");
                JsonSerializer.Serialize(writer, astronomyResponse.Location, jsonSerializerOptions);
            }
            if (astronomyResponse.AstronomyOption.IsSet)
            {
                writer.WritePropertyName("astronomy");
                JsonSerializer.Serialize(writer, astronomyResponse.Astronomy, jsonSerializerOptions);
            }
        }
    }
}
