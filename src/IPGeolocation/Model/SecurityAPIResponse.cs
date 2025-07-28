

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
    /// SecurityAPIResponse
    /// </summary>
    public partial class SecurityAPIResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAPIResponse" /> class.
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
        public SecurityAPIResponse(Option<string?> ip = default, Option<string?> hostname = default, Option<Security?> security = default, Option<LocationMinimal?> location = default, Option<NetworkMinimal?> network = default, Option<ModelTimeZone?> varTimeZone = default, Option<UserAgentData?> userAgent = default, Option<CountryMetadata?> countryMetadata = default, Option<Currency?> currency = default)
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
            sb.Append("class SecurityAPIResponse {\n");
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
    /// A Json converter for type <see cref="SecurityAPIResponse" />
    /// </summary>
    public class SecurityAPIResponseJsonConverter : JsonConverter<SecurityAPIResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="SecurityAPIResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override SecurityAPIResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
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
                throw new ArgumentNullException(nameof(ip), "Property is not nullable for class SecurityAPIResponse.");

            if (hostname.IsSet && hostname.Value == null)
                throw new ArgumentNullException(nameof(hostname), "Property is not nullable for class SecurityAPIResponse.");

            if (security.IsSet && security.Value == null)
                throw new ArgumentNullException(nameof(security), "Property is not nullable for class SecurityAPIResponse.");

            if (location.IsSet && location.Value == null)
                throw new ArgumentNullException(nameof(location), "Property is not nullable for class SecurityAPIResponse.");

            if (network.IsSet && network.Value == null)
                throw new ArgumentNullException(nameof(network), "Property is not nullable for class SecurityAPIResponse.");

            if (varTimeZone.IsSet && varTimeZone.Value == null)
                throw new ArgumentNullException(nameof(varTimeZone), "Property is not nullable for class SecurityAPIResponse.");

            if (userAgent.IsSet && userAgent.Value == null)
                throw new ArgumentNullException(nameof(userAgent), "Property is not nullable for class SecurityAPIResponse.");

            if (countryMetadata.IsSet && countryMetadata.Value == null)
                throw new ArgumentNullException(nameof(countryMetadata), "Property is not nullable for class SecurityAPIResponse.");

            if (currency.IsSet && currency.Value == null)
                throw new ArgumentNullException(nameof(currency), "Property is not nullable for class SecurityAPIResponse.");

            return new SecurityAPIResponse(ip, hostname, security, location, network, varTimeZone, userAgent, countryMetadata, currency);
        }

        /// <summary>
        /// Serializes a <see cref="SecurityAPIResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="securityAPIResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, SecurityAPIResponse securityAPIResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, securityAPIResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="SecurityAPIResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="securityAPIResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, SecurityAPIResponse securityAPIResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (securityAPIResponse.IpOption.IsSet && securityAPIResponse.Ip == null)
                throw new ArgumentNullException(nameof(securityAPIResponse.Ip), "Property is required for class SecurityAPIResponse.");

            if (securityAPIResponse.HostnameOption.IsSet && securityAPIResponse.Hostname == null)
                throw new ArgumentNullException(nameof(securityAPIResponse.Hostname), "Property is required for class SecurityAPIResponse.");

            if (securityAPIResponse.SecurityOption.IsSet && securityAPIResponse.Security == null)
                throw new ArgumentNullException(nameof(securityAPIResponse.Security), "Property is required for class SecurityAPIResponse.");

            if (securityAPIResponse.LocationOption.IsSet && securityAPIResponse.Location == null)
                throw new ArgumentNullException(nameof(securityAPIResponse.Location), "Property is required for class SecurityAPIResponse.");

            if (securityAPIResponse.NetworkOption.IsSet && securityAPIResponse.Network == null)
                throw new ArgumentNullException(nameof(securityAPIResponse.Network), "Property is required for class SecurityAPIResponse.");

            if (securityAPIResponse.VarTimeZoneOption.IsSet && securityAPIResponse.VarTimeZone == null)
                throw new ArgumentNullException(nameof(securityAPIResponse.VarTimeZone), "Property is required for class SecurityAPIResponse.");

            if (securityAPIResponse.UserAgentOption.IsSet && securityAPIResponse.UserAgent == null)
                throw new ArgumentNullException(nameof(securityAPIResponse.UserAgent), "Property is required for class SecurityAPIResponse.");

            if (securityAPIResponse.CountryMetadataOption.IsSet && securityAPIResponse.CountryMetadata == null)
                throw new ArgumentNullException(nameof(securityAPIResponse.CountryMetadata), "Property is required for class SecurityAPIResponse.");

            if (securityAPIResponse.CurrencyOption.IsSet && securityAPIResponse.Currency == null)
                throw new ArgumentNullException(nameof(securityAPIResponse.Currency), "Property is required for class SecurityAPIResponse.");

            if (securityAPIResponse.IpOption.IsSet)
                writer.WriteString("ip", securityAPIResponse.Ip);

            if (securityAPIResponse.HostnameOption.IsSet)
                writer.WriteString("hostname", securityAPIResponse.Hostname);

            if (securityAPIResponse.SecurityOption.IsSet)
            {
                writer.WritePropertyName("security");
                JsonSerializer.Serialize(writer, securityAPIResponse.Security, jsonSerializerOptions);
            }
            if (securityAPIResponse.LocationOption.IsSet)
            {
                writer.WritePropertyName("location");
                JsonSerializer.Serialize(writer, securityAPIResponse.Location, jsonSerializerOptions);
            }
            if (securityAPIResponse.NetworkOption.IsSet)
            {
                writer.WritePropertyName("network");
                JsonSerializer.Serialize(writer, securityAPIResponse.Network, jsonSerializerOptions);
            }
            if (securityAPIResponse.VarTimeZoneOption.IsSet)
            {
                writer.WritePropertyName("time_zone");
                JsonSerializer.Serialize(writer, securityAPIResponse.VarTimeZone, jsonSerializerOptions);
            }
            if (securityAPIResponse.UserAgentOption.IsSet)
            {
                writer.WritePropertyName("user_agent");
                JsonSerializer.Serialize(writer, securityAPIResponse.UserAgent, jsonSerializerOptions);
            }
            if (securityAPIResponse.CountryMetadataOption.IsSet)
            {
                writer.WritePropertyName("country_metadata");
                JsonSerializer.Serialize(writer, securityAPIResponse.CountryMetadata, jsonSerializerOptions);
            }
            if (securityAPIResponse.CurrencyOption.IsSet)
            {
                writer.WritePropertyName("currency");
                JsonSerializer.Serialize(writer, securityAPIResponse.Currency, jsonSerializerOptions);
            }
        }
    }
}
