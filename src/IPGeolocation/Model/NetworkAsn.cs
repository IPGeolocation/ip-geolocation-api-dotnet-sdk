

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
    /// NetworkAsn
    /// </summary>
    public partial class NetworkAsn : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkAsn" /> class.
        /// </summary>
        /// <param name="asNumber">asNumber</param>
        /// <param name="organization">organization</param>
        /// <param name="country">country</param>
        /// <param name="asnName">asnName</param>
        /// <param name="type">type</param>
        /// <param name="domain">domain</param>
        /// <param name="dateAllocated">dateAllocated</param>
        /// <param name="allocationStatus">allocationStatus</param>
        /// <param name="numOfIpv4Routes">numOfIpv4Routes</param>
        /// <param name="numOfIpv6Routes">numOfIpv6Routes</param>
        /// <param name="rir">rir</param>
        [JsonConstructor]
        public NetworkAsn(Option<string?> asNumber = default, Option<string?> organization = default, Option<string?> country = default, Option<string?> asnName = default, Option<string?> type = default, Option<string?> domain = default, Option<string?> dateAllocated = default, Option<string?> allocationStatus = default, Option<string?> numOfIpv4Routes = default, Option<string?> numOfIpv6Routes = default, Option<string?> rir = default)
        {
            AsNumberOption = asNumber;
            OrganizationOption = organization;
            CountryOption = country;
            AsnNameOption = asnName;
            TypeOption = type;
            DomainOption = domain;
            DateAllocatedOption = dateAllocated;
            AllocationStatusOption = allocationStatus;
            NumOfIpv4RoutesOption = numOfIpv4Routes;
            NumOfIpv6RoutesOption = numOfIpv6Routes;
            RirOption = rir;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of AsNumber
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> AsNumberOption { get; private set; }

        /// <summary>
        /// Gets or Sets AsNumber
        /// </summary>
        /* <example>AS15169</example> */
        [JsonPropertyName("as_number")]
        public string? AsNumber { get { return this.AsNumberOption; } set { this.AsNumberOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Organization
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> OrganizationOption { get; private set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        /* <example>Google LLC</example> */
        [JsonPropertyName("organization")]
        public string? Organization { get { return this.OrganizationOption; } set { this.OrganizationOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Country
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CountryOption { get; private set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        /* <example>US</example> */
        [JsonPropertyName("country")]
        public string? Country { get { return this.CountryOption; } set { this.CountryOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of AsnName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> AsnNameOption { get; private set; }

        /// <summary>
        /// Gets or Sets AsnName
        /// </summary>
        /* <example>GOOGLE</example> */
        [JsonPropertyName("asn_name")]
        public string? AsnName { get { return this.AsnNameOption; } set { this.AsnNameOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Type
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /* <example>isp</example> */
        [JsonPropertyName("type")]
        public string? Type { get { return this.TypeOption; } set { this.TypeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Domain
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DomainOption { get; private set; }

        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        /* <example>about.google</example> */
        [JsonPropertyName("domain")]
        public string? Domain { get { return this.DomainOption; } set { this.DomainOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of DateAllocated
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DateAllocatedOption { get; private set; }

        /// <summary>
        /// Gets or Sets DateAllocated
        /// </summary>
        [JsonPropertyName("date_allocated")]
        public string? DateAllocated { get { return this.DateAllocatedOption; } set { this.DateAllocatedOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of AllocationStatus
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> AllocationStatusOption { get; private set; }

        /// <summary>
        /// Gets or Sets AllocationStatus
        /// </summary>
        /* <example>Assigned</example> */
        [JsonPropertyName("allocation_status")]
        public string? AllocationStatus { get { return this.AllocationStatusOption; } set { this.AllocationStatusOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of NumOfIpv4Routes
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NumOfIpv4RoutesOption { get; private set; }

        /// <summary>
        /// Gets or Sets NumOfIpv4Routes
        /// </summary>
        /* <example>1099</example> */
        [JsonPropertyName("num_of_ipv4_routes")]
        public string? NumOfIpv4Routes { get { return this.NumOfIpv4RoutesOption; } set { this.NumOfIpv4RoutesOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of NumOfIpv6Routes
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NumOfIpv6RoutesOption { get; private set; }

        /// <summary>
        /// Gets or Sets NumOfIpv6Routes
        /// </summary>
        /* <example>107</example> */
        [JsonPropertyName("num_of_ipv6_routes")]
        public string? NumOfIpv6Routes { get { return this.NumOfIpv6RoutesOption; } set { this.NumOfIpv6RoutesOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Rir
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> RirOption { get; private set; }

        /// <summary>
        /// Gets or Sets Rir
        /// </summary>
        /* <example>ARIN</example> */
        [JsonPropertyName("rir")]
        public string? Rir { get { return this.RirOption; } set { this.RirOption = new Option<string?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NetworkAsn {\n");
            sb.Append("  AsNumber: ").Append(AsNumber).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  AsnName: ").Append(AsnName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  DateAllocated: ").Append(DateAllocated).Append("\n");
            sb.Append("  AllocationStatus: ").Append(AllocationStatus).Append("\n");
            sb.Append("  NumOfIpv4Routes: ").Append(NumOfIpv4Routes).Append("\n");
            sb.Append("  NumOfIpv6Routes: ").Append(NumOfIpv6Routes).Append("\n");
            sb.Append("  Rir: ").Append(Rir).Append("\n");
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
    /// A Json converter for type <see cref="NetworkAsn" />
    /// </summary>
    public class NetworkAsnJsonConverter : JsonConverter<NetworkAsn>
    {
        /// <summary>
        /// Deserializes json to <see cref="NetworkAsn" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override NetworkAsn Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> asNumber = default;
            Option<string?> organization = default;
            Option<string?> country = default;
            Option<string?> asnName = default;
            Option<string?> type = default;
            Option<string?> domain = default;
            Option<string?> dateAllocated = default;
            Option<string?> allocationStatus = default;
            Option<string?> numOfIpv4Routes = default;
            Option<string?> numOfIpv6Routes = default;
            Option<string?> rir = default;

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
                        case "as_number":
                            asNumber = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "organization":
                            organization = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "country":
                            country = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "asn_name":
                            asnName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "type":
                            type = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "domain":
                            domain = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "date_allocated":
                            dateAllocated = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "allocation_status":
                            allocationStatus = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "num_of_ipv4_routes":
                            numOfIpv4Routes = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "num_of_ipv6_routes":
                            numOfIpv6Routes = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "rir":
                            rir = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (asNumber.IsSet && asNumber.Value == null)
                throw new ArgumentNullException(nameof(asNumber), "Property is not nullable for class NetworkAsn.");

            if (organization.IsSet && organization.Value == null)
                throw new ArgumentNullException(nameof(organization), "Property is not nullable for class NetworkAsn.");

            if (country.IsSet && country.Value == null)
                throw new ArgumentNullException(nameof(country), "Property is not nullable for class NetworkAsn.");

            if (asnName.IsSet && asnName.Value == null)
                throw new ArgumentNullException(nameof(asnName), "Property is not nullable for class NetworkAsn.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class NetworkAsn.");

            if (domain.IsSet && domain.Value == null)
                throw new ArgumentNullException(nameof(domain), "Property is not nullable for class NetworkAsn.");

            if (dateAllocated.IsSet && dateAllocated.Value == null)
                throw new ArgumentNullException(nameof(dateAllocated), "Property is not nullable for class NetworkAsn.");

            if (allocationStatus.IsSet && allocationStatus.Value == null)
                throw new ArgumentNullException(nameof(allocationStatus), "Property is not nullable for class NetworkAsn.");

            if (numOfIpv4Routes.IsSet && numOfIpv4Routes.Value == null)
                throw new ArgumentNullException(nameof(numOfIpv4Routes), "Property is not nullable for class NetworkAsn.");

            if (numOfIpv6Routes.IsSet && numOfIpv6Routes.Value == null)
                throw new ArgumentNullException(nameof(numOfIpv6Routes), "Property is not nullable for class NetworkAsn.");

            if (rir.IsSet && rir.Value == null)
                throw new ArgumentNullException(nameof(rir), "Property is not nullable for class NetworkAsn.");

            return new NetworkAsn(asNumber, organization, country, asnName, type, domain, dateAllocated, allocationStatus, numOfIpv4Routes, numOfIpv6Routes, rir);
        }

        /// <summary>
        /// Serializes a <see cref="NetworkAsn" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="networkAsn"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, NetworkAsn networkAsn, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, networkAsn, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="NetworkAsn" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="networkAsn"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, NetworkAsn networkAsn, JsonSerializerOptions jsonSerializerOptions)
        {
            if (networkAsn.AsNumberOption.IsSet && networkAsn.AsNumber == null)
                throw new ArgumentNullException(nameof(networkAsn.AsNumber), "Property is required for class NetworkAsn.");

            if (networkAsn.OrganizationOption.IsSet && networkAsn.Organization == null)
                throw new ArgumentNullException(nameof(networkAsn.Organization), "Property is required for class NetworkAsn.");

            if (networkAsn.CountryOption.IsSet && networkAsn.Country == null)
                throw new ArgumentNullException(nameof(networkAsn.Country), "Property is required for class NetworkAsn.");

            if (networkAsn.AsnNameOption.IsSet && networkAsn.AsnName == null)
                throw new ArgumentNullException(nameof(networkAsn.AsnName), "Property is required for class NetworkAsn.");

            if (networkAsn.TypeOption.IsSet && networkAsn.Type == null)
                throw new ArgumentNullException(nameof(networkAsn.Type), "Property is required for class NetworkAsn.");

            if (networkAsn.DomainOption.IsSet && networkAsn.Domain == null)
                throw new ArgumentNullException(nameof(networkAsn.Domain), "Property is required for class NetworkAsn.");

            if (networkAsn.DateAllocatedOption.IsSet && networkAsn.DateAllocated == null)
                throw new ArgumentNullException(nameof(networkAsn.DateAllocated), "Property is required for class NetworkAsn.");

            if (networkAsn.AllocationStatusOption.IsSet && networkAsn.AllocationStatus == null)
                throw new ArgumentNullException(nameof(networkAsn.AllocationStatus), "Property is required for class NetworkAsn.");

            if (networkAsn.NumOfIpv4RoutesOption.IsSet && networkAsn.NumOfIpv4Routes == null)
                throw new ArgumentNullException(nameof(networkAsn.NumOfIpv4Routes), "Property is required for class NetworkAsn.");

            if (networkAsn.NumOfIpv6RoutesOption.IsSet && networkAsn.NumOfIpv6Routes == null)
                throw new ArgumentNullException(nameof(networkAsn.NumOfIpv6Routes), "Property is required for class NetworkAsn.");

            if (networkAsn.RirOption.IsSet && networkAsn.Rir == null)
                throw new ArgumentNullException(nameof(networkAsn.Rir), "Property is required for class NetworkAsn.");

            if (networkAsn.AsNumberOption.IsSet)
                writer.WriteString("as_number", networkAsn.AsNumber);

            if (networkAsn.OrganizationOption.IsSet)
                writer.WriteString("organization", networkAsn.Organization);

            if (networkAsn.CountryOption.IsSet)
                writer.WriteString("country", networkAsn.Country);

            if (networkAsn.AsnNameOption.IsSet)
                writer.WriteString("asn_name", networkAsn.AsnName);

            if (networkAsn.TypeOption.IsSet)
                writer.WriteString("type", networkAsn.Type);

            if (networkAsn.DomainOption.IsSet)
                writer.WriteString("domain", networkAsn.Domain);

            if (networkAsn.DateAllocatedOption.IsSet)
                writer.WriteString("date_allocated", networkAsn.DateAllocated);

            if (networkAsn.AllocationStatusOption.IsSet)
                writer.WriteString("allocation_status", networkAsn.AllocationStatus);

            if (networkAsn.NumOfIpv4RoutesOption.IsSet)
                writer.WriteString("num_of_ipv4_routes", networkAsn.NumOfIpv4Routes);

            if (networkAsn.NumOfIpv6RoutesOption.IsSet)
                writer.WriteString("num_of_ipv6_routes", networkAsn.NumOfIpv6Routes);

            if (networkAsn.RirOption.IsSet)
                writer.WriteString("rir", networkAsn.Rir);
        }
    }
}
