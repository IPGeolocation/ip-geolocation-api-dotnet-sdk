

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
    /// Security
    /// </summary>
    public partial class Security : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Security" /> class.
        /// </summary>
        /// <param name="threatScore">threatScore</param>
        /// <param name="isTor">isTor</param>
        /// <param name="isProxy">isProxy</param>
        /// <param name="proxyType">proxyType</param>
        /// <param name="proxyProvider">proxyProvider</param>
        /// <param name="isAnonymous">isAnonymous</param>
        /// <param name="isKnownAttacker">isKnownAttacker</param>
        /// <param name="isSpam">isSpam</param>
        /// <param name="isBot">isBot</param>
        /// <param name="isCloudProvider">isCloudProvider</param>
        /// <param name="cloudProvider">cloudProvider</param>
        [JsonConstructor]
        public Security(Option<int?> threatScore = default, Option<bool?> isTor = default, Option<bool?> isProxy = default, Option<string?> proxyType = default, Option<string?> proxyProvider = default, Option<bool?> isAnonymous = default, Option<bool?> isKnownAttacker = default, Option<bool?> isSpam = default, Option<bool?> isBot = default, Option<bool?> isCloudProvider = default, Option<string?> cloudProvider = default)
        {
            ThreatScoreOption = threatScore;
            IsTorOption = isTor;
            IsProxyOption = isProxy;
            ProxyTypeOption = proxyType;
            ProxyProviderOption = proxyProvider;
            IsAnonymousOption = isAnonymous;
            IsKnownAttackerOption = isKnownAttacker;
            IsSpamOption = isSpam;
            IsBotOption = isBot;
            IsCloudProviderOption = isCloudProvider;
            CloudProviderOption = cloudProvider;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of ThreatScore
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> ThreatScoreOption { get; private set; }

        /// <summary>
        /// Gets or Sets ThreatScore
        /// </summary>
        /* <example>80</example> */
        [JsonPropertyName("threat_score")]
        public int? ThreatScore { get { return this.ThreatScoreOption; } set { this.ThreatScoreOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of IsTor
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsTorOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsTor
        /// </summary>
        /* <example>false</example> */
        [JsonPropertyName("is_tor")]
        public bool? IsTor { get { return this.IsTorOption; } set { this.IsTorOption = new Option<bool?>(value); } }

        /// <summary>
        /// Used to track the state of IsProxy
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsProxyOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsProxy
        /// </summary>
        /* <example>true</example> */
        [JsonPropertyName("is_proxy")]
        public bool? IsProxy { get { return this.IsProxyOption; } set { this.IsProxyOption = new Option<bool?>(value); } }

        /// <summary>
        /// Used to track the state of ProxyType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ProxyTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets ProxyType
        /// </summary>
        /* <example>VPN</example> */
        [JsonPropertyName("proxy_type")]
        public string? ProxyType { get { return this.ProxyTypeOption; } set { this.ProxyTypeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of ProxyProvider
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ProxyProviderOption { get; private set; }

        /// <summary>
        /// Gets or Sets ProxyProvider
        /// </summary>
        [JsonPropertyName("proxy_provider")]
        public string? ProxyProvider { get { return this.ProxyProviderOption; } set { this.ProxyProviderOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of IsAnonymous
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsAnonymousOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsAnonymous
        /// </summary>
        /* <example>true</example> */
        [JsonPropertyName("is_anonymous")]
        public bool? IsAnonymous { get { return this.IsAnonymousOption; } set { this.IsAnonymousOption = new Option<bool?>(value); } }

        /// <summary>
        /// Used to track the state of IsKnownAttacker
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsKnownAttackerOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsKnownAttacker
        /// </summary>
        /* <example>true</example> */
        [JsonPropertyName("is_known_attacker")]
        public bool? IsKnownAttacker { get { return this.IsKnownAttackerOption; } set { this.IsKnownAttackerOption = new Option<bool?>(value); } }

        /// <summary>
        /// Used to track the state of IsSpam
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsSpamOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsSpam
        /// </summary>
        /* <example>false</example> */
        [JsonPropertyName("is_spam")]
        public bool? IsSpam { get { return this.IsSpamOption; } set { this.IsSpamOption = new Option<bool?>(value); } }

        /// <summary>
        /// Used to track the state of IsBot
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsBotOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsBot
        /// </summary>
        /* <example>false</example> */
        [JsonPropertyName("is_bot")]
        public bool? IsBot { get { return this.IsBotOption; } set { this.IsBotOption = new Option<bool?>(value); } }

        /// <summary>
        /// Used to track the state of IsCloudProvider
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsCloudProviderOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsCloudProvider
        /// </summary>
        /* <example>false</example> */
        [JsonPropertyName("is_cloud_provider")]
        public bool? IsCloudProvider { get { return this.IsCloudProviderOption; } set { this.IsCloudProviderOption = new Option<bool?>(value); } }

        /// <summary>
        /// Used to track the state of CloudProvider
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CloudProviderOption { get; private set; }

        /// <summary>
        /// Gets or Sets CloudProvider
        /// </summary>
        [JsonPropertyName("cloud_provider")]
        public string? CloudProvider { get { return this.CloudProviderOption; } set { this.CloudProviderOption = new Option<string?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Security {\n");
            sb.Append("  ThreatScore: ").Append(ThreatScore).Append("\n");
            sb.Append("  IsTor: ").Append(IsTor).Append("\n");
            sb.Append("  IsProxy: ").Append(IsProxy).Append("\n");
            sb.Append("  ProxyType: ").Append(ProxyType).Append("\n");
            sb.Append("  ProxyProvider: ").Append(ProxyProvider).Append("\n");
            sb.Append("  IsAnonymous: ").Append(IsAnonymous).Append("\n");
            sb.Append("  IsKnownAttacker: ").Append(IsKnownAttacker).Append("\n");
            sb.Append("  IsSpam: ").Append(IsSpam).Append("\n");
            sb.Append("  IsBot: ").Append(IsBot).Append("\n");
            sb.Append("  IsCloudProvider: ").Append(IsCloudProvider).Append("\n");
            sb.Append("  CloudProvider: ").Append(CloudProvider).Append("\n");
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
    /// A Json converter for type <see cref="Security" />
    /// </summary>
    public class SecurityJsonConverter : JsonConverter<Security>
    {
        /// <summary>
        /// Deserializes json to <see cref="Security" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Security Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> threatScore = default;
            Option<bool?> isTor = default;
            Option<bool?> isProxy = default;
            Option<string?> proxyType = default;
            Option<string?> proxyProvider = default;
            Option<bool?> isAnonymous = default;
            Option<bool?> isKnownAttacker = default;
            Option<bool?> isSpam = default;
            Option<bool?> isBot = default;
            Option<bool?> isCloudProvider = default;
            Option<string?> cloudProvider = default;

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
                        case "threat_score":
                            threatScore = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "is_tor":
                            isTor = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "is_proxy":
                            isProxy = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "proxy_type":
                            proxyType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "proxy_provider":
                            proxyProvider = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "is_anonymous":
                            isAnonymous = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "is_known_attacker":
                            isKnownAttacker = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "is_spam":
                            isSpam = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "is_bot":
                            isBot = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "is_cloud_provider":
                            isCloudProvider = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "cloud_provider":
                            cloudProvider = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (threatScore.IsSet && threatScore.Value == null)
                throw new ArgumentNullException(nameof(threatScore), "Property is not nullable for class Security.");

            if (isTor.IsSet && isTor.Value == null)
                throw new ArgumentNullException(nameof(isTor), "Property is not nullable for class Security.");

            if (isProxy.IsSet && isProxy.Value == null)
                throw new ArgumentNullException(nameof(isProxy), "Property is not nullable for class Security.");

            if (proxyType.IsSet && proxyType.Value == null)
                throw new ArgumentNullException(nameof(proxyType), "Property is not nullable for class Security.");

            if (proxyProvider.IsSet && proxyProvider.Value == null)
                throw new ArgumentNullException(nameof(proxyProvider), "Property is not nullable for class Security.");

            if (isAnonymous.IsSet && isAnonymous.Value == null)
                throw new ArgumentNullException(nameof(isAnonymous), "Property is not nullable for class Security.");

            if (isKnownAttacker.IsSet && isKnownAttacker.Value == null)
                throw new ArgumentNullException(nameof(isKnownAttacker), "Property is not nullable for class Security.");

            if (isSpam.IsSet && isSpam.Value == null)
                throw new ArgumentNullException(nameof(isSpam), "Property is not nullable for class Security.");

            if (isBot.IsSet && isBot.Value == null)
                throw new ArgumentNullException(nameof(isBot), "Property is not nullable for class Security.");

            if (isCloudProvider.IsSet && isCloudProvider.Value == null)
                throw new ArgumentNullException(nameof(isCloudProvider), "Property is not nullable for class Security.");

            if (cloudProvider.IsSet && cloudProvider.Value == null)
                throw new ArgumentNullException(nameof(cloudProvider), "Property is not nullable for class Security.");

            return new Security(threatScore, isTor, isProxy, proxyType, proxyProvider, isAnonymous, isKnownAttacker, isSpam, isBot, isCloudProvider, cloudProvider);
        }

        /// <summary>
        /// Serializes a <see cref="Security" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="security"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Security security, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, security, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Security" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="security"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Security security, JsonSerializerOptions jsonSerializerOptions)
        {
            if (security.ProxyTypeOption.IsSet && security.ProxyType == null)
                throw new ArgumentNullException(nameof(security.ProxyType), "Property is required for class Security.");

            if (security.ProxyProviderOption.IsSet && security.ProxyProvider == null)
                throw new ArgumentNullException(nameof(security.ProxyProvider), "Property is required for class Security.");

            if (security.CloudProviderOption.IsSet && security.CloudProvider == null)
                throw new ArgumentNullException(nameof(security.CloudProvider), "Property is required for class Security.");

            if (security.ThreatScoreOption.IsSet)
                writer.WriteNumber("threat_score", security.ThreatScoreOption.Value!.Value);

            if (security.IsTorOption.IsSet)
                writer.WriteBoolean("is_tor", security.IsTorOption.Value!.Value);

            if (security.IsProxyOption.IsSet)
                writer.WriteBoolean("is_proxy", security.IsProxyOption.Value!.Value);

            if (security.ProxyTypeOption.IsSet)
                writer.WriteString("proxy_type", security.ProxyType);

            if (security.ProxyProviderOption.IsSet)
                writer.WriteString("proxy_provider", security.ProxyProvider);

            if (security.IsAnonymousOption.IsSet)
                writer.WriteBoolean("is_anonymous", security.IsAnonymousOption.Value!.Value);

            if (security.IsKnownAttackerOption.IsSet)
                writer.WriteBoolean("is_known_attacker", security.IsKnownAttackerOption.Value!.Value);

            if (security.IsSpamOption.IsSet)
                writer.WriteBoolean("is_spam", security.IsSpamOption.Value!.Value);

            if (security.IsBotOption.IsSet)
                writer.WriteBoolean("is_bot", security.IsBotOption.Value!.Value);

            if (security.IsCloudProviderOption.IsSet)
                writer.WriteBoolean("is_cloud_provider", security.IsCloudProviderOption.Value!.Value);

            if (security.CloudProviderOption.IsSet)
                writer.WriteString("cloud_provider", security.CloudProvider);
        }
    }
}
