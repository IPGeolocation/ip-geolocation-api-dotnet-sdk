

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
    /// TimezoneAirport
    /// </summary>
    public partial class TimezoneAirport : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimezoneAirport" /> class.
        /// </summary>
        /// <param name="type">type</param>
        /// <param name="name">name</param>
        /// <param name="latitude">latitude</param>
        /// <param name="longitude">longitude</param>
        /// <param name="elevationFt">elevationFt</param>
        /// <param name="continentCode">continentCode</param>
        /// <param name="countryCode">countryCode</param>
        /// <param name="stateCode">stateCode</param>
        /// <param name="city">city</param>
        /// <param name="iataCode">iataCode</param>
        /// <param name="icaoCode">icaoCode</param>
        /// <param name="faaCode">faaCode</param>
        [JsonConstructor]
        public TimezoneAirport(Option<string?> type = default, Option<string?> name = default, Option<string?> latitude = default, Option<string?> longitude = default, Option<int?> elevationFt = default, Option<string?> continentCode = default, Option<string?> countryCode = default, Option<string?> stateCode = default, Option<string?> city = default, Option<string?> iataCode = default, Option<string?> icaoCode = default, Option<string?> faaCode = default)
        {
            TypeOption = type;
            NameOption = name;
            LatitudeOption = latitude;
            LongitudeOption = longitude;
            ElevationFtOption = elevationFt;
            ContinentCodeOption = continentCode;
            CountryCodeOption = countryCode;
            StateCodeOption = stateCode;
            CityOption = city;
            IataCodeOption = iataCode;
            IcaoCodeOption = icaoCode;
            FaaCodeOption = faaCode;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Type
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /* <example>large_airport</example> */
        [JsonPropertyName("type")]
        public string? Type { get { return this.TypeOption; } set { this.TypeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NameOption { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /* <example>Hartsfield Jackson Atlanta International Airport</example> */
        [JsonPropertyName("name")]
        public string? Name { get { return this.NameOption; } set { this.NameOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Latitude
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> LatitudeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        /* <example>33.63670</example> */
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
        /* <example>-84.42810</example> */
        [JsonPropertyName("longitude")]
        public string? Longitude { get { return this.LongitudeOption; } set { this.LongitudeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of ElevationFt
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> ElevationFtOption { get; private set; }

        /// <summary>
        /// Gets or Sets ElevationFt
        /// </summary>
        /* <example>1026</example> */
        [JsonPropertyName("elevation_ft")]
        public int? ElevationFt { get { return this.ElevationFtOption; } set { this.ElevationFtOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of ContinentCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ContinentCodeOption { get; private set; }

        /// <summary>
        /// Gets or Sets ContinentCode
        /// </summary>
        /* <example>NA</example> */
        [JsonPropertyName("continent_code")]
        public string? ContinentCode { get { return this.ContinentCodeOption; } set { this.ContinentCodeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of CountryCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CountryCodeOption { get; private set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        /* <example>US</example> */
        [JsonPropertyName("country_code")]
        public string? CountryCode { get { return this.CountryCodeOption; } set { this.CountryCodeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of StateCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> StateCodeOption { get; private set; }

        /// <summary>
        /// Gets or Sets StateCode
        /// </summary>
        /* <example>US-GA</example> */
        [JsonPropertyName("state_code")]
        public string? StateCode { get { return this.StateCodeOption; } set { this.StateCodeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of City
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CityOption { get; private set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        /* <example>Atlanta</example> */
        [JsonPropertyName("city")]
        public string? City { get { return this.CityOption; } set { this.CityOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of IataCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IataCodeOption { get; private set; }

        /// <summary>
        /// Gets or Sets IataCode
        /// </summary>
        /* <example>ATL</example> */
        [JsonPropertyName("iata_code")]
        public string? IataCode { get { return this.IataCodeOption; } set { this.IataCodeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of IcaoCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IcaoCodeOption { get; private set; }

        /// <summary>
        /// Gets or Sets IcaoCode
        /// </summary>
        /* <example>KATL</example> */
        [JsonPropertyName("icao_code")]
        public string? IcaoCode { get { return this.IcaoCodeOption; } set { this.IcaoCodeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of FaaCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> FaaCodeOption { get; private set; }

        /// <summary>
        /// Gets or Sets FaaCode
        /// </summary>
        [JsonPropertyName("faa_code")]
        public string? FaaCode { get { return this.FaaCodeOption; } set { this.FaaCodeOption = new Option<string?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TimezoneAirport {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  ElevationFt: ").Append(ElevationFt).Append("\n");
            sb.Append("  ContinentCode: ").Append(ContinentCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  StateCode: ").Append(StateCode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  IataCode: ").Append(IataCode).Append("\n");
            sb.Append("  IcaoCode: ").Append(IcaoCode).Append("\n");
            sb.Append("  FaaCode: ").Append(FaaCode).Append("\n");
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
    /// A Json converter for type <see cref="TimezoneAirport" />
    /// </summary>
    public class TimezoneAirportJsonConverter : JsonConverter<TimezoneAirport>
    {
        /// <summary>
        /// Deserializes json to <see cref="TimezoneAirport" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TimezoneAirport Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> type = default;
            Option<string?> name = default;
            Option<string?> latitude = default;
            Option<string?> longitude = default;
            Option<int?> elevationFt = default;
            Option<string?> continentCode = default;
            Option<string?> countryCode = default;
            Option<string?> stateCode = default;
            Option<string?> city = default;
            Option<string?> iataCode = default;
            Option<string?> icaoCode = default;
            Option<string?> faaCode = default;

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
                        case "type":
                            type = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "latitude":
                            latitude = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "longitude":
                            longitude = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "elevation_ft":
                            elevationFt = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "continent_code":
                            continentCode = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "country_code":
                            countryCode = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "state_code":
                            stateCode = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "city":
                            city = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "iata_code":
                            iataCode = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "icao_code":
                            icaoCode = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "faa_code":
                            faaCode = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class TimezoneAirport.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class TimezoneAirport.");

            if (latitude.IsSet && latitude.Value == null)
                throw new ArgumentNullException(nameof(latitude), "Property is not nullable for class TimezoneAirport.");

            if (longitude.IsSet && longitude.Value == null)
                throw new ArgumentNullException(nameof(longitude), "Property is not nullable for class TimezoneAirport.");

            if (elevationFt.IsSet && elevationFt.Value == null)
                throw new ArgumentNullException(nameof(elevationFt), "Property is not nullable for class TimezoneAirport.");

            if (continentCode.IsSet && continentCode.Value == null)
                throw new ArgumentNullException(nameof(continentCode), "Property is not nullable for class TimezoneAirport.");

            if (countryCode.IsSet && countryCode.Value == null)
                throw new ArgumentNullException(nameof(countryCode), "Property is not nullable for class TimezoneAirport.");

            if (stateCode.IsSet && stateCode.Value == null)
                throw new ArgumentNullException(nameof(stateCode), "Property is not nullable for class TimezoneAirport.");

            if (city.IsSet && city.Value == null)
                throw new ArgumentNullException(nameof(city), "Property is not nullable for class TimezoneAirport.");

            if (iataCode.IsSet && iataCode.Value == null)
                throw new ArgumentNullException(nameof(iataCode), "Property is not nullable for class TimezoneAirport.");

            if (icaoCode.IsSet && icaoCode.Value == null)
                throw new ArgumentNullException(nameof(icaoCode), "Property is not nullable for class TimezoneAirport.");

            if (faaCode.IsSet && faaCode.Value == null)
                throw new ArgumentNullException(nameof(faaCode), "Property is not nullable for class TimezoneAirport.");

            return new TimezoneAirport(type, name, latitude, longitude, elevationFt, continentCode, countryCode, stateCode, city, iataCode, icaoCode, faaCode);
        }

        /// <summary>
        /// Serializes a <see cref="TimezoneAirport" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="timezoneAirport"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TimezoneAirport timezoneAirport, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, timezoneAirport, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TimezoneAirport" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="timezoneAirport"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TimezoneAirport timezoneAirport, JsonSerializerOptions jsonSerializerOptions)
        {
            if (timezoneAirport.TypeOption.IsSet && timezoneAirport.Type == null)
                throw new ArgumentNullException(nameof(timezoneAirport.Type), "Property is required for class TimezoneAirport.");

            if (timezoneAirport.NameOption.IsSet && timezoneAirport.Name == null)
                throw new ArgumentNullException(nameof(timezoneAirport.Name), "Property is required for class TimezoneAirport.");

            if (timezoneAirport.LatitudeOption.IsSet && timezoneAirport.Latitude == null)
                throw new ArgumentNullException(nameof(timezoneAirport.Latitude), "Property is required for class TimezoneAirport.");

            if (timezoneAirport.LongitudeOption.IsSet && timezoneAirport.Longitude == null)
                throw new ArgumentNullException(nameof(timezoneAirport.Longitude), "Property is required for class TimezoneAirport.");

            if (timezoneAirport.ContinentCodeOption.IsSet && timezoneAirport.ContinentCode == null)
                throw new ArgumentNullException(nameof(timezoneAirport.ContinentCode), "Property is required for class TimezoneAirport.");

            if (timezoneAirport.CountryCodeOption.IsSet && timezoneAirport.CountryCode == null)
                throw new ArgumentNullException(nameof(timezoneAirport.CountryCode), "Property is required for class TimezoneAirport.");

            if (timezoneAirport.StateCodeOption.IsSet && timezoneAirport.StateCode == null)
                throw new ArgumentNullException(nameof(timezoneAirport.StateCode), "Property is required for class TimezoneAirport.");

            if (timezoneAirport.CityOption.IsSet && timezoneAirport.City == null)
                throw new ArgumentNullException(nameof(timezoneAirport.City), "Property is required for class TimezoneAirport.");

            if (timezoneAirport.IataCodeOption.IsSet && timezoneAirport.IataCode == null)
                throw new ArgumentNullException(nameof(timezoneAirport.IataCode), "Property is required for class TimezoneAirport.");

            if (timezoneAirport.IcaoCodeOption.IsSet && timezoneAirport.IcaoCode == null)
                throw new ArgumentNullException(nameof(timezoneAirport.IcaoCode), "Property is required for class TimezoneAirport.");

            if (timezoneAirport.FaaCodeOption.IsSet && timezoneAirport.FaaCode == null)
                throw new ArgumentNullException(nameof(timezoneAirport.FaaCode), "Property is required for class TimezoneAirport.");

            if (timezoneAirport.TypeOption.IsSet)
                writer.WriteString("type", timezoneAirport.Type);

            if (timezoneAirport.NameOption.IsSet)
                writer.WriteString("name", timezoneAirport.Name);

            if (timezoneAirport.LatitudeOption.IsSet)
                writer.WriteString("latitude", timezoneAirport.Latitude);

            if (timezoneAirport.LongitudeOption.IsSet)
                writer.WriteString("longitude", timezoneAirport.Longitude);

            if (timezoneAirport.ElevationFtOption.IsSet)
                writer.WriteNumber("elevation_ft", timezoneAirport.ElevationFtOption.Value!.Value);

            if (timezoneAirport.ContinentCodeOption.IsSet)
                writer.WriteString("continent_code", timezoneAirport.ContinentCode);

            if (timezoneAirport.CountryCodeOption.IsSet)
                writer.WriteString("country_code", timezoneAirport.CountryCode);

            if (timezoneAirport.StateCodeOption.IsSet)
                writer.WriteString("state_code", timezoneAirport.StateCode);

            if (timezoneAirport.CityOption.IsSet)
                writer.WriteString("city", timezoneAirport.City);

            if (timezoneAirport.IataCodeOption.IsSet)
                writer.WriteString("iata_code", timezoneAirport.IataCode);

            if (timezoneAirport.IcaoCodeOption.IsSet)
                writer.WriteString("icao_code", timezoneAirport.IcaoCode);

            if (timezoneAirport.FaaCodeOption.IsSet)
                writer.WriteString("faa_code", timezoneAirport.FaaCode);
        }
    }
}
