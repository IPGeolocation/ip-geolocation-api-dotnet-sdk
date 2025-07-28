

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
    /// AstronomyEvening
    /// </summary>
    public partial class AstronomyEvening : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AstronomyEvening" /> class.
        /// </summary>
        /// <param name="goldenHourBegin">goldenHourBegin</param>
        /// <param name="goldenHourEnd">goldenHourEnd</param>
        /// <param name="blueHourBegin">blueHourBegin</param>
        /// <param name="blueHourEnd">blueHourEnd</param>
        /// <param name="civilTwilightBegin">civilTwilightBegin</param>
        /// <param name="civilTwilightEnd">civilTwilightEnd</param>
        /// <param name="nauticalTwilightBegin">nauticalTwilightBegin</param>
        /// <param name="nauticalTwilightEnd">nauticalTwilightEnd</param>
        /// <param name="astronomicalTwilightBegin">astronomicalTwilightBegin</param>
        /// <param name="astronomicalTwilightEnd">astronomicalTwilightEnd</param>
        [JsonConstructor]
        public AstronomyEvening(Option<string?> goldenHourBegin = default, Option<string?> goldenHourEnd = default, Option<string?> blueHourBegin = default, Option<string?> blueHourEnd = default, Option<string?> civilTwilightBegin = default, Option<string?> civilTwilightEnd = default, Option<string?> nauticalTwilightBegin = default, Option<string?> nauticalTwilightEnd = default, Option<string?> astronomicalTwilightBegin = default, Option<string?> astronomicalTwilightEnd = default)
        {
            GoldenHourBeginOption = goldenHourBegin;
            GoldenHourEndOption = goldenHourEnd;
            BlueHourBeginOption = blueHourBegin;
            BlueHourEndOption = blueHourEnd;
            CivilTwilightBeginOption = civilTwilightBegin;
            CivilTwilightEndOption = civilTwilightEnd;
            NauticalTwilightBeginOption = nauticalTwilightBegin;
            NauticalTwilightEndOption = nauticalTwilightEnd;
            AstronomicalTwilightBeginOption = astronomicalTwilightBegin;
            AstronomicalTwilightEndOption = astronomicalTwilightEnd;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of GoldenHourBegin
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> GoldenHourBeginOption { get; private set; }

        /// <summary>
        /// Gets or Sets GoldenHourBegin
        /// </summary>
        /* <example>19:44</example> */
        [JsonPropertyName("golden_hour_begin")]
        public string? GoldenHourBegin { get { return this.GoldenHourBeginOption; } set { this.GoldenHourBeginOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of GoldenHourEnd
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> GoldenHourEndOption { get; private set; }

        /// <summary>
        /// Gets or Sets GoldenHourEnd
        /// </summary>
        /* <example>20:44</example> */
        [JsonPropertyName("golden_hour_end")]
        public string? GoldenHourEnd { get { return this.GoldenHourEndOption; } set { this.GoldenHourEndOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of BlueHourBegin
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> BlueHourBeginOption { get; private set; }

        /// <summary>
        /// Gets or Sets BlueHourBegin
        /// </summary>
        /* <example>20:44</example> */
        [JsonPropertyName("blue_hour_begin")]
        public string? BlueHourBegin { get { return this.BlueHourBeginOption; } set { this.BlueHourBeginOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of BlueHourEnd
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> BlueHourEndOption { get; private set; }

        /// <summary>
        /// Gets or Sets BlueHourEnd
        /// </summary>
        /* <example>21:09</example> */
        [JsonPropertyName("blue_hour_end")]
        public string? BlueHourEnd { get { return this.BlueHourEndOption; } set { this.BlueHourEndOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of CivilTwilightBegin
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CivilTwilightBeginOption { get; private set; }

        /// <summary>
        /// Gets or Sets CivilTwilightBegin
        /// </summary>
        /* <example>20:24</example> */
        [JsonPropertyName("civil_twilight_begin")]
        public string? CivilTwilightBegin { get { return this.CivilTwilightBeginOption; } set { this.CivilTwilightBeginOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of CivilTwilightEnd
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CivilTwilightEndOption { get; private set; }

        /// <summary>
        /// Gets or Sets CivilTwilightEnd
        /// </summary>
        /* <example>20:56</example> */
        [JsonPropertyName("civil_twilight_end")]
        public string? CivilTwilightEnd { get { return this.CivilTwilightEndOption; } set { this.CivilTwilightEndOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of NauticalTwilightBegin
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NauticalTwilightBeginOption { get; private set; }

        /// <summary>
        /// Gets or Sets NauticalTwilightBegin
        /// </summary>
        /* <example>20:56</example> */
        [JsonPropertyName("nautical_twilight_begin")]
        public string? NauticalTwilightBegin { get { return this.NauticalTwilightBeginOption; } set { this.NauticalTwilightBeginOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of NauticalTwilightEnd
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NauticalTwilightEndOption { get; private set; }

        /// <summary>
        /// Gets or Sets NauticalTwilightEnd
        /// </summary>
        /* <example>21:37</example> */
        [JsonPropertyName("nautical_twilight_end")]
        public string? NauticalTwilightEnd { get { return this.NauticalTwilightEndOption; } set { this.NauticalTwilightEndOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of AstronomicalTwilightBegin
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> AstronomicalTwilightBeginOption { get; private set; }

        /// <summary>
        /// Gets or Sets AstronomicalTwilightBegin
        /// </summary>
        /* <example>21:37</example> */
        [JsonPropertyName("astronomical_twilight_begin")]
        public string? AstronomicalTwilightBegin { get { return this.AstronomicalTwilightBeginOption; } set { this.AstronomicalTwilightBeginOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of AstronomicalTwilightEnd
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> AstronomicalTwilightEndOption { get; private set; }

        /// <summary>
        /// Gets or Sets AstronomicalTwilightEnd
        /// </summary>
        /* <example>22:23</example> */
        [JsonPropertyName("astronomical_twilight_end")]
        public string? AstronomicalTwilightEnd { get { return this.AstronomicalTwilightEndOption; } set { this.AstronomicalTwilightEndOption = new Option<string?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AstronomyEvening {\n");
            sb.Append("  GoldenHourBegin: ").Append(GoldenHourBegin).Append("\n");
            sb.Append("  GoldenHourEnd: ").Append(GoldenHourEnd).Append("\n");
            sb.Append("  BlueHourBegin: ").Append(BlueHourBegin).Append("\n");
            sb.Append("  BlueHourEnd: ").Append(BlueHourEnd).Append("\n");
            sb.Append("  CivilTwilightBegin: ").Append(CivilTwilightBegin).Append("\n");
            sb.Append("  CivilTwilightEnd: ").Append(CivilTwilightEnd).Append("\n");
            sb.Append("  NauticalTwilightBegin: ").Append(NauticalTwilightBegin).Append("\n");
            sb.Append("  NauticalTwilightEnd: ").Append(NauticalTwilightEnd).Append("\n");
            sb.Append("  AstronomicalTwilightBegin: ").Append(AstronomicalTwilightBegin).Append("\n");
            sb.Append("  AstronomicalTwilightEnd: ").Append(AstronomicalTwilightEnd).Append("\n");
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
    /// A Json converter for type <see cref="AstronomyEvening" />
    /// </summary>
    public class AstronomyEveningJsonConverter : JsonConverter<AstronomyEvening>
    {
        /// <summary>
        /// Deserializes json to <see cref="AstronomyEvening" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AstronomyEvening Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> goldenHourBegin = default;
            Option<string?> goldenHourEnd = default;
            Option<string?> blueHourBegin = default;
            Option<string?> blueHourEnd = default;
            Option<string?> civilTwilightBegin = default;
            Option<string?> civilTwilightEnd = default;
            Option<string?> nauticalTwilightBegin = default;
            Option<string?> nauticalTwilightEnd = default;
            Option<string?> astronomicalTwilightBegin = default;
            Option<string?> astronomicalTwilightEnd = default;

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
                        case "golden_hour_begin":
                            goldenHourBegin = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "golden_hour_end":
                            goldenHourEnd = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "blue_hour_begin":
                            blueHourBegin = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "blue_hour_end":
                            blueHourEnd = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "civil_twilight_begin":
                            civilTwilightBegin = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "civil_twilight_end":
                            civilTwilightEnd = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "nautical_twilight_begin":
                            nauticalTwilightBegin = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "nautical_twilight_end":
                            nauticalTwilightEnd = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "astronomical_twilight_begin":
                            astronomicalTwilightBegin = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "astronomical_twilight_end":
                            astronomicalTwilightEnd = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (goldenHourBegin.IsSet && goldenHourBegin.Value == null)
                throw new ArgumentNullException(nameof(goldenHourBegin), "Property is not nullable for class AstronomyEvening.");

            if (goldenHourEnd.IsSet && goldenHourEnd.Value == null)
                throw new ArgumentNullException(nameof(goldenHourEnd), "Property is not nullable for class AstronomyEvening.");

            if (blueHourBegin.IsSet && blueHourBegin.Value == null)
                throw new ArgumentNullException(nameof(blueHourBegin), "Property is not nullable for class AstronomyEvening.");

            if (blueHourEnd.IsSet && blueHourEnd.Value == null)
                throw new ArgumentNullException(nameof(blueHourEnd), "Property is not nullable for class AstronomyEvening.");

            if (civilTwilightBegin.IsSet && civilTwilightBegin.Value == null)
                throw new ArgumentNullException(nameof(civilTwilightBegin), "Property is not nullable for class AstronomyEvening.");

            if (civilTwilightEnd.IsSet && civilTwilightEnd.Value == null)
                throw new ArgumentNullException(nameof(civilTwilightEnd), "Property is not nullable for class AstronomyEvening.");

            if (nauticalTwilightBegin.IsSet && nauticalTwilightBegin.Value == null)
                throw new ArgumentNullException(nameof(nauticalTwilightBegin), "Property is not nullable for class AstronomyEvening.");

            if (nauticalTwilightEnd.IsSet && nauticalTwilightEnd.Value == null)
                throw new ArgumentNullException(nameof(nauticalTwilightEnd), "Property is not nullable for class AstronomyEvening.");

            if (astronomicalTwilightBegin.IsSet && astronomicalTwilightBegin.Value == null)
                throw new ArgumentNullException(nameof(astronomicalTwilightBegin), "Property is not nullable for class AstronomyEvening.");

            if (astronomicalTwilightEnd.IsSet && astronomicalTwilightEnd.Value == null)
                throw new ArgumentNullException(nameof(astronomicalTwilightEnd), "Property is not nullable for class AstronomyEvening.");

            return new AstronomyEvening(goldenHourBegin, goldenHourEnd, blueHourBegin, blueHourEnd, civilTwilightBegin, civilTwilightEnd, nauticalTwilightBegin, nauticalTwilightEnd, astronomicalTwilightBegin, astronomicalTwilightEnd);
        }

        /// <summary>
        /// Serializes a <see cref="AstronomyEvening" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="astronomyEvening"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AstronomyEvening astronomyEvening, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, astronomyEvening, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AstronomyEvening" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="astronomyEvening"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AstronomyEvening astronomyEvening, JsonSerializerOptions jsonSerializerOptions)
        {
            if (astronomyEvening.GoldenHourBeginOption.IsSet && astronomyEvening.GoldenHourBegin == null)
                throw new ArgumentNullException(nameof(astronomyEvening.GoldenHourBegin), "Property is required for class AstronomyEvening.");

            if (astronomyEvening.GoldenHourEndOption.IsSet && astronomyEvening.GoldenHourEnd == null)
                throw new ArgumentNullException(nameof(astronomyEvening.GoldenHourEnd), "Property is required for class AstronomyEvening.");

            if (astronomyEvening.BlueHourBeginOption.IsSet && astronomyEvening.BlueHourBegin == null)
                throw new ArgumentNullException(nameof(astronomyEvening.BlueHourBegin), "Property is required for class AstronomyEvening.");

            if (astronomyEvening.BlueHourEndOption.IsSet && astronomyEvening.BlueHourEnd == null)
                throw new ArgumentNullException(nameof(astronomyEvening.BlueHourEnd), "Property is required for class AstronomyEvening.");

            if (astronomyEvening.CivilTwilightBeginOption.IsSet && astronomyEvening.CivilTwilightBegin == null)
                throw new ArgumentNullException(nameof(astronomyEvening.CivilTwilightBegin), "Property is required for class AstronomyEvening.");

            if (astronomyEvening.CivilTwilightEndOption.IsSet && astronomyEvening.CivilTwilightEnd == null)
                throw new ArgumentNullException(nameof(astronomyEvening.CivilTwilightEnd), "Property is required for class AstronomyEvening.");

            if (astronomyEvening.NauticalTwilightBeginOption.IsSet && astronomyEvening.NauticalTwilightBegin == null)
                throw new ArgumentNullException(nameof(astronomyEvening.NauticalTwilightBegin), "Property is required for class AstronomyEvening.");

            if (astronomyEvening.NauticalTwilightEndOption.IsSet && astronomyEvening.NauticalTwilightEnd == null)
                throw new ArgumentNullException(nameof(astronomyEvening.NauticalTwilightEnd), "Property is required for class AstronomyEvening.");

            if (astronomyEvening.AstronomicalTwilightBeginOption.IsSet && astronomyEvening.AstronomicalTwilightBegin == null)
                throw new ArgumentNullException(nameof(astronomyEvening.AstronomicalTwilightBegin), "Property is required for class AstronomyEvening.");

            if (astronomyEvening.AstronomicalTwilightEndOption.IsSet && astronomyEvening.AstronomicalTwilightEnd == null)
                throw new ArgumentNullException(nameof(astronomyEvening.AstronomicalTwilightEnd), "Property is required for class AstronomyEvening.");

            if (astronomyEvening.GoldenHourBeginOption.IsSet)
                writer.WriteString("golden_hour_begin", astronomyEvening.GoldenHourBegin);

            if (astronomyEvening.GoldenHourEndOption.IsSet)
                writer.WriteString("golden_hour_end", astronomyEvening.GoldenHourEnd);

            if (astronomyEvening.BlueHourBeginOption.IsSet)
                writer.WriteString("blue_hour_begin", astronomyEvening.BlueHourBegin);

            if (astronomyEvening.BlueHourEndOption.IsSet)
                writer.WriteString("blue_hour_end", astronomyEvening.BlueHourEnd);

            if (astronomyEvening.CivilTwilightBeginOption.IsSet)
                writer.WriteString("civil_twilight_begin", astronomyEvening.CivilTwilightBegin);

            if (astronomyEvening.CivilTwilightEndOption.IsSet)
                writer.WriteString("civil_twilight_end", astronomyEvening.CivilTwilightEnd);

            if (astronomyEvening.NauticalTwilightBeginOption.IsSet)
                writer.WriteString("nautical_twilight_begin", astronomyEvening.NauticalTwilightBegin);

            if (astronomyEvening.NauticalTwilightEndOption.IsSet)
                writer.WriteString("nautical_twilight_end", astronomyEvening.NauticalTwilightEnd);

            if (astronomyEvening.AstronomicalTwilightBeginOption.IsSet)
                writer.WriteString("astronomical_twilight_begin", astronomyEvening.AstronomicalTwilightBegin);

            if (astronomyEvening.AstronomicalTwilightEndOption.IsSet)
                writer.WriteString("astronomical_twilight_end", astronomyEvening.AstronomicalTwilightEnd);
        }
    }
}
