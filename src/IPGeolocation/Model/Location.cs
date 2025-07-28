

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
    /// Location
    /// </summary>
    public partial class Location : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
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
        /// <param name="accuracyRadius">accuracyRadius</param>
        /// <param name="locality">locality</param>
        /// <param name="dmaCode">dmaCode</param>
        [JsonConstructor]
        public Location(Option<string?> continentCode = default, Option<string?> continentName = default, Option<string?> countryCode2 = default, Option<string?> countryCode3 = default, Option<string?> countryName = default, Option<string?> countryNameOfficial = default, Option<string?> countryCapital = default, Option<string?> stateProv = default, Option<string?> stateCode = default, Option<string?> district = default, Option<string?> city = default, Option<string?> zipcode = default, Option<string?> latitude = default, Option<string?> longitude = default, Option<bool?> isEu = default, Option<string?> countryFlag = default, Option<string?> geonameId = default, Option<string?> countryEmoji = default, Option<string?> accuracyRadius = default, Option<string?> locality = default, Option<string?> dmaCode = default)
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
            AccuracyRadiusOption = accuracyRadius;
            LocalityOption = locality;
            DmaCodeOption = dmaCode;
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
        /// Used to track the state of AccuracyRadius
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> AccuracyRadiusOption { get; private set; }

        /// <summary>
        /// Gets or Sets AccuracyRadius
        /// </summary>
        /* <example>1000</example> */
        [JsonPropertyName("accuracy_radius")]
        public string? AccuracyRadius { get { return this.AccuracyRadiusOption; } set { this.AccuracyRadiusOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Locality
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> LocalityOption { get; private set; }

        /// <summary>
        /// Gets or Sets Locality
        /// </summary>
        /* <example>Mountain View</example> */
        [JsonPropertyName("locality")]
        public string? Locality { get { return this.LocalityOption; } set { this.LocalityOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of DmaCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DmaCodeOption { get; private set; }

        /// <summary>
        /// Gets or Sets DmaCode
        /// </summary>
        /* <example>807</example> */
        [JsonPropertyName("dma_code")]
        public string? DmaCode { get { return this.DmaCodeOption; } set { this.DmaCodeOption = new Option<string?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Location {\n");
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
            sb.Append("  AccuracyRadius: ").Append(AccuracyRadius).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  DmaCode: ").Append(DmaCode).Append("\n");
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
    /// A Json converter for type <see cref="Location" />
    /// </summary>
    public class LocationJsonConverter : JsonConverter<Location>
    {
        /// <summary>
        /// Deserializes json to <see cref="Location" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Location Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
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
            Option<string?> accuracyRadius = default;
            Option<string?> locality = default;
            Option<string?> dmaCode = default;

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
                        case "accuracy_radius":
                            accuracyRadius = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "locality":
                            locality = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "dma_code":
                            dmaCode = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (continentCode.IsSet && continentCode.Value == null)
                throw new ArgumentNullException(nameof(continentCode), "Property is not nullable for class Location.");

            if (continentName.IsSet && continentName.Value == null)
                throw new ArgumentNullException(nameof(continentName), "Property is not nullable for class Location.");

            if (countryCode2.IsSet && countryCode2.Value == null)
                throw new ArgumentNullException(nameof(countryCode2), "Property is not nullable for class Location.");

            if (countryCode3.IsSet && countryCode3.Value == null)
                throw new ArgumentNullException(nameof(countryCode3), "Property is not nullable for class Location.");

            if (countryName.IsSet && countryName.Value == null)
                throw new ArgumentNullException(nameof(countryName), "Property is not nullable for class Location.");

            if (countryNameOfficial.IsSet && countryNameOfficial.Value == null)
                throw new ArgumentNullException(nameof(countryNameOfficial), "Property is not nullable for class Location.");

            if (countryCapital.IsSet && countryCapital.Value == null)
                throw new ArgumentNullException(nameof(countryCapital), "Property is not nullable for class Location.");

            if (stateProv.IsSet && stateProv.Value == null)
                throw new ArgumentNullException(nameof(stateProv), "Property is not nullable for class Location.");

            if (stateCode.IsSet && stateCode.Value == null)
                throw new ArgumentNullException(nameof(stateCode), "Property is not nullable for class Location.");

            if (district.IsSet && district.Value == null)
                throw new ArgumentNullException(nameof(district), "Property is not nullable for class Location.");

            if (city.IsSet && city.Value == null)
                throw new ArgumentNullException(nameof(city), "Property is not nullable for class Location.");

            if (zipcode.IsSet && zipcode.Value == null)
                throw new ArgumentNullException(nameof(zipcode), "Property is not nullable for class Location.");

            if (latitude.IsSet && latitude.Value == null)
                throw new ArgumentNullException(nameof(latitude), "Property is not nullable for class Location.");

            if (longitude.IsSet && longitude.Value == null)
                throw new ArgumentNullException(nameof(longitude), "Property is not nullable for class Location.");

            if (isEu.IsSet && isEu.Value == null)
                throw new ArgumentNullException(nameof(isEu), "Property is not nullable for class Location.");

            if (countryFlag.IsSet && countryFlag.Value == null)
                throw new ArgumentNullException(nameof(countryFlag), "Property is not nullable for class Location.");

            if (geonameId.IsSet && geonameId.Value == null)
                throw new ArgumentNullException(nameof(geonameId), "Property is not nullable for class Location.");

            if (countryEmoji.IsSet && countryEmoji.Value == null)
                throw new ArgumentNullException(nameof(countryEmoji), "Property is not nullable for class Location.");

            if (accuracyRadius.IsSet && accuracyRadius.Value == null)
                throw new ArgumentNullException(nameof(accuracyRadius), "Property is not nullable for class Location.");

            if (locality.IsSet && locality.Value == null)
                throw new ArgumentNullException(nameof(locality), "Property is not nullable for class Location.");

            if (dmaCode.IsSet && dmaCode.Value == null)
                throw new ArgumentNullException(nameof(dmaCode), "Property is not nullable for class Location.");

            return new Location(continentCode, continentName, countryCode2, countryCode3, countryName, countryNameOfficial, countryCapital, stateProv, stateCode, district, city, zipcode, latitude, longitude, isEu, countryFlag, geonameId, countryEmoji, accuracyRadius, locality, dmaCode);
        }

        /// <summary>
        /// Serializes a <see cref="Location" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="location"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Location location, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, location, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Location" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="location"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Location location, JsonSerializerOptions jsonSerializerOptions)
        {
            if (location.ContinentCodeOption.IsSet && location.ContinentCode == null)
                throw new ArgumentNullException(nameof(location.ContinentCode), "Property is required for class Location.");

            if (location.ContinentNameOption.IsSet && location.ContinentName == null)
                throw new ArgumentNullException(nameof(location.ContinentName), "Property is required for class Location.");

            if (location.CountryCode2Option.IsSet && location.CountryCode2 == null)
                throw new ArgumentNullException(nameof(location.CountryCode2), "Property is required for class Location.");

            if (location.CountryCode3Option.IsSet && location.CountryCode3 == null)
                throw new ArgumentNullException(nameof(location.CountryCode3), "Property is required for class Location.");

            if (location.CountryNameOption.IsSet && location.CountryName == null)
                throw new ArgumentNullException(nameof(location.CountryName), "Property is required for class Location.");

            if (location.CountryNameOfficialOption.IsSet && location.CountryNameOfficial == null)
                throw new ArgumentNullException(nameof(location.CountryNameOfficial), "Property is required for class Location.");

            if (location.CountryCapitalOption.IsSet && location.CountryCapital == null)
                throw new ArgumentNullException(nameof(location.CountryCapital), "Property is required for class Location.");

            if (location.StateProvOption.IsSet && location.StateProv == null)
                throw new ArgumentNullException(nameof(location.StateProv), "Property is required for class Location.");

            if (location.StateCodeOption.IsSet && location.StateCode == null)
                throw new ArgumentNullException(nameof(location.StateCode), "Property is required for class Location.");

            if (location.DistrictOption.IsSet && location.District == null)
                throw new ArgumentNullException(nameof(location.District), "Property is required for class Location.");

            if (location.CityOption.IsSet && location.City == null)
                throw new ArgumentNullException(nameof(location.City), "Property is required for class Location.");

            if (location.ZipcodeOption.IsSet && location.Zipcode == null)
                throw new ArgumentNullException(nameof(location.Zipcode), "Property is required for class Location.");

            if (location.LatitudeOption.IsSet && location.Latitude == null)
                throw new ArgumentNullException(nameof(location.Latitude), "Property is required for class Location.");

            if (location.LongitudeOption.IsSet && location.Longitude == null)
                throw new ArgumentNullException(nameof(location.Longitude), "Property is required for class Location.");

            if (location.CountryFlagOption.IsSet && location.CountryFlag == null)
                throw new ArgumentNullException(nameof(location.CountryFlag), "Property is required for class Location.");

            if (location.GeonameIdOption.IsSet && location.GeonameId == null)
                throw new ArgumentNullException(nameof(location.GeonameId), "Property is required for class Location.");

            if (location.CountryEmojiOption.IsSet && location.CountryEmoji == null)
                throw new ArgumentNullException(nameof(location.CountryEmoji), "Property is required for class Location.");

            if (location.AccuracyRadiusOption.IsSet && location.AccuracyRadius == null)
                throw new ArgumentNullException(nameof(location.AccuracyRadius), "Property is required for class Location.");

            if (location.LocalityOption.IsSet && location.Locality == null)
                throw new ArgumentNullException(nameof(location.Locality), "Property is required for class Location.");

            if (location.DmaCodeOption.IsSet && location.DmaCode == null)
                throw new ArgumentNullException(nameof(location.DmaCode), "Property is required for class Location.");

            if (location.ContinentCodeOption.IsSet)
                writer.WriteString("continent_code", location.ContinentCode);

            if (location.ContinentNameOption.IsSet)
                writer.WriteString("continent_name", location.ContinentName);

            if (location.CountryCode2Option.IsSet)
                writer.WriteString("country_code2", location.CountryCode2);

            if (location.CountryCode3Option.IsSet)
                writer.WriteString("country_code3", location.CountryCode3);

            if (location.CountryNameOption.IsSet)
                writer.WriteString("country_name", location.CountryName);

            if (location.CountryNameOfficialOption.IsSet)
                writer.WriteString("country_name_official", location.CountryNameOfficial);

            if (location.CountryCapitalOption.IsSet)
                writer.WriteString("country_capital", location.CountryCapital);

            if (location.StateProvOption.IsSet)
                writer.WriteString("state_prov", location.StateProv);

            if (location.StateCodeOption.IsSet)
                writer.WriteString("state_code", location.StateCode);

            if (location.DistrictOption.IsSet)
                writer.WriteString("district", location.District);

            if (location.CityOption.IsSet)
                writer.WriteString("city", location.City);

            if (location.ZipcodeOption.IsSet)
                writer.WriteString("zipcode", location.Zipcode);

            if (location.LatitudeOption.IsSet)
                writer.WriteString("latitude", location.Latitude);

            if (location.LongitudeOption.IsSet)
                writer.WriteString("longitude", location.Longitude);

            if (location.IsEuOption.IsSet)
                writer.WriteBoolean("is_eu", location.IsEuOption.Value!.Value);

            if (location.CountryFlagOption.IsSet)
                writer.WriteString("country_flag", location.CountryFlag);

            if (location.GeonameIdOption.IsSet)
                writer.WriteString("geoname_id", location.GeonameId);

            if (location.CountryEmojiOption.IsSet)
                writer.WriteString("country_emoji", location.CountryEmoji);

            if (location.AccuracyRadiusOption.IsSet)
                writer.WriteString("accuracy_radius", location.AccuracyRadius);

            if (location.LocalityOption.IsSet)
                writer.WriteString("locality", location.Locality);

            if (location.DmaCodeOption.IsSet)
                writer.WriteString("dma_code", location.DmaCode);
        }
    }
}
