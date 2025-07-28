

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
    /// TimezoneLocode
    /// </summary>
    public partial class TimezoneLocode : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimezoneLocode" /> class.
        /// </summary>
        /// <param name="loCode">loCode</param>
        /// <param name="city">city</param>
        /// <param name="stateCode">stateCode</param>
        /// <param name="countryCode">countryCode</param>
        /// <param name="countryName">countryName</param>
        /// <param name="locationType">locationType</param>
        /// <param name="latitude">latitude</param>
        /// <param name="longitude">longitude</param>
        [JsonConstructor]
        public TimezoneLocode(Option<string?> loCode = default, Option<string?> city = default, Option<string?> stateCode = default, Option<string?> countryCode = default, Option<string?> countryName = default, Option<string?> locationType = default, Option<string?> latitude = default, Option<string?> longitude = default)
        {
            LoCodeOption = loCode;
            CityOption = city;
            StateCodeOption = stateCode;
            CountryCodeOption = countryCode;
            CountryNameOption = countryName;
            LocationTypeOption = locationType;
            LatitudeOption = latitude;
            LongitudeOption = longitude;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of LoCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> LoCodeOption { get; private set; }

        /// <summary>
        /// Gets or Sets LoCode
        /// </summary>
        /* <example>DEBER</example> */
        [JsonPropertyName("lo_code")]
        public string? LoCode { get { return this.LoCodeOption; } set { this.LoCodeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of City
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CityOption { get; private set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        /* <example>Berlin</example> */
        [JsonPropertyName("city")]
        public string? City { get { return this.CityOption; } set { this.CityOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of StateCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> StateCodeOption { get; private set; }

        /// <summary>
        /// Gets or Sets StateCode
        /// </summary>
        /* <example>BE</example> */
        [JsonPropertyName("state_code")]
        public string? StateCode { get { return this.StateCodeOption; } set { this.StateCodeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of CountryCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CountryCodeOption { get; private set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        /* <example>DE</example> */
        [JsonPropertyName("country_code")]
        public string? CountryCode { get { return this.CountryCodeOption; } set { this.CountryCodeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of CountryName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CountryNameOption { get; private set; }

        /// <summary>
        /// Gets or Sets CountryName
        /// </summary>
        [JsonPropertyName("country_name")]
        public string? CountryName { get { return this.CountryNameOption; } set { this.CountryNameOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of LocationType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> LocationTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets LocationType
        /// </summary>
        /* <example>Port, Rail Terminal, Road Terminal, Airport, Postal Exchange</example> */
        [JsonPropertyName("location_type")]
        public string? LocationType { get { return this.LocationTypeOption; } set { this.LocationTypeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Latitude
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> LatitudeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        /* <example>52.51667</example> */
        [JsonPropertyName("latitude")]
        public string? Latitude { get { return this.LatitudeOption; } set { this.LatitudeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Longitude
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> LongitudeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        /* <example>13.38333</example> */
        [JsonPropertyName("longitude")]
        public string? Longitude { get { return this.LongitudeOption; } set { this.LongitudeOption = new Option<string?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TimezoneLocode {\n");
            sb.Append("  LoCode: ").Append(LoCode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  StateCode: ").Append(StateCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CountryName: ").Append(CountryName).Append("\n");
            sb.Append("  LocationType: ").Append(LocationType).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
    /// A Json converter for type <see cref="TimezoneLocode" />
    /// </summary>
    public class TimezoneLocodeJsonConverter : JsonConverter<TimezoneLocode>
    {
        /// <summary>
        /// Deserializes json to <see cref="TimezoneLocode" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TimezoneLocode Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> loCode = default;
            Option<string?> city = default;
            Option<string?> stateCode = default;
            Option<string?> countryCode = default;
            Option<string?> countryName = default;
            Option<string?> locationType = default;
            Option<string?> latitude = default;
            Option<string?> longitude = default;

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
                        case "lo_code":
                            loCode = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "city":
                            city = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "state_code":
                            stateCode = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "country_code":
                            countryCode = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "country_name":
                            countryName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "location_type":
                            locationType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "latitude":
                            latitude = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "longitude":
                            longitude = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (loCode.IsSet && loCode.Value == null)
                throw new ArgumentNullException(nameof(loCode), "Property is not nullable for class TimezoneLocode.");

            if (city.IsSet && city.Value == null)
                throw new ArgumentNullException(nameof(city), "Property is not nullable for class TimezoneLocode.");

            if (stateCode.IsSet && stateCode.Value == null)
                throw new ArgumentNullException(nameof(stateCode), "Property is not nullable for class TimezoneLocode.");

            if (countryCode.IsSet && countryCode.Value == null)
                throw new ArgumentNullException(nameof(countryCode), "Property is not nullable for class TimezoneLocode.");

            if (countryName.IsSet && countryName.Value == null)
                throw new ArgumentNullException(nameof(countryName), "Property is not nullable for class TimezoneLocode.");

            if (locationType.IsSet && locationType.Value == null)
                throw new ArgumentNullException(nameof(locationType), "Property is not nullable for class TimezoneLocode.");

            if (latitude.IsSet && latitude.Value == null)
                throw new ArgumentNullException(nameof(latitude), "Property is not nullable for class TimezoneLocode.");

            if (longitude.IsSet && longitude.Value == null)
                throw new ArgumentNullException(nameof(longitude), "Property is not nullable for class TimezoneLocode.");

            return new TimezoneLocode(loCode, city, stateCode, countryCode, countryName, locationType, latitude, longitude);
        }

        /// <summary>
        /// Serializes a <see cref="TimezoneLocode" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="timezoneLocode"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TimezoneLocode timezoneLocode, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, timezoneLocode, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TimezoneLocode" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="timezoneLocode"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TimezoneLocode timezoneLocode, JsonSerializerOptions jsonSerializerOptions)
        {
            if (timezoneLocode.LoCodeOption.IsSet && timezoneLocode.LoCode == null)
                throw new ArgumentNullException(nameof(timezoneLocode.LoCode), "Property is required for class TimezoneLocode.");

            if (timezoneLocode.CityOption.IsSet && timezoneLocode.City == null)
                throw new ArgumentNullException(nameof(timezoneLocode.City), "Property is required for class TimezoneLocode.");

            if (timezoneLocode.StateCodeOption.IsSet && timezoneLocode.StateCode == null)
                throw new ArgumentNullException(nameof(timezoneLocode.StateCode), "Property is required for class TimezoneLocode.");

            if (timezoneLocode.CountryCodeOption.IsSet && timezoneLocode.CountryCode == null)
                throw new ArgumentNullException(nameof(timezoneLocode.CountryCode), "Property is required for class TimezoneLocode.");

            if (timezoneLocode.CountryNameOption.IsSet && timezoneLocode.CountryName == null)
                throw new ArgumentNullException(nameof(timezoneLocode.CountryName), "Property is required for class TimezoneLocode.");

            if (timezoneLocode.LocationTypeOption.IsSet && timezoneLocode.LocationType == null)
                throw new ArgumentNullException(nameof(timezoneLocode.LocationType), "Property is required for class TimezoneLocode.");

            if (timezoneLocode.LatitudeOption.IsSet && timezoneLocode.Latitude == null)
                throw new ArgumentNullException(nameof(timezoneLocode.Latitude), "Property is required for class TimezoneLocode.");

            if (timezoneLocode.LongitudeOption.IsSet && timezoneLocode.Longitude == null)
                throw new ArgumentNullException(nameof(timezoneLocode.Longitude), "Property is required for class TimezoneLocode.");

            if (timezoneLocode.LoCodeOption.IsSet)
                writer.WriteString("lo_code", timezoneLocode.LoCode);

            if (timezoneLocode.CityOption.IsSet)
                writer.WriteString("city", timezoneLocode.City);

            if (timezoneLocode.StateCodeOption.IsSet)
                writer.WriteString("state_code", timezoneLocode.StateCode);

            if (timezoneLocode.CountryCodeOption.IsSet)
                writer.WriteString("country_code", timezoneLocode.CountryCode);

            if (timezoneLocode.CountryNameOption.IsSet)
                writer.WriteString("country_name", timezoneLocode.CountryName);

            if (timezoneLocode.LocationTypeOption.IsSet)
                writer.WriteString("location_type", timezoneLocode.LocationType);

            if (timezoneLocode.LatitudeOption.IsSet)
                writer.WriteString("latitude", timezoneLocode.Latitude);

            if (timezoneLocode.LongitudeOption.IsSet)
                writer.WriteString("longitude", timezoneLocode.Longitude);
        }
    }
}
