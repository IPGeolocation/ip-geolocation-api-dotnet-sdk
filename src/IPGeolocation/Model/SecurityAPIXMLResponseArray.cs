

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
    /// SecurityAPIXMLResponseArray
    /// </summary>
    public partial class SecurityAPIXMLResponseArray : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAPIXMLResponseArray" /> class.
        /// </summary>
        /// <param name="ip">ip</param>
        /// <param name="hostname">hostname</param>
        /// <param name="security">security</param>
        /// <param name="location">location</param>
        /// <param name="network">network</param>
        /// <param name="varTimeZone">varTimeZone</param>
        /// <param name="userAgent">userAgent</param>
        /// <param name="countryMetadata">countryMetadata</param>
        /// <param name="currency">currency</param>
        [JsonConstructor]
        public SecurityAPIXMLResponseArray(Option<string?> ip = default, Option<string?> hostname = default, Option<Security?> security = default, Option<LocationMinimal?> location = default, Option<NetworkMinimal?> network = default, Option<ModelTimeZone?> varTimeZone = default, Option<UserAgentData?> userAgent = default, Option<CountryMetadata?> countryMetadata = default, Option<Currency?> currency = default)
        {
            IpOption = ip;
            HostnameOption = hostname;
            SecurityOption = security;
            LocationOption = location;
            NetworkOption = network;
            VarTimeZoneOption = varTimeZone;
            UserAgentOption = userAgent;
            CountryMetadataOption = countryMetadata;
            CurrencyOption = currency;
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
        /* <example>195-154-221-54.rev.poneytelecom.eu</example> */
        [JsonPropertyName("hostname")]
        public string? Hostname { get { return this.HostnameOption; } set { this.HostnameOption = new Option<string?>(value); } }

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
        /// Used to track the state of Location
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<LocationMinimal?> LocationOption { get; private set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [JsonPropertyName("location")]
        public LocationMinimal? Location { get { return this.LocationOption; } set { this.LocationOption = new Option<LocationMinimal?>(value); } }

        /// <summary>
        /// Used to track the state of Network
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<NetworkMinimal?> NetworkOption { get; private set; }

        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [JsonPropertyName("network")]
        public NetworkMinimal? Network { get { return this.NetworkOption; } set { this.NetworkOption = new Option<NetworkMinimal?>(value); } }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SecurityAPIXMLResponseArray {\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  VarTimeZone: ").Append(VarTimeZone).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
            sb.Append("  CountryMetadata: ").Append(CountryMetadata).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
    /// A Json converter for type <see cref="SecurityAPIXMLResponseArray" />
    /// </summary>
    public class SecurityAPIXMLResponseArrayJsonConverter : JsonConverter<SecurityAPIXMLResponseArray>
    {
        /// <summary>
        /// Deserializes json to <see cref="SecurityAPIXMLResponseArray" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override SecurityAPIXMLResponseArray Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> ip = default;
            Option<string?> hostname = default;
            Option<Security?> security = default;
            Option<LocationMinimal?> location = default;
            Option<NetworkMinimal?> network = default;
            Option<ModelTimeZone?> varTimeZone = default;
            Option<UserAgentData?> userAgent = default;
            Option<CountryMetadata?> countryMetadata = default;
            Option<Currency?> currency = default;

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
                        case "security":
                            security = new Option<Security?>(JsonSerializer.Deserialize<Security>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "location":
                            location = new Option<LocationMinimal?>(JsonSerializer.Deserialize<LocationMinimal>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "network":
                            network = new Option<NetworkMinimal?>(JsonSerializer.Deserialize<NetworkMinimal>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "time_zone":
                            varTimeZone = new Option<ModelTimeZone?>(JsonSerializer.Deserialize<ModelTimeZone>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "user_agent":
                            userAgent = new Option<UserAgentData?>(JsonSerializer.Deserialize<UserAgentData>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "country_metadata":
                            countryMetadata = new Option<CountryMetadata?>(JsonSerializer.Deserialize<CountryMetadata>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "currency":
                            currency = new Option<Currency?>(JsonSerializer.Deserialize<Currency>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (ip.IsSet && ip.Value == null)
                throw new ArgumentNullException(nameof(ip), "Property is not nullable for class SecurityAPIXMLResponseArray.");

            if (hostname.IsSet && hostname.Value == null)
                throw new ArgumentNullException(nameof(hostname), "Property is not nullable for class SecurityAPIXMLResponseArray.");

            if (security.IsSet && security.Value == null)
                throw new ArgumentNullException(nameof(security), "Property is not nullable for class SecurityAPIXMLResponseArray.");

            if (location.IsSet && location.Value == null)
                throw new ArgumentNullException(nameof(location), "Property is not nullable for class SecurityAPIXMLResponseArray.");

            if (network.IsSet && network.Value == null)
                throw new ArgumentNullException(nameof(network), "Property is not nullable for class SecurityAPIXMLResponseArray.");

            if (varTimeZone.IsSet && varTimeZone.Value == null)
                throw new ArgumentNullException(nameof(varTimeZone), "Property is not nullable for class SecurityAPIXMLResponseArray.");

            if (userAgent.IsSet && userAgent.Value == null)
                throw new ArgumentNullException(nameof(userAgent), "Property is not nullable for class SecurityAPIXMLResponseArray.");

            if (countryMetadata.IsSet && countryMetadata.Value == null)
                throw new ArgumentNullException(nameof(countryMetadata), "Property is not nullable for class SecurityAPIXMLResponseArray.");

            if (currency.IsSet && currency.Value == null)
                throw new ArgumentNullException(nameof(currency), "Property is not nullable for class SecurityAPIXMLResponseArray.");

            return new SecurityAPIXMLResponseArray(ip, hostname, security, location, network, varTimeZone, userAgent, countryMetadata, currency);
        }

        /// <summary>
        /// Serializes a <see cref="SecurityAPIXMLResponseArray" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="securityAPIXMLResponseArray"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, SecurityAPIXMLResponseArray securityAPIXMLResponseArray, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, securityAPIXMLResponseArray, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="SecurityAPIXMLResponseArray" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="securityAPIXMLResponseArray"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, SecurityAPIXMLResponseArray securityAPIXMLResponseArray, JsonSerializerOptions jsonSerializerOptions)
        {
            if (securityAPIXMLResponseArray.IpOption.IsSet && securityAPIXMLResponseArray.Ip == null)
                throw new ArgumentNullException(nameof(securityAPIXMLResponseArray.Ip), "Property is required for class SecurityAPIXMLResponseArray.");

            if (securityAPIXMLResponseArray.HostnameOption.IsSet && securityAPIXMLResponseArray.Hostname == null)
                throw new ArgumentNullException(nameof(securityAPIXMLResponseArray.Hostname), "Property is required for class SecurityAPIXMLResponseArray.");

            if (securityAPIXMLResponseArray.SecurityOption.IsSet && securityAPIXMLResponseArray.Security == null)
                throw new ArgumentNullException(nameof(securityAPIXMLResponseArray.Security), "Property is required for class SecurityAPIXMLResponseArray.");

            if (securityAPIXMLResponseArray.LocationOption.IsSet && securityAPIXMLResponseArray.Location == null)
                throw new ArgumentNullException(nameof(securityAPIXMLResponseArray.Location), "Property is required for class SecurityAPIXMLResponseArray.");

            if (securityAPIXMLResponseArray.NetworkOption.IsSet && securityAPIXMLResponseArray.Network == null)
                throw new ArgumentNullException(nameof(securityAPIXMLResponseArray.Network), "Property is required for class SecurityAPIXMLResponseArray.");

            if (securityAPIXMLResponseArray.VarTimeZoneOption.IsSet && securityAPIXMLResponseArray.VarTimeZone == null)
                throw new ArgumentNullException(nameof(securityAPIXMLResponseArray.VarTimeZone), "Property is required for class SecurityAPIXMLResponseArray.");

            if (securityAPIXMLResponseArray.UserAgentOption.IsSet && securityAPIXMLResponseArray.UserAgent == null)
                throw new ArgumentNullException(nameof(securityAPIXMLResponseArray.UserAgent), "Property is required for class SecurityAPIXMLResponseArray.");

            if (securityAPIXMLResponseArray.CountryMetadataOption.IsSet && securityAPIXMLResponseArray.CountryMetadata == null)
                throw new ArgumentNullException(nameof(securityAPIXMLResponseArray.CountryMetadata), "Property is required for class SecurityAPIXMLResponseArray.");

            if (securityAPIXMLResponseArray.CurrencyOption.IsSet && securityAPIXMLResponseArray.Currency == null)
                throw new ArgumentNullException(nameof(securityAPIXMLResponseArray.Currency), "Property is required for class SecurityAPIXMLResponseArray.");

            if (securityAPIXMLResponseArray.IpOption.IsSet)
                writer.WriteString("ip", securityAPIXMLResponseArray.Ip);

            if (securityAPIXMLResponseArray.HostnameOption.IsSet)
                writer.WriteString("hostname", securityAPIXMLResponseArray.Hostname);

            if (securityAPIXMLResponseArray.SecurityOption.IsSet)
            {
                writer.WritePropertyName("security");
                JsonSerializer.Serialize(writer, securityAPIXMLResponseArray.Security, jsonSerializerOptions);
            }
            if (securityAPIXMLResponseArray.LocationOption.IsSet)
            {
                writer.WritePropertyName("location");
                JsonSerializer.Serialize(writer, securityAPIXMLResponseArray.Location, jsonSerializerOptions);
            }
            if (securityAPIXMLResponseArray.NetworkOption.IsSet)
            {
                writer.WritePropertyName("network");
                JsonSerializer.Serialize(writer, securityAPIXMLResponseArray.Network, jsonSerializerOptions);
            }
            if (securityAPIXMLResponseArray.VarTimeZoneOption.IsSet)
            {
                writer.WritePropertyName("time_zone");
                JsonSerializer.Serialize(writer, securityAPIXMLResponseArray.VarTimeZone, jsonSerializerOptions);
            }
            if (securityAPIXMLResponseArray.UserAgentOption.IsSet)
            {
                writer.WritePropertyName("user_agent");
                JsonSerializer.Serialize(writer, securityAPIXMLResponseArray.UserAgent, jsonSerializerOptions);
            }
            if (securityAPIXMLResponseArray.CountryMetadataOption.IsSet)
            {
                writer.WritePropertyName("country_metadata");
                JsonSerializer.Serialize(writer, securityAPIXMLResponseArray.CountryMetadata, jsonSerializerOptions);
            }
            if (securityAPIXMLResponseArray.CurrencyOption.IsSet)
            {
                writer.WritePropertyName("currency");
                JsonSerializer.Serialize(writer, securityAPIXMLResponseArray.Currency, jsonSerializerOptions);
            }
        }
    }
}
