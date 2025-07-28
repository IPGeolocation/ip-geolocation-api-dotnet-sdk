

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
    /// TimeZoneDetailedXMLResponse
    /// </summary>
    public partial class TimeZoneDetailedXMLResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeZoneDetailedXMLResponse" /> class.
        /// </summary>
        /// <param name="ip">ip</param>
        /// <param name="airportDetails">airportDetails</param>
        /// <param name="loCodeDetails">loCodeDetails</param>
        /// <param name="location">location</param>
        /// <param name="varTimeZone">varTimeZone</param>
        [JsonConstructor]
        public TimeZoneDetailedXMLResponse(Option<string?> ip = default, Option<TimezoneAirport?> airportDetails = default, Option<TimezoneLocode?> loCodeDetails = default, Option<TimezoneLocation?> location = default, Option<TimezoneDetail?> varTimeZone = default)
        {
            IpOption = ip;
            AirportDetailsOption = airportDetails;
            LoCodeDetailsOption = loCodeDetails;
            LocationOption = location;
            VarTimeZoneOption = varTimeZone;
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
        /// Used to track the state of AirportDetails
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<TimezoneAirport?> AirportDetailsOption { get; private set; }

        /// <summary>
        /// Gets or Sets AirportDetails
        /// </summary>
        [JsonPropertyName("airport_details")]
        public TimezoneAirport? AirportDetails { get { return this.AirportDetailsOption; } set { this.AirportDetailsOption = new Option<TimezoneAirport?>(value); } }

        /// <summary>
        /// Used to track the state of LoCodeDetails
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<TimezoneLocode?> LoCodeDetailsOption { get; private set; }

        /// <summary>
        /// Gets or Sets LoCodeDetails
        /// </summary>
        [JsonPropertyName("lo_code_details")]
        public TimezoneLocode? LoCodeDetails { get { return this.LoCodeDetailsOption; } set { this.LoCodeDetailsOption = new Option<TimezoneLocode?>(value); } }

        /// <summary>
        /// Used to track the state of Location
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<TimezoneLocation?> LocationOption { get; private set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [JsonPropertyName("location")]
        public TimezoneLocation? Location { get { return this.LocationOption; } set { this.LocationOption = new Option<TimezoneLocation?>(value); } }

        /// <summary>
        /// Used to track the state of VarTimeZone
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<TimezoneDetail?> VarTimeZoneOption { get; private set; }

        /// <summary>
        /// Gets or Sets VarTimeZone
        /// </summary>
        [JsonPropertyName("time_zone")]
        public TimezoneDetail? VarTimeZone { get { return this.VarTimeZoneOption; } set { this.VarTimeZoneOption = new Option<TimezoneDetail?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TimeZoneDetailedXMLResponse {\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  AirportDetails: ").Append(AirportDetails).Append("\n");
            sb.Append("  LoCodeDetails: ").Append(LoCodeDetails).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  VarTimeZone: ").Append(VarTimeZone).Append("\n");
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
    /// A Json converter for type <see cref="TimeZoneDetailedXMLResponse" />
    /// </summary>
    public class TimeZoneDetailedXMLResponseJsonConverter : JsonConverter<TimeZoneDetailedXMLResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="TimeZoneDetailedXMLResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TimeZoneDetailedXMLResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> ip = default;
            Option<TimezoneAirport?> airportDetails = default;
            Option<TimezoneLocode?> loCodeDetails = default;
            Option<TimezoneLocation?> location = default;
            Option<TimezoneDetail?> varTimeZone = default;

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
                        case "airport_details":
                            airportDetails = new Option<TimezoneAirport?>(JsonSerializer.Deserialize<TimezoneAirport>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "lo_code_details":
                            loCodeDetails = new Option<TimezoneLocode?>(JsonSerializer.Deserialize<TimezoneLocode>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "location":
                            location = new Option<TimezoneLocation?>(JsonSerializer.Deserialize<TimezoneLocation>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "time_zone":
                            varTimeZone = new Option<TimezoneDetail?>(JsonSerializer.Deserialize<TimezoneDetail>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (ip.IsSet && ip.Value == null)
                throw new ArgumentNullException(nameof(ip), "Property is not nullable for class TimeZoneDetailedXMLResponse.");

            if (airportDetails.IsSet && airportDetails.Value == null)
                throw new ArgumentNullException(nameof(airportDetails), "Property is not nullable for class TimeZoneDetailedXMLResponse.");

            if (loCodeDetails.IsSet && loCodeDetails.Value == null)
                throw new ArgumentNullException(nameof(loCodeDetails), "Property is not nullable for class TimeZoneDetailedXMLResponse.");

            if (location.IsSet && location.Value == null)
                throw new ArgumentNullException(nameof(location), "Property is not nullable for class TimeZoneDetailedXMLResponse.");

            if (varTimeZone.IsSet && varTimeZone.Value == null)
                throw new ArgumentNullException(nameof(varTimeZone), "Property is not nullable for class TimeZoneDetailedXMLResponse.");

            return new TimeZoneDetailedXMLResponse(ip, airportDetails, loCodeDetails, location, varTimeZone);
        }

        /// <summary>
        /// Serializes a <see cref="TimeZoneDetailedXMLResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="timeZoneDetailedXMLResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TimeZoneDetailedXMLResponse timeZoneDetailedXMLResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, timeZoneDetailedXMLResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TimeZoneDetailedXMLResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="timeZoneDetailedXMLResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TimeZoneDetailedXMLResponse timeZoneDetailedXMLResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (timeZoneDetailedXMLResponse.IpOption.IsSet && timeZoneDetailedXMLResponse.Ip == null)
                throw new ArgumentNullException(nameof(timeZoneDetailedXMLResponse.Ip), "Property is required for class TimeZoneDetailedXMLResponse.");

            if (timeZoneDetailedXMLResponse.AirportDetailsOption.IsSet && timeZoneDetailedXMLResponse.AirportDetails == null)
                throw new ArgumentNullException(nameof(timeZoneDetailedXMLResponse.AirportDetails), "Property is required for class TimeZoneDetailedXMLResponse.");

            if (timeZoneDetailedXMLResponse.LoCodeDetailsOption.IsSet && timeZoneDetailedXMLResponse.LoCodeDetails == null)
                throw new ArgumentNullException(nameof(timeZoneDetailedXMLResponse.LoCodeDetails), "Property is required for class TimeZoneDetailedXMLResponse.");

            if (timeZoneDetailedXMLResponse.LocationOption.IsSet && timeZoneDetailedXMLResponse.Location == null)
                throw new ArgumentNullException(nameof(timeZoneDetailedXMLResponse.Location), "Property is required for class TimeZoneDetailedXMLResponse.");

            if (timeZoneDetailedXMLResponse.VarTimeZoneOption.IsSet && timeZoneDetailedXMLResponse.VarTimeZone == null)
                throw new ArgumentNullException(nameof(timeZoneDetailedXMLResponse.VarTimeZone), "Property is required for class TimeZoneDetailedXMLResponse.");

            if (timeZoneDetailedXMLResponse.IpOption.IsSet)
                writer.WriteString("ip", timeZoneDetailedXMLResponse.Ip);

            if (timeZoneDetailedXMLResponse.AirportDetailsOption.IsSet)
            {
                writer.WritePropertyName("airport_details");
                JsonSerializer.Serialize(writer, timeZoneDetailedXMLResponse.AirportDetails, jsonSerializerOptions);
            }
            if (timeZoneDetailedXMLResponse.LoCodeDetailsOption.IsSet)
            {
                writer.WritePropertyName("lo_code_details");
                JsonSerializer.Serialize(writer, timeZoneDetailedXMLResponse.LoCodeDetails, jsonSerializerOptions);
            }
            if (timeZoneDetailedXMLResponse.LocationOption.IsSet)
            {
                writer.WritePropertyName("location");
                JsonSerializer.Serialize(writer, timeZoneDetailedXMLResponse.Location, jsonSerializerOptions);
            }
            if (timeZoneDetailedXMLResponse.VarTimeZoneOption.IsSet)
            {
                writer.WritePropertyName("time_zone");
                JsonSerializer.Serialize(writer, timeZoneDetailedXMLResponse.VarTimeZone, jsonSerializerOptions);
            }
        }
    }
}
