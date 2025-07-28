

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
    /// GeolocationXMLResponseArray
    /// </summary>
    public partial class GeolocationXMLResponseArray : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeolocationXMLResponseArray" /> class.
        /// </summary>
        /// <param name="ip">ip</param>
        /// <param name="hostname">hostname</param>
        /// <param name="domain">domain</param>
        /// <param name="location">location</param>
        /// <param name="countryMetadata">countryMetadata</param>
        /// <param name="network">network</param>
        /// <param name="currency">currency</param>
        /// <param name="security">security</param>
        /// <param name="abuse">abuse</param>
        /// <param name="varTimeZone">varTimeZone</param>
        /// <param name="userAgent">userAgent</param>
        [JsonConstructor]
        public GeolocationXMLResponseArray(Option<string?> ip = default, Option<string?> hostname = default, Option<string?> domain = default, Option<Location?> location = default, Option<CountryMetadata?> countryMetadata = default, Option<Network?> network = default, Option<Currency?> currency = default, Option<Security?> security = default, Option<Abuse?> abuse = default, Option<ModelTimeZone?> varTimeZone = default, Option<UserAgentData?> userAgent = default)
        {
            IpOption = ip;
            HostnameOption = hostname;
            DomainOption = domain;
            LocationOption = location;
            CountryMetadataOption = countryMetadata;
            NetworkOption = network;
            CurrencyOption = currency;
            SecurityOption = security;
            AbuseOption = abuse;
            VarTimeZoneOption = varTimeZone;
            UserAgentOption = userAgent;
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
        /// Used to track the state of Hostname
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> HostnameOption { get; private set; }

        /// <summary>
        /// Gets or Sets Hostname
        /// </summary>
        /* <example>dns.google</example> */
        [JsonPropertyName("hostname")]
        public string? Hostname { get { return this.HostnameOption; } set { this.HostnameOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Domain
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DomainOption { get; private set; }

        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        /* <example>google.com</example> */
        [JsonPropertyName("domain")]
        public string? Domain { get { return this.DomainOption; } set { this.DomainOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Location
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Location?> LocationOption { get; private set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [JsonPropertyName("location")]
        public Location? Location { get { return this.LocationOption; } set { this.LocationOption = new Option<Location?>(value); } }

        /// <summary>
        /// Used to track the state of CountryMetadata
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<CountryMetadata?> CountryMetadataOption { get; private set; }

        /// <summary>
        /// Gets or Sets CountryMetadata
        /// </summary>
        [JsonPropertyName("country_metadata")]
        public CountryMetadata? CountryMetadata { get { return this.CountryMetadataOption; } set { this.CountryMetadataOption = new Option<CountryMetadata?>(value); } }

        /// <summary>
        /// Used to track the state of Network
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Network?> NetworkOption { get; private set; }

        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [JsonPropertyName("network")]
        public Network? Network { get { return this.NetworkOption; } set { this.NetworkOption = new Option<Network?>(value); } }

        /// <summary>
        /// Used to track the state of Currency
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Currency?> CurrencyOption { get; private set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [JsonPropertyName("currency")]
        public Currency? Currency { get { return this.CurrencyOption; } set { this.CurrencyOption = new Option<Currency?>(value); } }

        /// <summary>
        /// Used to track the state of Security
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Security?> SecurityOption { get; private set; }

        /// <summary>
        /// Gets or Sets Security
        /// </summary>
        [JsonPropertyName("security")]
        public Security? Security { get { return this.SecurityOption; } set { this.SecurityOption = new Option<Security?>(value); } }

        /// <summary>
        /// Used to track the state of Abuse
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Abuse?> AbuseOption { get; private set; }

        /// <summary>
        /// Gets or Sets Abuse
        /// </summary>
        [JsonPropertyName("abuse")]
        public Abuse? Abuse { get { return this.AbuseOption; } set { this.AbuseOption = new Option<Abuse?>(value); } }

        /// <summary>
        /// Used to track the state of VarTimeZone
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<ModelTimeZone?> VarTimeZoneOption { get; private set; }

        /// <summary>
        /// Gets or Sets VarTimeZone
        /// </summary>
        [JsonPropertyName("time_zone")]
        public ModelTimeZone? VarTimeZone { get { return this.VarTimeZoneOption; } set { this.VarTimeZoneOption = new Option<ModelTimeZone?>(value); } }

        /// <summary>
        /// Used to track the state of UserAgent
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<UserAgentData?> UserAgentOption { get; private set; }

        /// <summary>
        /// Gets or Sets UserAgent
        /// </summary>
        [JsonPropertyName("user_agent")]
        public UserAgentData? UserAgent { get { return this.UserAgentOption; } set { this.UserAgentOption = new Option<UserAgentData?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GeolocationXMLResponseArray {\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  CountryMetadata: ").Append(CountryMetadata).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
            sb.Append("  Abuse: ").Append(Abuse).Append("\n");
            sb.Append("  VarTimeZone: ").Append(VarTimeZone).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
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
    /// A Json converter for type <see cref="GeolocationXMLResponseArray" />
    /// </summary>
    public class GeolocationXMLResponseArrayJsonConverter : JsonConverter<GeolocationXMLResponseArray>
    {
        /// <summary>
        /// Deserializes json to <see cref="GeolocationXMLResponseArray" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GeolocationXMLResponseArray Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> ip = default;
            Option<string?> hostname = default;
            Option<string?> domain = default;
            Option<Location?> location = default;
            Option<CountryMetadata?> countryMetadata = default;
            Option<Network?> network = default;
            Option<Currency?> currency = default;
            Option<Security?> security = default;
            Option<Abuse?> abuse = default;
            Option<ModelTimeZone?> varTimeZone = default;
            Option<UserAgentData?> userAgent = default;

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
                        case "hostname":
                            hostname = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "domain":
                            domain = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "location":
                            location = new Option<Location?>(JsonSerializer.Deserialize<Location>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "country_metadata":
                            countryMetadata = new Option<CountryMetadata?>(JsonSerializer.Deserialize<CountryMetadata>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "network":
                            network = new Option<Network?>(JsonSerializer.Deserialize<Network>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "currency":
                            currency = new Option<Currency?>(JsonSerializer.Deserialize<Currency>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "security":
                            security = new Option<Security?>(JsonSerializer.Deserialize<Security>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "abuse":
                            abuse = new Option<Abuse?>(JsonSerializer.Deserialize<Abuse>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "time_zone":
                            varTimeZone = new Option<ModelTimeZone?>(JsonSerializer.Deserialize<ModelTimeZone>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "user_agent":
                            userAgent = new Option<UserAgentData?>(JsonSerializer.Deserialize<UserAgentData>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (ip.IsSet && ip.Value == null)
                throw new ArgumentNullException(nameof(ip), "Property is not nullable for class GeolocationXMLResponseArray.");

            if (hostname.IsSet && hostname.Value == null)
                throw new ArgumentNullException(nameof(hostname), "Property is not nullable for class GeolocationXMLResponseArray.");

            if (domain.IsSet && domain.Value == null)
                throw new ArgumentNullException(nameof(domain), "Property is not nullable for class GeolocationXMLResponseArray.");

            if (location.IsSet && location.Value == null)
                throw new ArgumentNullException(nameof(location), "Property is not nullable for class GeolocationXMLResponseArray.");

            if (countryMetadata.IsSet && countryMetadata.Value == null)
                throw new ArgumentNullException(nameof(countryMetadata), "Property is not nullable for class GeolocationXMLResponseArray.");

            if (network.IsSet && network.Value == null)
                throw new ArgumentNullException(nameof(network), "Property is not nullable for class GeolocationXMLResponseArray.");

            if (currency.IsSet && currency.Value == null)
                throw new ArgumentNullException(nameof(currency), "Property is not nullable for class GeolocationXMLResponseArray.");

            if (security.IsSet && security.Value == null)
                throw new ArgumentNullException(nameof(security), "Property is not nullable for class GeolocationXMLResponseArray.");

            if (abuse.IsSet && abuse.Value == null)
                throw new ArgumentNullException(nameof(abuse), "Property is not nullable for class GeolocationXMLResponseArray.");

            if (varTimeZone.IsSet && varTimeZone.Value == null)
                throw new ArgumentNullException(nameof(varTimeZone), "Property is not nullable for class GeolocationXMLResponseArray.");

            if (userAgent.IsSet && userAgent.Value == null)
                throw new ArgumentNullException(nameof(userAgent), "Property is not nullable for class GeolocationXMLResponseArray.");

            return new GeolocationXMLResponseArray(ip, hostname, domain, location, countryMetadata, network, currency, security, abuse, varTimeZone, userAgent);
        }

        /// <summary>
        /// Serializes a <see cref="GeolocationXMLResponseArray" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="geolocationXMLResponseArray"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GeolocationXMLResponseArray geolocationXMLResponseArray, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, geolocationXMLResponseArray, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GeolocationXMLResponseArray" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="geolocationXMLResponseArray"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GeolocationXMLResponseArray geolocationXMLResponseArray, JsonSerializerOptions jsonSerializerOptions)
        {
            if (geolocationXMLResponseArray.IpOption.IsSet && geolocationXMLResponseArray.Ip == null)
                throw new ArgumentNullException(nameof(geolocationXMLResponseArray.Ip), "Property is required for class GeolocationXMLResponseArray.");

            if (geolocationXMLResponseArray.HostnameOption.IsSet && geolocationXMLResponseArray.Hostname == null)
                throw new ArgumentNullException(nameof(geolocationXMLResponseArray.Hostname), "Property is required for class GeolocationXMLResponseArray.");

            if (geolocationXMLResponseArray.DomainOption.IsSet && geolocationXMLResponseArray.Domain == null)
                throw new ArgumentNullException(nameof(geolocationXMLResponseArray.Domain), "Property is required for class GeolocationXMLResponseArray.");

            if (geolocationXMLResponseArray.LocationOption.IsSet && geolocationXMLResponseArray.Location == null)
                throw new ArgumentNullException(nameof(geolocationXMLResponseArray.Location), "Property is required for class GeolocationXMLResponseArray.");

            if (geolocationXMLResponseArray.CountryMetadataOption.IsSet && geolocationXMLResponseArray.CountryMetadata == null)
                throw new ArgumentNullException(nameof(geolocationXMLResponseArray.CountryMetadata), "Property is required for class GeolocationXMLResponseArray.");

            if (geolocationXMLResponseArray.NetworkOption.IsSet && geolocationXMLResponseArray.Network == null)
                throw new ArgumentNullException(nameof(geolocationXMLResponseArray.Network), "Property is required for class GeolocationXMLResponseArray.");

            if (geolocationXMLResponseArray.CurrencyOption.IsSet && geolocationXMLResponseArray.Currency == null)
                throw new ArgumentNullException(nameof(geolocationXMLResponseArray.Currency), "Property is required for class GeolocationXMLResponseArray.");

            if (geolocationXMLResponseArray.SecurityOption.IsSet && geolocationXMLResponseArray.Security == null)
                throw new ArgumentNullException(nameof(geolocationXMLResponseArray.Security), "Property is required for class GeolocationXMLResponseArray.");

            if (geolocationXMLResponseArray.AbuseOption.IsSet && geolocationXMLResponseArray.Abuse == null)
                throw new ArgumentNullException(nameof(geolocationXMLResponseArray.Abuse), "Property is required for class GeolocationXMLResponseArray.");

            if (geolocationXMLResponseArray.VarTimeZoneOption.IsSet && geolocationXMLResponseArray.VarTimeZone == null)
                throw new ArgumentNullException(nameof(geolocationXMLResponseArray.VarTimeZone), "Property is required for class GeolocationXMLResponseArray.");

            if (geolocationXMLResponseArray.UserAgentOption.IsSet && geolocationXMLResponseArray.UserAgent == null)
                throw new ArgumentNullException(nameof(geolocationXMLResponseArray.UserAgent), "Property is required for class GeolocationXMLResponseArray.");

            if (geolocationXMLResponseArray.IpOption.IsSet)
                writer.WriteString("ip", geolocationXMLResponseArray.Ip);

            if (geolocationXMLResponseArray.HostnameOption.IsSet)
                writer.WriteString("hostname", geolocationXMLResponseArray.Hostname);

            if (geolocationXMLResponseArray.DomainOption.IsSet)
                writer.WriteString("domain", geolocationXMLResponseArray.Domain);

            if (geolocationXMLResponseArray.LocationOption.IsSet)
            {
                writer.WritePropertyName("location");
                JsonSerializer.Serialize(writer, geolocationXMLResponseArray.Location, jsonSerializerOptions);
            }
            if (geolocationXMLResponseArray.CountryMetadataOption.IsSet)
            {
                writer.WritePropertyName("country_metadata");
                JsonSerializer.Serialize(writer, geolocationXMLResponseArray.CountryMetadata, jsonSerializerOptions);
            }
            if (geolocationXMLResponseArray.NetworkOption.IsSet)
            {
                writer.WritePropertyName("network");
                JsonSerializer.Serialize(writer, geolocationXMLResponseArray.Network, jsonSerializerOptions);
            }
            if (geolocationXMLResponseArray.CurrencyOption.IsSet)
            {
                writer.WritePropertyName("currency");
                JsonSerializer.Serialize(writer, geolocationXMLResponseArray.Currency, jsonSerializerOptions);
            }
            if (geolocationXMLResponseArray.SecurityOption.IsSet)
            {
                writer.WritePropertyName("security");
                JsonSerializer.Serialize(writer, geolocationXMLResponseArray.Security, jsonSerializerOptions);
            }
            if (geolocationXMLResponseArray.AbuseOption.IsSet)
            {
                writer.WritePropertyName("abuse");
                JsonSerializer.Serialize(writer, geolocationXMLResponseArray.Abuse, jsonSerializerOptions);
            }
            if (geolocationXMLResponseArray.VarTimeZoneOption.IsSet)
            {
                writer.WritePropertyName("time_zone");
                JsonSerializer.Serialize(writer, geolocationXMLResponseArray.VarTimeZone, jsonSerializerOptions);
            }
            if (geolocationXMLResponseArray.UserAgentOption.IsSet)
            {
                writer.WritePropertyName("user_agent");
                JsonSerializer.Serialize(writer, geolocationXMLResponseArray.UserAgent, jsonSerializerOptions);
            }
        }
    }
}
