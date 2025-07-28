

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
    /// LocationMinimal
    /// </summary>
    public partial class LocationMinimal : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationMinimal" /> class.
        /// </summary>
        /// <param name="continentCode">continentCode</param>
        /// <param name="continentName">continentName</param>
        /// <param name="countryCode2">countryCode2</param>
        /// <param name="countryCode3">countryCode3</param>
        /// <param name="countryName">countryName</param>
        /// <param name="countryNameOfficial">countryNameOfficial</param>
        /// <param name="countryCapital">countryCapital</param>
        /// <param name="stateProv">stateProv</param>
        /// <param name="stateCode">stateCode</param>
        /// <param name="district">district</param>
        /// <param name="city">city</param>
        /// <param name="zipcode">zipcode</param>
        /// <param name="latitude">latitude</param>
        /// <param name="longitude">longitude</param>
        /// <param name="isEu">isEu</param>
        /// <param name="countryFlag">countryFlag</param>
        /// <param name="geonameId">geonameId</param>
        /// <param name="countryEmoji">countryEmoji</param>
        [JsonConstructor]
        public LocationMinimal(Option<string?> continentCode = default, Option<string?> continentName = default, Option<string?> countryCode2 = default, Option<string?> countryCode3 = default, Option<string?> countryName = default, Option<string?> countryNameOfficial = default, Option<string?> countryCapital = default, Option<string?> stateProv = default, Option<string?> stateCode = default, Option<string?> district = default, Option<string?> city = default, Option<string?> zipcode = default, Option<string?> latitude = default, Option<string?> longitude = default, Option<bool?> isEu = default, Option<string?> countryFlag = default, Option<string?> geonameId = default, Option<string?> countryEmoji = default)
        {
            ContinentCodeOption = continentCode;
            ContinentNameOption = continentName;
            CountryCode2Option = countryCode2;
            CountryCode3Option = countryCode3;
            CountryNameOption = countryName;
            CountryNameOfficialOption = countryNameOfficial;
            CountryCapitalOption = countryCapital;
            StateProvOption = stateProv;
            StateCodeOption = stateCode;
            DistrictOption = district;
            CityOption = city;
            ZipcodeOption = zipcode;
            LatitudeOption = latitude;
            LongitudeOption = longitude;
            IsEuOption = isEu;
            CountryFlagOption = countryFlag;
            GeonameIdOption = geonameId;
            CountryEmojiOption = countryEmoji;
            OnCreated();
        }

        partial void OnCreated();

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
        /// Used to track the state of ContinentName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ContinentNameOption { get; private set; }

        /// <summary>
        /// Gets or Sets ContinentName
        /// </summary>
        /* <example>North America</example> */
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
        /* <example>US</example> */
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
        /* <example>USA</example> */
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
        /* <example>United States</example> */
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
        /* <example>United States of America</example> */
        [JsonPropertyName("country_name_official")]
        public string? CountryNameOfficial { get { return this.CountryNameOfficialOption; } set { this.CountryNameOfficialOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of CountryCapital
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CountryCapitalOption { get; private set; }

        /// <summary>
        /// Gets or Sets CountryCapital
        /// </summary>
        /* <example>Washington, D.C.</example> */
        [JsonPropertyName("country_capital")]
        public string? CountryCapital { get { return this.CountryCapitalOption; } set { this.CountryCapitalOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of StateProv
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> StateProvOption { get; private set; }

        /// <summary>
        /// Gets or Sets StateProv
        /// </summary>
        /* <example>California</example> */
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
        /* <example>US-CA</example> */
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
        /* <example>Santa Clara</example> */
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
        /* <example>Mountain View</example> */
        [JsonPropertyName("city")]
        public string? City { get { return this.CityOption; } set { this.CityOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Zipcode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ZipcodeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Zipcode
        /// </summary>
        /* <example>94043-1351</example> */
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
        /* <example>37.42240</example> */
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
        /* <example>-122.08421</example> */
        [JsonPropertyName("longitude")]
        public string? Longitude { get { return this.LongitudeOption; } set { this.LongitudeOption = new Option<string?>(value); } }

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
        /// Used to track the state of CountryFlag
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CountryFlagOption { get; private set; }

        /// <summary>
        /// Gets or Sets CountryFlag
        /// </summary>
        /* <example>https://ipgeolocation.io/static/flags/us_64.png</example> */
        [JsonPropertyName("country_flag")]
        public string? CountryFlag { get { return this.CountryFlagOption; } set { this.CountryFlagOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of GeonameId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> GeonameIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets GeonameId
        /// </summary>
        /* <example>6301403</example> */
        [JsonPropertyName("geoname_id")]
        public string? GeonameId { get { return this.GeonameIdOption; } set { this.GeonameIdOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of CountryEmoji
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CountryEmojiOption { get; private set; }

        /// <summary>
        /// Gets or Sets CountryEmoji
        /// </summary>
        [JsonPropertyName("country_emoji")]
        public string? CountryEmoji { get { return this.CountryEmojiOption; } set { this.CountryEmojiOption = new Option<string?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LocationMinimal {\n");
            sb.Append("  ContinentCode: ").Append(ContinentCode).Append("\n");
            sb.Append("  ContinentName: ").Append(ContinentName).Append("\n");
            sb.Append("  CountryCode2: ").Append(CountryCode2).Append("\n");
            sb.Append("  CountryCode3: ").Append(CountryCode3).Append("\n");
            sb.Append("  CountryName: ").Append(CountryName).Append("\n");
            sb.Append("  CountryNameOfficial: ").Append(CountryNameOfficial).Append("\n");
            sb.Append("  CountryCapital: ").Append(CountryCapital).Append("\n");
            sb.Append("  StateProv: ").Append(StateProv).Append("\n");
            sb.Append("  StateCode: ").Append(StateCode).Append("\n");
            sb.Append("  District: ").Append(District).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Zipcode: ").Append(Zipcode).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  IsEu: ").Append(IsEu).Append("\n");
            sb.Append("  CountryFlag: ").Append(CountryFlag).Append("\n");
            sb.Append("  GeonameId: ").Append(GeonameId).Append("\n");
            sb.Append("  CountryEmoji: ").Append(CountryEmoji).Append("\n");
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
    /// A Json converter for type <see cref="LocationMinimal" />
    /// </summary>
    public class LocationMinimalJsonConverter : JsonConverter<LocationMinimal>
    {
        /// <summary>
        /// Deserializes json to <see cref="LocationMinimal" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override LocationMinimal Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> continentCode = default;
            Option<string?> continentName = default;
            Option<string?> countryCode2 = default;
            Option<string?> countryCode3 = default;
            Option<string?> countryName = default;
            Option<string?> countryNameOfficial = default;
            Option<string?> countryCapital = default;
            Option<string?> stateProv = default;
            Option<string?> stateCode = default;
            Option<string?> district = default;
            Option<string?> city = default;
            Option<string?> zipcode = default;
            Option<string?> latitude = default;
            Option<string?> longitude = default;
            Option<bool?> isEu = default;
            Option<string?> countryFlag = default;
            Option<string?> geonameId = default;
            Option<string?> countryEmoji = default;

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
                        case "country_capital":
                            countryCapital = new Option<string?>(utf8JsonReader.GetString()!);
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
                        case "zipcode":
                            zipcode = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "latitude":
                            latitude = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "longitude":
                            longitude = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "is_eu":
                            isEu = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "country_flag":
                            countryFlag = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "geoname_id":
                            geonameId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "country_emoji":
                            countryEmoji = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (continentCode.IsSet && continentCode.Value == null)
                throw new ArgumentNullException(nameof(continentCode), "Property is not nullable for class LocationMinimal.");

            if (continentName.IsSet && continentName.Value == null)
                throw new ArgumentNullException(nameof(continentName), "Property is not nullable for class LocationMinimal.");

            if (countryCode2.IsSet && countryCode2.Value == null)
                throw new ArgumentNullException(nameof(countryCode2), "Property is not nullable for class LocationMinimal.");

            if (countryCode3.IsSet && countryCode3.Value == null)
                throw new ArgumentNullException(nameof(countryCode3), "Property is not nullable for class LocationMinimal.");

            if (countryName.IsSet && countryName.Value == null)
                throw new ArgumentNullException(nameof(countryName), "Property is not nullable for class LocationMinimal.");

            if (countryNameOfficial.IsSet && countryNameOfficial.Value == null)
                throw new ArgumentNullException(nameof(countryNameOfficial), "Property is not nullable for class LocationMinimal.");

            if (countryCapital.IsSet && countryCapital.Value == null)
                throw new ArgumentNullException(nameof(countryCapital), "Property is not nullable for class LocationMinimal.");

            if (stateProv.IsSet && stateProv.Value == null)
                throw new ArgumentNullException(nameof(stateProv), "Property is not nullable for class LocationMinimal.");

            if (stateCode.IsSet && stateCode.Value == null)
                throw new ArgumentNullException(nameof(stateCode), "Property is not nullable for class LocationMinimal.");

            if (district.IsSet && district.Value == null)
                throw new ArgumentNullException(nameof(district), "Property is not nullable for class LocationMinimal.");

            if (city.IsSet && city.Value == null)
                throw new ArgumentNullException(nameof(city), "Property is not nullable for class LocationMinimal.");

            if (zipcode.IsSet && zipcode.Value == null)
                throw new ArgumentNullException(nameof(zipcode), "Property is not nullable for class LocationMinimal.");

            if (latitude.IsSet && latitude.Value == null)
                throw new ArgumentNullException(nameof(latitude), "Property is not nullable for class LocationMinimal.");

            if (longitude.IsSet && longitude.Value == null)
                throw new ArgumentNullException(nameof(longitude), "Property is not nullable for class LocationMinimal.");

            if (isEu.IsSet && isEu.Value == null)
                throw new ArgumentNullException(nameof(isEu), "Property is not nullable for class LocationMinimal.");

            if (countryFlag.IsSet && countryFlag.Value == null)
                throw new ArgumentNullException(nameof(countryFlag), "Property is not nullable for class LocationMinimal.");

            if (geonameId.IsSet && geonameId.Value == null)
                throw new ArgumentNullException(nameof(geonameId), "Property is not nullable for class LocationMinimal.");

            if (countryEmoji.IsSet && countryEmoji.Value == null)
                throw new ArgumentNullException(nameof(countryEmoji), "Property is not nullable for class LocationMinimal.");

            return new LocationMinimal(continentCode, continentName, countryCode2, countryCode3, countryName, countryNameOfficial, countryCapital, stateProv, stateCode, district, city, zipcode, latitude, longitude, isEu, countryFlag, geonameId, countryEmoji);
        }

        /// <summary>
        /// Serializes a <see cref="LocationMinimal" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="locationMinimal"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, LocationMinimal locationMinimal, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, locationMinimal, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="LocationMinimal" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="locationMinimal"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, LocationMinimal locationMinimal, JsonSerializerOptions jsonSerializerOptions)
        {
            if (locationMinimal.ContinentCodeOption.IsSet && locationMinimal.ContinentCode == null)
                throw new ArgumentNullException(nameof(locationMinimal.ContinentCode), "Property is required for class LocationMinimal.");

            if (locationMinimal.ContinentNameOption.IsSet && locationMinimal.ContinentName == null)
                throw new ArgumentNullException(nameof(locationMinimal.ContinentName), "Property is required for class LocationMinimal.");

            if (locationMinimal.CountryCode2Option.IsSet && locationMinimal.CountryCode2 == null)
                throw new ArgumentNullException(nameof(locationMinimal.CountryCode2), "Property is required for class LocationMinimal.");

            if (locationMinimal.CountryCode3Option.IsSet && locationMinimal.CountryCode3 == null)
                throw new ArgumentNullException(nameof(locationMinimal.CountryCode3), "Property is required for class LocationMinimal.");

            if (locationMinimal.CountryNameOption.IsSet && locationMinimal.CountryName == null)
                throw new ArgumentNullException(nameof(locationMinimal.CountryName), "Property is required for class LocationMinimal.");

            if (locationMinimal.CountryNameOfficialOption.IsSet && locationMinimal.CountryNameOfficial == null)
                throw new ArgumentNullException(nameof(locationMinimal.CountryNameOfficial), "Property is required for class LocationMinimal.");

            if (locationMinimal.CountryCapitalOption.IsSet && locationMinimal.CountryCapital == null)
                throw new ArgumentNullException(nameof(locationMinimal.CountryCapital), "Property is required for class LocationMinimal.");

            if (locationMinimal.StateProvOption.IsSet && locationMinimal.StateProv == null)
                throw new ArgumentNullException(nameof(locationMinimal.StateProv), "Property is required for class LocationMinimal.");

            if (locationMinimal.StateCodeOption.IsSet && locationMinimal.StateCode == null)
                throw new ArgumentNullException(nameof(locationMinimal.StateCode), "Property is required for class LocationMinimal.");

            if (locationMinimal.DistrictOption.IsSet && locationMinimal.District == null)
                throw new ArgumentNullException(nameof(locationMinimal.District), "Property is required for class LocationMinimal.");

            if (locationMinimal.CityOption.IsSet && locationMinimal.City == null)
                throw new ArgumentNullException(nameof(locationMinimal.City), "Property is required for class LocationMinimal.");

            if (locationMinimal.ZipcodeOption.IsSet && locationMinimal.Zipcode == null)
                throw new ArgumentNullException(nameof(locationMinimal.Zipcode), "Property is required for class LocationMinimal.");

            if (locationMinimal.LatitudeOption.IsSet && locationMinimal.Latitude == null)
                throw new ArgumentNullException(nameof(locationMinimal.Latitude), "Property is required for class LocationMinimal.");

            if (locationMinimal.LongitudeOption.IsSet && locationMinimal.Longitude == null)
                throw new ArgumentNullException(nameof(locationMinimal.Longitude), "Property is required for class LocationMinimal.");

            if (locationMinimal.CountryFlagOption.IsSet && locationMinimal.CountryFlag == null)
                throw new ArgumentNullException(nameof(locationMinimal.CountryFlag), "Property is required for class LocationMinimal.");

            if (locationMinimal.GeonameIdOption.IsSet && locationMinimal.GeonameId == null)
                throw new ArgumentNullException(nameof(locationMinimal.GeonameId), "Property is required for class LocationMinimal.");

            if (locationMinimal.CountryEmojiOption.IsSet && locationMinimal.CountryEmoji == null)
                throw new ArgumentNullException(nameof(locationMinimal.CountryEmoji), "Property is required for class LocationMinimal.");

            if (locationMinimal.ContinentCodeOption.IsSet)
                writer.WriteString("continent_code", locationMinimal.ContinentCode);

            if (locationMinimal.ContinentNameOption.IsSet)
                writer.WriteString("continent_name", locationMinimal.ContinentName);

            if (locationMinimal.CountryCode2Option.IsSet)
                writer.WriteString("country_code2", locationMinimal.CountryCode2);

            if (locationMinimal.CountryCode3Option.IsSet)
                writer.WriteString("country_code3", locationMinimal.CountryCode3);

            if (locationMinimal.CountryNameOption.IsSet)
                writer.WriteString("country_name", locationMinimal.CountryName);

            if (locationMinimal.CountryNameOfficialOption.IsSet)
                writer.WriteString("country_name_official", locationMinimal.CountryNameOfficial);

            if (locationMinimal.CountryCapitalOption.IsSet)
                writer.WriteString("country_capital", locationMinimal.CountryCapital);

            if (locationMinimal.StateProvOption.IsSet)
                writer.WriteString("state_prov", locationMinimal.StateProv);

            if (locationMinimal.StateCodeOption.IsSet)
                writer.WriteString("state_code", locationMinimal.StateCode);

            if (locationMinimal.DistrictOption.IsSet)
                writer.WriteString("district", locationMinimal.District);

            if (locationMinimal.CityOption.IsSet)
                writer.WriteString("city", locationMinimal.City);

            if (locationMinimal.ZipcodeOption.IsSet)
                writer.WriteString("zipcode", locationMinimal.Zipcode);

            if (locationMinimal.LatitudeOption.IsSet)
                writer.WriteString("latitude", locationMinimal.Latitude);

            if (locationMinimal.LongitudeOption.IsSet)
                writer.WriteString("longitude", locationMinimal.Longitude);

            if (locationMinimal.IsEuOption.IsSet)
                writer.WriteBoolean("is_eu", locationMinimal.IsEuOption.Value!.Value);

            if (locationMinimal.CountryFlagOption.IsSet)
                writer.WriteString("country_flag", locationMinimal.CountryFlag);

            if (locationMinimal.GeonameIdOption.IsSet)
                writer.WriteString("geoname_id", locationMinimal.GeonameId);

            if (locationMinimal.CountryEmojiOption.IsSet)
                writer.WriteString("country_emoji", locationMinimal.CountryEmoji);
        }
    }
}
