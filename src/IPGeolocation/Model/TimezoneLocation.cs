

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
    /// TimezoneLocation
    /// </summary>
    public partial class TimezoneLocation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimezoneLocation" /> class.
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
        [JsonConstructor]
        public TimezoneLocation(Option<string?> locationString = default, Option<string?> continentCode = default, Option<string?> continentName = default, Option<string?> countryCode2 = default, Option<string?> countryCode3 = default, Option<string?> countryName = default, Option<string?> countryNameOfficial = default, Option<bool?> isEu = default, Option<string?> stateProv = default, Option<string?> stateCode = default, Option<string?> district = default, Option<string?> city = default, Option<string?> locality = default, Option<string?> zipcode = default, Option<string?> latitude = default, Option<string?> longitude = default)
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TimezoneLocation {\n");
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
    /// A Json converter for type <see cref="TimezoneLocation" />
    /// </summary>
    public class TimezoneLocationJsonConverter : JsonConverter<TimezoneLocation>
    {
        /// <summary>
        /// Deserializes json to <see cref="TimezoneLocation" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TimezoneLocation Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
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
                        default:
                            break;
                    }
                }
            }

            if (locationString.IsSet && locationString.Value == null)
                throw new ArgumentNullException(nameof(locationString), "Property is not nullable for class TimezoneLocation.");

            if (continentCode.IsSet && continentCode.Value == null)
                throw new ArgumentNullException(nameof(continentCode), "Property is not nullable for class TimezoneLocation.");

            if (continentName.IsSet && continentName.Value == null)
                throw new ArgumentNullException(nameof(continentName), "Property is not nullable for class TimezoneLocation.");

            if (countryCode2.IsSet && countryCode2.Value == null)
                throw new ArgumentNullException(nameof(countryCode2), "Property is not nullable for class TimezoneLocation.");

            if (countryCode3.IsSet && countryCode3.Value == null)
                throw new ArgumentNullException(nameof(countryCode3), "Property is not nullable for class TimezoneLocation.");

            if (countryName.IsSet && countryName.Value == null)
                throw new ArgumentNullException(nameof(countryName), "Property is not nullable for class TimezoneLocation.");

            if (countryNameOfficial.IsSet && countryNameOfficial.Value == null)
                throw new ArgumentNullException(nameof(countryNameOfficial), "Property is not nullable for class TimezoneLocation.");

            if (isEu.IsSet && isEu.Value == null)
                throw new ArgumentNullException(nameof(isEu), "Property is not nullable for class TimezoneLocation.");

            if (stateProv.IsSet && stateProv.Value == null)
                throw new ArgumentNullException(nameof(stateProv), "Property is not nullable for class TimezoneLocation.");

            if (stateCode.IsSet && stateCode.Value == null)
                throw new ArgumentNullException(nameof(stateCode), "Property is not nullable for class TimezoneLocation.");

            if (district.IsSet && district.Value == null)
                throw new ArgumentNullException(nameof(district), "Property is not nullable for class TimezoneLocation.");

            if (city.IsSet && city.Value == null)
                throw new ArgumentNullException(nameof(city), "Property is not nullable for class TimezoneLocation.");

            if (locality.IsSet && locality.Value == null)
                throw new ArgumentNullException(nameof(locality), "Property is not nullable for class TimezoneLocation.");

            if (zipcode.IsSet && zipcode.Value == null)
                throw new ArgumentNullException(nameof(zipcode), "Property is not nullable for class TimezoneLocation.");

            if (latitude.IsSet && latitude.Value == null)
                throw new ArgumentNullException(nameof(latitude), "Property is not nullable for class TimezoneLocation.");

            if (longitude.IsSet && longitude.Value == null)
                throw new ArgumentNullException(nameof(longitude), "Property is not nullable for class TimezoneLocation.");

            return new TimezoneLocation(locationString, continentCode, continentName, countryCode2, countryCode3, countryName, countryNameOfficial, isEu, stateProv, stateCode, district, city, locality, zipcode, latitude, longitude);
        }

        /// <summary>
        /// Serializes a <see cref="TimezoneLocation" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="timezoneLocation"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TimezoneLocation timezoneLocation, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, timezoneLocation, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TimezoneLocation" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="timezoneLocation"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TimezoneLocation timezoneLocation, JsonSerializerOptions jsonSerializerOptions)
        {
            if (timezoneLocation.LocationStringOption.IsSet && timezoneLocation.LocationString == null)
                throw new ArgumentNullException(nameof(timezoneLocation.LocationString), "Property is required for class TimezoneLocation.");

            if (timezoneLocation.ContinentCodeOption.IsSet && timezoneLocation.ContinentCode == null)
                throw new ArgumentNullException(nameof(timezoneLocation.ContinentCode), "Property is required for class TimezoneLocation.");

            if (timezoneLocation.ContinentNameOption.IsSet && timezoneLocation.ContinentName == null)
                throw new ArgumentNullException(nameof(timezoneLocation.ContinentName), "Property is required for class TimezoneLocation.");

            if (timezoneLocation.CountryCode2Option.IsSet && timezoneLocation.CountryCode2 == null)
                throw new ArgumentNullException(nameof(timezoneLocation.CountryCode2), "Property is required for class TimezoneLocation.");

            if (timezoneLocation.CountryCode3Option.IsSet && timezoneLocation.CountryCode3 == null)
                throw new ArgumentNullException(nameof(timezoneLocation.CountryCode3), "Property is required for class TimezoneLocation.");

            if (timezoneLocation.CountryNameOption.IsSet && timezoneLocation.CountryName == null)
                throw new ArgumentNullException(nameof(timezoneLocation.CountryName), "Property is required for class TimezoneLocation.");

            if (timezoneLocation.CountryNameOfficialOption.IsSet && timezoneLocation.CountryNameOfficial == null)
                throw new ArgumentNullException(nameof(timezoneLocation.CountryNameOfficial), "Property is required for class TimezoneLocation.");

            if (timezoneLocation.StateProvOption.IsSet && timezoneLocation.StateProv == null)
                throw new ArgumentNullException(nameof(timezoneLocation.StateProv), "Property is required for class TimezoneLocation.");

            if (timezoneLocation.StateCodeOption.IsSet && timezoneLocation.StateCode == null)
                throw new ArgumentNullException(nameof(timezoneLocation.StateCode), "Property is required for class TimezoneLocation.");

            if (timezoneLocation.DistrictOption.IsSet && timezoneLocation.District == null)
                throw new ArgumentNullException(nameof(timezoneLocation.District), "Property is required for class TimezoneLocation.");

            if (timezoneLocation.CityOption.IsSet && timezoneLocation.City == null)
                throw new ArgumentNullException(nameof(timezoneLocation.City), "Property is required for class TimezoneLocation.");

            if (timezoneLocation.LocalityOption.IsSet && timezoneLocation.Locality == null)
                throw new ArgumentNullException(nameof(timezoneLocation.Locality), "Property is required for class TimezoneLocation.");

            if (timezoneLocation.ZipcodeOption.IsSet && timezoneLocation.Zipcode == null)
                throw new ArgumentNullException(nameof(timezoneLocation.Zipcode), "Property is required for class TimezoneLocation.");

            if (timezoneLocation.LatitudeOption.IsSet && timezoneLocation.Latitude == null)
                throw new ArgumentNullException(nameof(timezoneLocation.Latitude), "Property is required for class TimezoneLocation.");

            if (timezoneLocation.LongitudeOption.IsSet && timezoneLocation.Longitude == null)
                throw new ArgumentNullException(nameof(timezoneLocation.Longitude), "Property is required for class TimezoneLocation.");

            if (timezoneLocation.LocationStringOption.IsSet)
                writer.WriteString("location_string", timezoneLocation.LocationString);

            if (timezoneLocation.ContinentCodeOption.IsSet)
                writer.WriteString("continent_code", timezoneLocation.ContinentCode);

            if (timezoneLocation.ContinentNameOption.IsSet)
                writer.WriteString("continent_name", timezoneLocation.ContinentName);

            if (timezoneLocation.CountryCode2Option.IsSet)
                writer.WriteString("country_code2", timezoneLocation.CountryCode2);

            if (timezoneLocation.CountryCode3Option.IsSet)
                writer.WriteString("country_code3", timezoneLocation.CountryCode3);

            if (timezoneLocation.CountryNameOption.IsSet)
                writer.WriteString("country_name", timezoneLocation.CountryName);

            if (timezoneLocation.CountryNameOfficialOption.IsSet)
                writer.WriteString("country_name_official", timezoneLocation.CountryNameOfficial);

            if (timezoneLocation.IsEuOption.IsSet)
                writer.WriteBoolean("is_eu", timezoneLocation.IsEuOption.Value!.Value);

            if (timezoneLocation.StateProvOption.IsSet)
                writer.WriteString("state_prov", timezoneLocation.StateProv);

            if (timezoneLocation.StateCodeOption.IsSet)
                writer.WriteString("state_code", timezoneLocation.StateCode);

            if (timezoneLocation.DistrictOption.IsSet)
                writer.WriteString("district", timezoneLocation.District);

            if (timezoneLocation.CityOption.IsSet)
                writer.WriteString("city", timezoneLocation.City);

            if (timezoneLocation.LocalityOption.IsSet)
                writer.WriteString("locality", timezoneLocation.Locality);

            if (timezoneLocation.ZipcodeOption.IsSet)
                writer.WriteString("zipcode", timezoneLocation.Zipcode);

            if (timezoneLocation.LatitudeOption.IsSet)
                writer.WriteString("latitude", timezoneLocation.Latitude);

            if (timezoneLocation.LongitudeOption.IsSet)
                writer.WriteString("longitude", timezoneLocation.Longitude);
        }
    }
}
