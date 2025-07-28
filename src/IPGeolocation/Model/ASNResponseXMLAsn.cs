

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
    /// ASNResponseXMLAsn
    /// </summary>
    public partial class ASNResponseXMLAsn : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ASNResponseXMLAsn" /> class.
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
        /// <param name="routes">It will only be included in the response, if you set include&#x3D;routes in the request</param>
        /// <param name="upstreams">upstreams</param>
        /// <param name="downstreams">downstreams</param>
        /// <param name="peers">peers</param>
        /// <param name="whoisResponse">whoisResponse</param>
        [JsonConstructor]
        public ASNResponseXMLAsn(Option<string?> asNumber = default, Option<string?> organization = default, Option<string?> country = default, Option<string?> asnName = default, Option<string?> type = default, Option<string?> domain = default, Option<DateTimeOffset?> dateAllocated = default, Option<string?> allocationStatus = default, Option<int?> numOfIpv4Routes = default, Option<int?> numOfIpv6Routes = default, Option<string?> rir = default, Option<List<string>?> routes = default, Option<List<ASNConnection>?> upstreams = default, Option<List<ASNConnection>?> downstreams = default, Option<List<ASNConnection>?> peers = default, Option<string?> whoisResponse = default)
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
            RoutesOption = routes;
            UpstreamsOption = upstreams;
            DownstreamsOption = downstreams;
            PeersOption = peers;
            WhoisResponseOption = whoisResponse;
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
        /* <example>AS3269</example> */
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
        /* <example>Telecom Italia S.p.A.</example> */
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
        /* <example>IT</example> */
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
        /* <example>ASN-IBSNAZ</example> */
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
        /* <example>ISP</example> */
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
        /* <example>business.telecomitalia.it</example> */
        [JsonPropertyName("domain")]
        public string? Domain { get { return this.DomainOption; } set { this.DomainOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of DateAllocated
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTimeOffset?> DateAllocatedOption { get; private set; }

        /// <summary>
        /// Gets or Sets DateAllocated
        /// </summary>
        /* <example>Mon Nov 14 05:00:00 PKT 1994</example> */
        [JsonPropertyName("date_allocated")]
        public DateTimeOffset? DateAllocated { get { return this.DateAllocatedOption; } set { this.DateAllocatedOption = new Option<DateTimeOffset?>(value); } }

        /// <summary>
        /// Used to track the state of AllocationStatus
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> AllocationStatusOption { get; private set; }

        /// <summary>
        /// Gets or Sets AllocationStatus
        /// </summary>
        /* <example>allocated</example> */
        [JsonPropertyName("allocation_status")]
        public string? AllocationStatus { get { return this.AllocationStatusOption; } set { this.AllocationStatusOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of NumOfIpv4Routes
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> NumOfIpv4RoutesOption { get; private set; }

        /// <summary>
        /// Gets or Sets NumOfIpv4Routes
        /// </summary>
        /* <example>490</example> */
        [JsonPropertyName("num_of_ipv4_routes")]
        public int? NumOfIpv4Routes { get { return this.NumOfIpv4RoutesOption; } set { this.NumOfIpv4RoutesOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of NumOfIpv6Routes
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> NumOfIpv6RoutesOption { get; private set; }

        /// <summary>
        /// Gets or Sets NumOfIpv6Routes
        /// </summary>
        /* <example>4</example> */
        [JsonPropertyName("num_of_ipv6_routes")]
        public int? NumOfIpv6Routes { get { return this.NumOfIpv6RoutesOption; } set { this.NumOfIpv6RoutesOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of Rir
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> RirOption { get; private set; }

        /// <summary>
        /// Gets or Sets Rir
        /// </summary>
        /* <example>RIPE</example> */
        [JsonPropertyName("rir")]
        public string? Rir { get { return this.RirOption; } set { this.RirOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Routes
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> RoutesOption { get; private set; }

        /// <summary>
        /// It will only be included in the response, if you set include&#x3D;routes in the request
        /// </summary>
        /// <value>It will only be included in the response, if you set include&#x3D;routes in the request</value>
        /* <example>[&quot;192.76.177.0/24&quot;,&quot;216.165.96.0/20&quot;,&quot;216.165.89.0/24&quot;]</example> */
        [JsonPropertyName("routes")]
        public List<string>? Routes { get { return this.RoutesOption; } set { this.RoutesOption = new Option<List<string>?>(value); } }

        /// <summary>
        /// Used to track the state of Upstreams
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<ASNConnection>?> UpstreamsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Upstreams
        /// </summary>
        [JsonPropertyName("upstreams")]
        public List<ASNConnection>? Upstreams { get { return this.UpstreamsOption; } set { this.UpstreamsOption = new Option<List<ASNConnection>?>(value); } }

        /// <summary>
        /// Used to track the state of Downstreams
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<ASNConnection>?> DownstreamsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Downstreams
        /// </summary>
        [JsonPropertyName("downstreams")]
        public List<ASNConnection>? Downstreams { get { return this.DownstreamsOption; } set { this.DownstreamsOption = new Option<List<ASNConnection>?>(value); } }

        /// <summary>
        /// Used to track the state of Peers
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<ASNConnection>?> PeersOption { get; private set; }

        /// <summary>
        /// Gets or Sets Peers
        /// </summary>
        [JsonPropertyName("peers")]
        public List<ASNConnection>? Peers { get { return this.PeersOption; } set { this.PeersOption = new Option<List<ASNConnection>?>(value); } }

        /// <summary>
        /// Used to track the state of WhoisResponse
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> WhoisResponseOption { get; private set; }

        /// <summary>
        /// Gets or Sets WhoisResponse
        /// </summary>
        /* <example>whois output as a single string...</example> */
        [JsonPropertyName("whois_response")]
        public string? WhoisResponse { get { return this.WhoisResponseOption; } set { this.WhoisResponseOption = new Option<string?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ASNResponseXMLAsn {\n");
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
            sb.Append("  Routes: ").Append(Routes).Append("\n");
            sb.Append("  Upstreams: ").Append(Upstreams).Append("\n");
            sb.Append("  Downstreams: ").Append(Downstreams).Append("\n");
            sb.Append("  Peers: ").Append(Peers).Append("\n");
            sb.Append("  WhoisResponse: ").Append(WhoisResponse).Append("\n");
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
    /// A Json converter for type <see cref="ASNResponseXMLAsn" />
    /// </summary>
    public class ASNResponseXMLAsnJsonConverter : JsonConverter<ASNResponseXMLAsn>
    {
        /// <summary>
        /// The format to use to serialize DateAllocated
        /// </summary>
        public static string DateAllocatedFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// Deserializes json to <see cref="ASNResponseXMLAsn" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ASNResponseXMLAsn Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
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
            Option<DateTimeOffset?> dateAllocated = default;
            Option<string?> allocationStatus = default;
            Option<int?> numOfIpv4Routes = default;
            Option<int?> numOfIpv6Routes = default;
            Option<string?> rir = default;
            Option<List<string>?> routes = default;
            Option<List<ASNConnection>?> upstreams = default;
            Option<List<ASNConnection>?> downstreams = default;
            Option<List<ASNConnection>?> peers = default;
            Option<string?> whoisResponse = default;

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
                            dateAllocated = new Option<DateTimeOffset?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "allocation_status":
                            allocationStatus = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "num_of_ipv4_routes":
                            numOfIpv4Routes = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "num_of_ipv6_routes":
                            numOfIpv6Routes = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "rir":
                            rir = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "routes":
                            routes = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "upstreams":
                            upstreams = new Option<List<ASNConnection>?>(JsonSerializer.Deserialize<List<ASNConnection>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "downstreams":
                            downstreams = new Option<List<ASNConnection>?>(JsonSerializer.Deserialize<List<ASNConnection>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "peers":
                            peers = new Option<List<ASNConnection>?>(JsonSerializer.Deserialize<List<ASNConnection>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "whois_response":
                            whoisResponse = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (asNumber.IsSet && asNumber.Value == null)
                throw new ArgumentNullException(nameof(asNumber), "Property is not nullable for class ASNResponseXMLAsn.");

            if (organization.IsSet && organization.Value == null)
                throw new ArgumentNullException(nameof(organization), "Property is not nullable for class ASNResponseXMLAsn.");

            if (country.IsSet && country.Value == null)
                throw new ArgumentNullException(nameof(country), "Property is not nullable for class ASNResponseXMLAsn.");

            if (asnName.IsSet && asnName.Value == null)
                throw new ArgumentNullException(nameof(asnName), "Property is not nullable for class ASNResponseXMLAsn.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class ASNResponseXMLAsn.");

            if (domain.IsSet && domain.Value == null)
                throw new ArgumentNullException(nameof(domain), "Property is not nullable for class ASNResponseXMLAsn.");

            if (dateAllocated.IsSet && dateAllocated.Value == null)
                throw new ArgumentNullException(nameof(dateAllocated), "Property is not nullable for class ASNResponseXMLAsn.");

            if (allocationStatus.IsSet && allocationStatus.Value == null)
                throw new ArgumentNullException(nameof(allocationStatus), "Property is not nullable for class ASNResponseXMLAsn.");

            if (numOfIpv4Routes.IsSet && numOfIpv4Routes.Value == null)
                throw new ArgumentNullException(nameof(numOfIpv4Routes), "Property is not nullable for class ASNResponseXMLAsn.");

            if (numOfIpv6Routes.IsSet && numOfIpv6Routes.Value == null)
                throw new ArgumentNullException(nameof(numOfIpv6Routes), "Property is not nullable for class ASNResponseXMLAsn.");

            if (rir.IsSet && rir.Value == null)
                throw new ArgumentNullException(nameof(rir), "Property is not nullable for class ASNResponseXMLAsn.");

            if (routes.IsSet && routes.Value == null)
                throw new ArgumentNullException(nameof(routes), "Property is not nullable for class ASNResponseXMLAsn.");

            if (upstreams.IsSet && upstreams.Value == null)
                throw new ArgumentNullException(nameof(upstreams), "Property is not nullable for class ASNResponseXMLAsn.");

            if (downstreams.IsSet && downstreams.Value == null)
                throw new ArgumentNullException(nameof(downstreams), "Property is not nullable for class ASNResponseXMLAsn.");

            if (peers.IsSet && peers.Value == null)
                throw new ArgumentNullException(nameof(peers), "Property is not nullable for class ASNResponseXMLAsn.");

            if (whoisResponse.IsSet && whoisResponse.Value == null)
                throw new ArgumentNullException(nameof(whoisResponse), "Property is not nullable for class ASNResponseXMLAsn.");

            return new ASNResponseXMLAsn(asNumber, organization, country, asnName, type, domain, dateAllocated, allocationStatus, numOfIpv4Routes, numOfIpv6Routes, rir, routes, upstreams, downstreams, peers, whoisResponse);
        }

        /// <summary>
        /// Serializes a <see cref="ASNResponseXMLAsn" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="aSNResponseXMLAsn"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ASNResponseXMLAsn aSNResponseXMLAsn, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, aSNResponseXMLAsn, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ASNResponseXMLAsn" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="aSNResponseXMLAsn"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ASNResponseXMLAsn aSNResponseXMLAsn, JsonSerializerOptions jsonSerializerOptions)
        {
            if (aSNResponseXMLAsn.AsNumberOption.IsSet && aSNResponseXMLAsn.AsNumber == null)
                throw new ArgumentNullException(nameof(aSNResponseXMLAsn.AsNumber), "Property is required for class ASNResponseXMLAsn.");

            if (aSNResponseXMLAsn.OrganizationOption.IsSet && aSNResponseXMLAsn.Organization == null)
                throw new ArgumentNullException(nameof(aSNResponseXMLAsn.Organization), "Property is required for class ASNResponseXMLAsn.");

            if (aSNResponseXMLAsn.CountryOption.IsSet && aSNResponseXMLAsn.Country == null)
                throw new ArgumentNullException(nameof(aSNResponseXMLAsn.Country), "Property is required for class ASNResponseXMLAsn.");

            if (aSNResponseXMLAsn.AsnNameOption.IsSet && aSNResponseXMLAsn.AsnName == null)
                throw new ArgumentNullException(nameof(aSNResponseXMLAsn.AsnName), "Property is required for class ASNResponseXMLAsn.");

            if (aSNResponseXMLAsn.TypeOption.IsSet && aSNResponseXMLAsn.Type == null)
                throw new ArgumentNullException(nameof(aSNResponseXMLAsn.Type), "Property is required for class ASNResponseXMLAsn.");

            if (aSNResponseXMLAsn.DomainOption.IsSet && aSNResponseXMLAsn.Domain == null)
                throw new ArgumentNullException(nameof(aSNResponseXMLAsn.Domain), "Property is required for class ASNResponseXMLAsn.");

            if (aSNResponseXMLAsn.AllocationStatusOption.IsSet && aSNResponseXMLAsn.AllocationStatus == null)
                throw new ArgumentNullException(nameof(aSNResponseXMLAsn.AllocationStatus), "Property is required for class ASNResponseXMLAsn.");

            if (aSNResponseXMLAsn.RirOption.IsSet && aSNResponseXMLAsn.Rir == null)
                throw new ArgumentNullException(nameof(aSNResponseXMLAsn.Rir), "Property is required for class ASNResponseXMLAsn.");

            if (aSNResponseXMLAsn.RoutesOption.IsSet && aSNResponseXMLAsn.Routes == null)
                throw new ArgumentNullException(nameof(aSNResponseXMLAsn.Routes), "Property is required for class ASNResponseXMLAsn.");

            if (aSNResponseXMLAsn.UpstreamsOption.IsSet && aSNResponseXMLAsn.Upstreams == null)
                throw new ArgumentNullException(nameof(aSNResponseXMLAsn.Upstreams), "Property is required for class ASNResponseXMLAsn.");

            if (aSNResponseXMLAsn.DownstreamsOption.IsSet && aSNResponseXMLAsn.Downstreams == null)
                throw new ArgumentNullException(nameof(aSNResponseXMLAsn.Downstreams), "Property is required for class ASNResponseXMLAsn.");

            if (aSNResponseXMLAsn.PeersOption.IsSet && aSNResponseXMLAsn.Peers == null)
                throw new ArgumentNullException(nameof(aSNResponseXMLAsn.Peers), "Property is required for class ASNResponseXMLAsn.");

            if (aSNResponseXMLAsn.WhoisResponseOption.IsSet && aSNResponseXMLAsn.WhoisResponse == null)
                throw new ArgumentNullException(nameof(aSNResponseXMLAsn.WhoisResponse), "Property is required for class ASNResponseXMLAsn.");

            if (aSNResponseXMLAsn.AsNumberOption.IsSet)
                writer.WriteString("as_number", aSNResponseXMLAsn.AsNumber);

            if (aSNResponseXMLAsn.OrganizationOption.IsSet)
                writer.WriteString("organization", aSNResponseXMLAsn.Organization);

            if (aSNResponseXMLAsn.CountryOption.IsSet)
                writer.WriteString("country", aSNResponseXMLAsn.Country);

            if (aSNResponseXMLAsn.AsnNameOption.IsSet)
                writer.WriteString("asn_name", aSNResponseXMLAsn.AsnName);

            if (aSNResponseXMLAsn.TypeOption.IsSet)
                writer.WriteString("type", aSNResponseXMLAsn.Type);

            if (aSNResponseXMLAsn.DomainOption.IsSet)
                writer.WriteString("domain", aSNResponseXMLAsn.Domain);

            if (aSNResponseXMLAsn.DateAllocatedOption.IsSet)
                writer.WriteString("date_allocated", aSNResponseXMLAsn.DateAllocatedOption.Value!.Value.ToString(DateAllocatedFormat));

            if (aSNResponseXMLAsn.AllocationStatusOption.IsSet)
                writer.WriteString("allocation_status", aSNResponseXMLAsn.AllocationStatus);

            if (aSNResponseXMLAsn.NumOfIpv4RoutesOption.IsSet)
                writer.WriteNumber("num_of_ipv4_routes", aSNResponseXMLAsn.NumOfIpv4RoutesOption.Value!.Value);

            if (aSNResponseXMLAsn.NumOfIpv6RoutesOption.IsSet)
                writer.WriteNumber("num_of_ipv6_routes", aSNResponseXMLAsn.NumOfIpv6RoutesOption.Value!.Value);

            if (aSNResponseXMLAsn.RirOption.IsSet)
                writer.WriteString("rir", aSNResponseXMLAsn.Rir);

            if (aSNResponseXMLAsn.RoutesOption.IsSet)
            {
                writer.WritePropertyName("routes");
                JsonSerializer.Serialize(writer, aSNResponseXMLAsn.Routes, jsonSerializerOptions);
            }
            if (aSNResponseXMLAsn.UpstreamsOption.IsSet)
            {
                writer.WritePropertyName("upstreams");
                JsonSerializer.Serialize(writer, aSNResponseXMLAsn.Upstreams, jsonSerializerOptions);
            }
            if (aSNResponseXMLAsn.DownstreamsOption.IsSet)
            {
                writer.WritePropertyName("downstreams");
                JsonSerializer.Serialize(writer, aSNResponseXMLAsn.Downstreams, jsonSerializerOptions);
            }
            if (aSNResponseXMLAsn.PeersOption.IsSet)
            {
                writer.WritePropertyName("peers");
                JsonSerializer.Serialize(writer, aSNResponseXMLAsn.Peers, jsonSerializerOptions);
            }
            if (aSNResponseXMLAsn.WhoisResponseOption.IsSet)
                writer.WriteString("whois_response", aSNResponseXMLAsn.WhoisResponse);
        }
    }
}
