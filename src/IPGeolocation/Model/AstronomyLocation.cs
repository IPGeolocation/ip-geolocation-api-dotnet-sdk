

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
    /// AstronomyLocation
    /// </summary>
    public partial class AstronomyLocation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AstronomyLocation" /> class.
        /// </summary>
        /// <param name="locationString">locationString</param>
        /// <param name="continentCode">continentCode</param>
        /// <param name="continentName">continentName</param>
        /// <param name="countryCode2">countryCode2</param>
        /// <param name="countryCode3">countryCode3</param>
        /// <param name="countryName">countryName</param>
        /// <param name="countryNameOfficial">countryNameOfficial</param>
        /// <param name="isEu">isEu</param>
        /// <param name="stateProv">stateProv</param>
        /// <param name="stateCode">stateCode</param>
        /// <param name="district">district</param>
        /// <param name="city">city</param>
        /// <param name="locality">locality</param>
        /// <param name="zipcode">zipcode</param>
        /// <param name="latitude">latitude</param>
        /// <param name="longitude">longitude</param>
        /// <param name="elevation">elevation</param>
        [JsonConstructor]
        public AstronomyLocation(Option<string?> locationString = default, Option<string?> continentCode = default, Option<string?> continentName = default, Option<string?> countryCode2 = default, Option<string?> countryCode3 = default, Option<string?> countryName = default, Option<string?> countryNameOfficial = default, Option<bool?> isEu = default, Option<string?> stateProv = default, Option<string?> stateCode = default, Option<string?> district = default, Option<string?> city = default, Option<string?> locality = default, Option<string?> zipcode = default, Option<string?> latitude = default, Option<string?> longitude = default, Option<string?> elevation = default)
        {
            LocationStringOption = locationString;
            ContinentCodeOption = continentCode;
            ContinentNameOption = continentName;
            CountryCode2Option = countryCode2;
            CountryCode3Option = countryCode3;
            CountryNameOption = countryName;
            CountryNameOfficialOption = countryNameOfficial;
            IsEuOption = isEu;
            StateProvOption = stateProv;
            StateCodeOption = stateCode;
            DistrictOption = district;
            CityOption = city;
            LocalityOption = locality;
            ZipcodeOption = zipcode;
            LatitudeOption = latitude;
            LongitudeOption = longitude;
            ElevationOption = elevation;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of LocationString
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> LocationStringOption { get; private set; }

        /// <summary>
        /// Gets or Sets LocationString
        /// </summary>
        /* <example>Londong, UK</example> */
        [JsonPropertyName("location_string")]
        public string? LocationString { get { return this.LocationStringOption; } set { this.LocationStringOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of ContinentCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ContinentCodeOption { get; private set; }

        /// <summary>
        /// Gets or Sets ContinentCode
        /// </summary>
        /* <example>OC</example> */
        [JsonPropertyName("continent_code")]
        public string? ContinentCode { get { return this.ContinentCodeOption; } set { this.ContinentCodeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of ContinentName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ContinentNameOption { get; private set; }

        /// <summary>
        /// Gets or Sets ContinentName
        /// </summary>
        /* <example>Oceania</example> */
        [JsonPropertyName("continent_name")]
        public string? ContinentName { get { return this.ContinentNameOption; } set { this.ContinentNameOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of CountryCode2
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CountryCode2Option { get; private set; }

        /// <summary>
        /// Gets or Sets CountryCode2
        /// </summary>
        /* <example>AU</example> */
        [JsonPropertyName("country_code2")]
        public string? CountryCode2 { get { return this.CountryCode2Option; } set { this.CountryCode2Option = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of CountryCode3
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CountryCode3Option { get; private set; }

        /// <summary>
        /// Gets or Sets CountryCode3
        /// </summary>
        /* <example>AUS</example> */
        [JsonPropertyName("country_code3")]
        public string? CountryCode3 { get { return this.CountryCode3Option; } set { this.CountryCode3Option = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of CountryName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CountryNameOption { get; private set; }

        /// <summary>
        /// Gets or Sets CountryName
        /// </summary>
        /* <example>Australia</example> */
        [JsonPropertyName("country_name")]
        public string? CountryName { get { return this.CountryNameOption; } set { this.CountryNameOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of CountryNameOfficial
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CountryNameOfficialOption { get; private set; }

        /// <summary>
        /// Gets or Sets CountryNameOfficial
        /// </summary>
        /* <example>Commonwealth of Australia</example> */
        [JsonPropertyName("country_name_official")]
        public string? CountryNameOfficial { get { return this.CountryNameOfficialOption; } set { this.CountryNameOfficialOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of IsEu
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsEuOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsEu
        /// </summary>
        /* <example>false</example> */
        [JsonPropertyName("is_eu")]
        public bool? IsEu { get { return this.IsEuOption; } set { this.IsEuOption = new Option<bool?>(value); } }

        /// <summary>
        /// Used to track the state of StateProv
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> StateProvOption { get; private set; }

        /// <summary>
        /// Gets or Sets StateProv
        /// </summary>
        /* <example>Queensland</example> */
        [JsonPropertyName("state_prov")]
        public string? StateProv { get { return this.StateProvOption; } set { this.StateProvOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of StateCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> StateCodeOption { get; private set; }

        /// <summary>
        /// Gets or Sets StateCode
        /// </summary>
        /* <example>AU-QLD</example> */
        [JsonPropertyName("state_code")]
        public string? StateCode { get { return this.StateCodeOption; } set { this.StateCodeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of District
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DistrictOption { get; private set; }

        /// <summary>
        /// Gets or Sets District
        /// </summary>
        /* <example>South Brisbane</example> */
        [JsonPropertyName("district")]
        public string? District { get { return this.DistrictOption; } set { this.DistrictOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of City
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CityOption { get; private set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        /* <example>Brisbane</example> */
        [JsonPropertyName("city")]
        public string? City { get { return this.CityOption; } set { this.CityOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Locality
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> LocalityOption { get; private set; }

        /// <summary>
        /// Gets or Sets Locality
        /// </summary>
        [JsonPropertyName("locality")]
        public string? Locality { get { return this.LocalityOption; } set { this.LocalityOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Zipcode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ZipcodeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Zipcode
        /// </summary>
        /* <example>4101</example> */
        [JsonPropertyName("zipcode")]
        public string? Zipcode { get { return this.ZipcodeOption; } set { this.ZipcodeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Latitude
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> LatitudeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        /* <example>-27.47306</example> */
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
        /* <example>153.01421</example> */
        [JsonPropertyName("longitude")]
        public string? Longitude { get { return this.LongitudeOption; } set { this.LongitudeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Elevation
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ElevationOption { get; private set; }

        /// <summary>
        /// Gets or Sets Elevation
        /// </summary>
        /* <example>36.6</example> */
        [JsonPropertyName("elevation")]
        public string? Elevation { get { return this.ElevationOption; } set { this.ElevationOption = new Option<string?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AstronomyLocation {\n");
            sb.Append("  LocationString: ").Append(LocationString).Append("\n");
            sb.Append("  ContinentCode: ").Append(ContinentCode).Append("\n");
            sb.Append("  ContinentName: ").Append(ContinentName).Append("\n");
            sb.Append("  CountryCode2: ").Append(CountryCode2).Append("\n");
            sb.Append("  CountryCode3: ").Append(CountryCode3).Append("\n");
            sb.Append("  CountryName: ").Append(CountryName).Append("\n");
            sb.Append("  CountryNameOfficial: ").Append(CountryNameOfficial).Append("\n");
            sb.Append("  IsEu: ").Append(IsEu).Append("\n");
            sb.Append("  StateProv: ").Append(StateProv).Append("\n");
            sb.Append("  StateCode: ").Append(StateCode).Append("\n");
            sb.Append("  District: ").Append(District).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  Zipcode: ").Append(Zipcode).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Elevation: ").Append(Elevation).Append("\n");
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
    /// A Json converter for type <see cref="AstronomyLocation" />
    /// </summary>
    public class AstronomyLocationJsonConverter : JsonConverter<AstronomyLocation>
    {
        /// <summary>
        /// Deserializes json to <see cref="AstronomyLocation" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AstronomyLocation Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> locationString = default;
            Option<string?> continentCode = default;
            Option<string?> continentName = default;
            Option<string?> countryCode2 = default;
            Option<string?> countryCode3 = default;
            Option<string?> countryName = default;
            Option<string?> countryNameOfficial = default;
            Option<bool?> isEu = default;
            Option<string?> stateProv = default;
            Option<string?> stateCode = default;
            Option<string?> district = default;
            Option<string?> city = default;
            Option<string?> locality = default;
            Option<string?> zipcode = default;
            Option<string?> latitude = default;
            Option<string?> longitude = default;
            Option<string?> elevation = default;

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
                        case "location_string":
                            locationString = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "continent_code":
                            continentCode = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "continent_name":
                            continentName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "country_code2":
                            countryCode2 = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "country_code3":
                            countryCode3 = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "country_name":
                            countryName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "country_name_official":
                            countryNameOfficial = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "is_eu":
                            isEu = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "state_prov":
                            stateProv = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "state_code":
                            stateCode = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "district":
                            district = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "city":
                            city = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "locality":
                            locality = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "zipcode":
                            zipcode = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "latitude":
                            latitude = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "longitude":
                            longitude = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "elevation":
                            elevation = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (locationString.IsSet && locationString.Value == null)
                throw new ArgumentNullException(nameof(locationString), "Property is not nullable for class AstronomyLocation.");

            if (continentCode.IsSet && continentCode.Value == null)
                throw new ArgumentNullException(nameof(continentCode), "Property is not nullable for class AstronomyLocation.");

            if (continentName.IsSet && continentName.Value == null)
                throw new ArgumentNullException(nameof(continentName), "Property is not nullable for class AstronomyLocation.");

            if (countryCode2.IsSet && countryCode2.Value == null)
                throw new ArgumentNullException(nameof(countryCode2), "Property is not nullable for class AstronomyLocation.");

            if (countryCode3.IsSet && countryCode3.Value == null)
                throw new ArgumentNullException(nameof(countryCode3), "Property is not nullable for class AstronomyLocation.");

            if (countryName.IsSet && countryName.Value == null)
                throw new ArgumentNullException(nameof(countryName), "Property is not nullable for class AstronomyLocation.");

            if (countryNameOfficial.IsSet && countryNameOfficial.Value == null)
                throw new ArgumentNullException(nameof(countryNameOfficial), "Property is not nullable for class AstronomyLocation.");

            if (isEu.IsSet && isEu.Value == null)
                throw new ArgumentNullException(nameof(isEu), "Property is not nullable for class AstronomyLocation.");

            if (stateProv.IsSet && stateProv.Value == null)
                throw new ArgumentNullException(nameof(stateProv), "Property is not nullable for class AstronomyLocation.");

            if (stateCode.IsSet && stateCode.Value == null)
                throw new ArgumentNullException(nameof(stateCode), "Property is not nullable for class AstronomyLocation.");

            if (district.IsSet && district.Value == null)
                throw new ArgumentNullException(nameof(district), "Property is not nullable for class AstronomyLocation.");

            if (city.IsSet && city.Value == null)
                throw new ArgumentNullException(nameof(city), "Property is not nullable for class AstronomyLocation.");

            if (locality.IsSet && locality.Value == null)
                throw new ArgumentNullException(nameof(locality), "Property is not nullable for class AstronomyLocation.");

            if (zipcode.IsSet && zipcode.Value == null)
                throw new ArgumentNullException(nameof(zipcode), "Property is not nullable for class AstronomyLocation.");

            if (latitude.IsSet && latitude.Value == null)
                throw new ArgumentNullException(nameof(latitude), "Property is not nullable for class AstronomyLocation.");

            if (longitude.IsSet && longitude.Value == null)
                throw new ArgumentNullException(nameof(longitude), "Property is not nullable for class AstronomyLocation.");

            if (elevation.IsSet && elevation.Value == null)
                throw new ArgumentNullException(nameof(elevation), "Property is not nullable for class AstronomyLocation.");

            return new AstronomyLocation(locationString, continentCode, continentName, countryCode2, countryCode3, countryName, countryNameOfficial, isEu, stateProv, stateCode, district, city, locality, zipcode, latitude, longitude, elevation);
        }

        /// <summary>
        /// Serializes a <see cref="AstronomyLocation" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="astronomyLocation"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AstronomyLocation astronomyLocation, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, astronomyLocation, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AstronomyLocation" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="astronomyLocation"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AstronomyLocation astronomyLocation, JsonSerializerOptions jsonSerializerOptions)
        {
            if (astronomyLocation.LocationStringOption.IsSet && astronomyLocation.LocationString == null)
                throw new ArgumentNullException(nameof(astronomyLocation.LocationString), "Property is required for class AstronomyLocation.");

            if (astronomyLocation.ContinentCodeOption.IsSet && astronomyLocation.ContinentCode == null)
                throw new ArgumentNullException(nameof(astronomyLocation.ContinentCode), "Property is required for class AstronomyLocation.");

            if (astronomyLocation.ContinentNameOption.IsSet && astronomyLocation.ContinentName == null)
                throw new ArgumentNullException(nameof(astronomyLocation.ContinentName), "Property is required for class AstronomyLocation.");

            if (astronomyLocation.CountryCode2Option.IsSet && astronomyLocation.CountryCode2 == null)
                throw new ArgumentNullException(nameof(astronomyLocation.CountryCode2), "Property is required for class AstronomyLocation.");

            if (astronomyLocation.CountryCode3Option.IsSet && astronomyLocation.CountryCode3 == null)
                throw new ArgumentNullException(nameof(astronomyLocation.CountryCode3), "Property is required for class AstronomyLocation.");

            if (astronomyLocation.CountryNameOption.IsSet && astronomyLocation.CountryName == null)
                throw new ArgumentNullException(nameof(astronomyLocation.CountryName), "Property is required for class AstronomyLocation.");

            if (astronomyLocation.CountryNameOfficialOption.IsSet && astronomyLocation.CountryNameOfficial == null)
                throw new ArgumentNullException(nameof(astronomyLocation.CountryNameOfficial), "Property is required for class AstronomyLocation.");

            if (astronomyLocation.StateProvOption.IsSet && astronomyLocation.StateProv == null)
                throw new ArgumentNullException(nameof(astronomyLocation.StateProv), "Property is required for class AstronomyLocation.");

            if (astronomyLocation.StateCodeOption.IsSet && astronomyLocation.StateCode == null)
                throw new ArgumentNullException(nameof(astronomyLocation.StateCode), "Property is required for class AstronomyLocation.");

            if (astronomyLocation.DistrictOption.IsSet && astronomyLocation.District == null)
                throw new ArgumentNullException(nameof(astronomyLocation.District), "Property is required for class AstronomyLocation.");

            if (astronomyLocation.CityOption.IsSet && astronomyLocation.City == null)
                throw new ArgumentNullException(nameof(astronomyLocation.City), "Property is required for class AstronomyLocation.");

            if (astronomyLocation.LocalityOption.IsSet && astronomyLocation.Locality == null)
                throw new ArgumentNullException(nameof(astronomyLocation.Locality), "Property is required for class AstronomyLocation.");

            if (astronomyLocation.ZipcodeOption.IsSet && astronomyLocation.Zipcode == null)
                throw new ArgumentNullException(nameof(astronomyLocation.Zipcode), "Property is required for class AstronomyLocation.");

            if (astronomyLocation.LatitudeOption.IsSet && astronomyLocation.Latitude == null)
                throw new ArgumentNullException(nameof(astronomyLocation.Latitude), "Property is required for class AstronomyLocation.");

            if (astronomyLocation.LongitudeOption.IsSet && astronomyLocation.Longitude == null)
                throw new ArgumentNullException(nameof(astronomyLocation.Longitude), "Property is required for class AstronomyLocation.");

            if (astronomyLocation.ElevationOption.IsSet && astronomyLocation.Elevation == null)
                throw new ArgumentNullException(nameof(astronomyLocation.Elevation), "Property is required for class AstronomyLocation.");

            if (astronomyLocation.LocationStringOption.IsSet)
                writer.WriteString("location_string", astronomyLocation.LocationString);

            if (astronomyLocation.ContinentCodeOption.IsSet)
                writer.WriteString("continent_code", astronomyLocation.ContinentCode);

            if (astronomyLocation.ContinentNameOption.IsSet)
                writer.WriteString("continent_name", astronomyLocation.ContinentName);

            if (astronomyLocation.CountryCode2Option.IsSet)
                writer.WriteString("country_code2", astronomyLocation.CountryCode2);

            if (astronomyLocation.CountryCode3Option.IsSet)
                writer.WriteString("country_code3", astronomyLocation.CountryCode3);

            if (astronomyLocation.CountryNameOption.IsSet)
                writer.WriteString("country_name", astronomyLocation.CountryName);

            if (astronomyLocation.CountryNameOfficialOption.IsSet)
                writer.WriteString("country_name_official", astronomyLocation.CountryNameOfficial);

            if (astronomyLocation.IsEuOption.IsSet)
                writer.WriteBoolean("is_eu", astronomyLocation.IsEuOption.Value!.Value);

            if (astronomyLocation.StateProvOption.IsSet)
                writer.WriteString("state_prov", astronomyLocation.StateProv);

            if (astronomyLocation.StateCodeOption.IsSet)
                writer.WriteString("state_code", astronomyLocation.StateCode);

            if (astronomyLocation.DistrictOption.IsSet)
                writer.WriteString("district", astronomyLocation.District);

            if (astronomyLocation.CityOption.IsSet)
                writer.WriteString("city", astronomyLocation.City);

            if (astronomyLocation.LocalityOption.IsSet)
                writer.WriteString("locality", astronomyLocation.Locality);

            if (astronomyLocation.ZipcodeOption.IsSet)
                writer.WriteString("zipcode", astronomyLocation.Zipcode);

            if (astronomyLocation.LatitudeOption.IsSet)
                writer.WriteString("latitude", astronomyLocation.Latitude);

            if (astronomyLocation.LongitudeOption.IsSet)
                writer.WriteString("longitude", astronomyLocation.Longitude);

            if (astronomyLocation.ElevationOption.IsSet)
                writer.WriteString("elevation", astronomyLocation.Elevation);
        }
    }
}
