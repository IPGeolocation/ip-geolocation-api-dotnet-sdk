

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
    /// Abuse
    /// </summary>
    public partial class Abuse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Abuse" /> class.
        /// </summary>
        /// <param name="route">route</param>
        /// <param name="country">country</param>
        /// <param name="handle">handle</param>
        /// <param name="name">name</param>
        /// <param name="organization">organization</param>
        /// <param name="role">role</param>
        /// <param name="kind">kind</param>
        /// <param name="address">address</param>
        /// <param name="emails">emails</param>
        /// <param name="phoneNumbers">phoneNumbers</param>
        [JsonConstructor]
        public Abuse(Option<string?> route = default, Option<string?> country = default, Option<string?> handle = default, Option<string?> name = default, Option<string?> organization = default, Option<string?> role = default, Option<string?> kind = default, Option<string?> address = default, Option<List<string>?> emails = default, Option<List<string>?> phoneNumbers = default)
        {
            RouteOption = route;
            CountryOption = country;
            HandleOption = handle;
            NameOption = name;
            OrganizationOption = organization;
            RoleOption = role;
            KindOption = kind;
            AddressOption = address;
            EmailsOption = emails;
            PhoneNumbersOption = phoneNumbers;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Route
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> RouteOption { get; private set; }

        /// <summary>
        /// Gets or Sets Route
        /// </summary>
        /* <example>8.8.8.0/24</example> */
        [JsonPropertyName("route")]
        public string? Route { get { return this.RouteOption; } set { this.RouteOption = new Option<string?>(value); } }

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
        /// Used to track the state of Handle
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> HandleOption { get; private set; }

        /// <summary>
        /// Gets or Sets Handle
        /// </summary>
        /* <example>ABUSE5250-ARIN</example> */
        [JsonPropertyName("handle")]
        public string? Handle { get { return this.HandleOption; } set { this.HandleOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NameOption { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /* <example>Abuse</example> */
        [JsonPropertyName("name")]
        public string? Name { get { return this.NameOption; } set { this.NameOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Organization
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> OrganizationOption { get; private set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        /* <example>Abuse</example> */
        [JsonPropertyName("organization")]
        public string? Organization { get { return this.OrganizationOption; } set { this.OrganizationOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Role
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> RoleOption { get; private set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        /* <example>abuse</example> */
        [JsonPropertyName("role")]
        public string? Role { get { return this.RoleOption; } set { this.RoleOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Kind
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> KindOption { get; private set; }

        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        /* <example>group</example> */
        [JsonPropertyName("kind")]
        public string? Kind { get { return this.KindOption; } set { this.KindOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Address
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> AddressOption { get; private set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        /* <example>1600 Amphitheatre Parkway
Mountain View
CA
94043
United States</example> */
        [JsonPropertyName("address")]
        public string? Address { get { return this.AddressOption; } set { this.AddressOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Emails
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> EmailsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        /* <example>[&quot;network-abuse@google.com&quot;]</example> */
        [JsonPropertyName("emails")]
        public List<string>? Emails { get { return this.EmailsOption; } set { this.EmailsOption = new Option<List<string>?>(value); } }

        /// <summary>
        /// Used to track the state of PhoneNumbers
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> PhoneNumbersOption { get; private set; }

        /// <summary>
        /// Gets or Sets PhoneNumbers
        /// </summary>
        /* <example>[&quot;+1-650-253-0000&quot;]</example> */
        [JsonPropertyName("phone_numbers")]
        public List<string>? PhoneNumbers { get { return this.PhoneNumbersOption; } set { this.PhoneNumbersOption = new Option<List<string>?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Abuse {\n");
            sb.Append("  Route: ").Append(Route).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Handle: ").Append(Handle).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
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
    /// A Json converter for type <see cref="Abuse" />
    /// </summary>
    public class AbuseJsonConverter : JsonConverter<Abuse>
    {
        /// <summary>
        /// Deserializes json to <see cref="Abuse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Abuse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> route = default;
            Option<string?> country = default;
            Option<string?> handle = default;
            Option<string?> name = default;
            Option<string?> organization = default;
            Option<string?> role = default;
            Option<string?> kind = default;
            Option<string?> address = default;
            Option<List<string>?> emails = default;
            Option<List<string>?> phoneNumbers = default;

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
                        case "route":
                            route = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "country":
                            country = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "handle":
                            handle = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "organization":
                            organization = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "role":
                            role = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "kind":
                            kind = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "address":
                            address = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "emails":
                            emails = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "phone_numbers":
                            phoneNumbers = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (route.IsSet && route.Value == null)
                throw new ArgumentNullException(nameof(route), "Property is not nullable for class Abuse.");

            if (country.IsSet && country.Value == null)
                throw new ArgumentNullException(nameof(country), "Property is not nullable for class Abuse.");

            if (handle.IsSet && handle.Value == null)
                throw new ArgumentNullException(nameof(handle), "Property is not nullable for class Abuse.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class Abuse.");

            if (organization.IsSet && organization.Value == null)
                throw new ArgumentNullException(nameof(organization), "Property is not nullable for class Abuse.");

            if (role.IsSet && role.Value == null)
                throw new ArgumentNullException(nameof(role), "Property is not nullable for class Abuse.");

            if (kind.IsSet && kind.Value == null)
                throw new ArgumentNullException(nameof(kind), "Property is not nullable for class Abuse.");

            if (address.IsSet && address.Value == null)
                throw new ArgumentNullException(nameof(address), "Property is not nullable for class Abuse.");

            if (emails.IsSet && emails.Value == null)
                throw new ArgumentNullException(nameof(emails), "Property is not nullable for class Abuse.");

            if (phoneNumbers.IsSet && phoneNumbers.Value == null)
                throw new ArgumentNullException(nameof(phoneNumbers), "Property is not nullable for class Abuse.");

            return new Abuse(route, country, handle, name, organization, role, kind, address, emails, phoneNumbers);
        }

        /// <summary>
        /// Serializes a <see cref="Abuse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="abuse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Abuse abuse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, abuse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Abuse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="abuse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Abuse abuse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (abuse.RouteOption.IsSet && abuse.Route == null)
                throw new ArgumentNullException(nameof(abuse.Route), "Property is required for class Abuse.");

            if (abuse.CountryOption.IsSet && abuse.Country == null)
                throw new ArgumentNullException(nameof(abuse.Country), "Property is required for class Abuse.");

            if (abuse.HandleOption.IsSet && abuse.Handle == null)
                throw new ArgumentNullException(nameof(abuse.Handle), "Property is required for class Abuse.");

            if (abuse.NameOption.IsSet && abuse.Name == null)
                throw new ArgumentNullException(nameof(abuse.Name), "Property is required for class Abuse.");

            if (abuse.OrganizationOption.IsSet && abuse.Organization == null)
                throw new ArgumentNullException(nameof(abuse.Organization), "Property is required for class Abuse.");

            if (abuse.RoleOption.IsSet && abuse.Role == null)
                throw new ArgumentNullException(nameof(abuse.Role), "Property is required for class Abuse.");

            if (abuse.KindOption.IsSet && abuse.Kind == null)
                throw new ArgumentNullException(nameof(abuse.Kind), "Property is required for class Abuse.");

            if (abuse.AddressOption.IsSet && abuse.Address == null)
                throw new ArgumentNullException(nameof(abuse.Address), "Property is required for class Abuse.");

            if (abuse.EmailsOption.IsSet && abuse.Emails == null)
                throw new ArgumentNullException(nameof(abuse.Emails), "Property is required for class Abuse.");

            if (abuse.PhoneNumbersOption.IsSet && abuse.PhoneNumbers == null)
                throw new ArgumentNullException(nameof(abuse.PhoneNumbers), "Property is required for class Abuse.");

            if (abuse.RouteOption.IsSet)
                writer.WriteString("route", abuse.Route);

            if (abuse.CountryOption.IsSet)
                writer.WriteString("country", abuse.Country);

            if (abuse.HandleOption.IsSet)
                writer.WriteString("handle", abuse.Handle);

            if (abuse.NameOption.IsSet)
                writer.WriteString("name", abuse.Name);

            if (abuse.OrganizationOption.IsSet)
                writer.WriteString("organization", abuse.Organization);

            if (abuse.RoleOption.IsSet)
                writer.WriteString("role", abuse.Role);

            if (abuse.KindOption.IsSet)
                writer.WriteString("kind", abuse.Kind);

            if (abuse.AddressOption.IsSet)
                writer.WriteString("address", abuse.Address);

            if (abuse.EmailsOption.IsSet)
            {
                writer.WritePropertyName("emails");
                JsonSerializer.Serialize(writer, abuse.Emails, jsonSerializerOptions);
            }
            if (abuse.PhoneNumbersOption.IsSet)
            {
                writer.WritePropertyName("phone_numbers");
                JsonSerializer.Serialize(writer, abuse.PhoneNumbers, jsonSerializerOptions);
            }
        }
    }
}
