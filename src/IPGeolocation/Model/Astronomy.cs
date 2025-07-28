

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
    /// Astronomy
    /// </summary>
    public partial class Astronomy : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Astronomy" /> class.
        /// </summary>
        /// <param name="date">date</param>
        /// <param name="currentTime">currentTime</param>
        /// <param name="midNight">midNight</param>
        /// <param name="nightEnd">nightEnd</param>
        /// <param name="morning">morning</param>
        /// <param name="sunrise">sunrise</param>
        /// <param name="sunset">sunset</param>
        /// <param name="evening">evening</param>
        /// <param name="nightBegin">nightBegin</param>
        /// <param name="sunStatus">sunStatus</param>
        /// <param name="solarNoon">solarNoon</param>
        /// <param name="dayLength">dayLength</param>
        /// <param name="sunAltitude">sunAltitude</param>
        /// <param name="sunDistance">sunDistance</param>
        /// <param name="sunAzimuth">sunAzimuth</param>
        /// <param name="moonPhase">moonPhase</param>
        /// <param name="moonrise">moonrise</param>
        /// <param name="moonset">moonset</param>
        /// <param name="moonStatus">moonStatus</param>
        /// <param name="moonAltitude">moonAltitude</param>
        /// <param name="moonDistance">moonDistance</param>
        /// <param name="moonAzimuth">moonAzimuth</param>
        /// <param name="moonParallacticAngle">moonParallacticAngle</param>
        /// <param name="moonIlluminationPercentage">moonIlluminationPercentage</param>
        /// <param name="moonAngle">moonAngle</param>
        [JsonConstructor]
        public Astronomy(Option<string?> date = default, Option<string?> currentTime = default, Option<string?> midNight = default, Option<string?> nightEnd = default, Option<AstronomyMorning?> morning = default, Option<string?> sunrise = default, Option<string?> sunset = default, Option<AstronomyEvening?> evening = default, Option<string?> nightBegin = default, Option<string?> sunStatus = default, Option<string?> solarNoon = default, Option<string?> dayLength = default, Option<decimal?> sunAltitude = default, Option<decimal?> sunDistance = default, Option<decimal?> sunAzimuth = default, Option<string?> moonPhase = default, Option<string?> moonrise = default, Option<string?> moonset = default, Option<string?> moonStatus = default, Option<decimal?> moonAltitude = default, Option<decimal?> moonDistance = default, Option<decimal?> moonAzimuth = default, Option<decimal?> moonParallacticAngle = default, Option<string?> moonIlluminationPercentage = default, Option<decimal?> moonAngle = default)
        {
            DateOption = date;
            CurrentTimeOption = currentTime;
            MidNightOption = midNight;
            NightEndOption = nightEnd;
            MorningOption = morning;
            SunriseOption = sunrise;
            SunsetOption = sunset;
            EveningOption = evening;
            NightBeginOption = nightBegin;
            SunStatusOption = sunStatus;
            SolarNoonOption = solarNoon;
            DayLengthOption = dayLength;
            SunAltitudeOption = sunAltitude;
            SunDistanceOption = sunDistance;
            SunAzimuthOption = sunAzimuth;
            MoonPhaseOption = moonPhase;
            MoonriseOption = moonrise;
            MoonsetOption = moonset;
            MoonStatusOption = moonStatus;
            MoonAltitudeOption = moonAltitude;
            MoonDistanceOption = moonDistance;
            MoonAzimuthOption = moonAzimuth;
            MoonParallacticAngleOption = moonParallacticAngle;
            MoonIlluminationPercentageOption = moonIlluminationPercentage;
            MoonAngleOption = moonAngle;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Date
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DateOption { get; private set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        /* <example>2025-07-17</example> */
        [JsonPropertyName("date")]
        public string? Date { get { return this.DateOption; } set { this.DateOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of CurrentTime
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CurrentTimeOption { get; private set; }

        /// <summary>
        /// Gets or Sets CurrentTime
        /// </summary>
        /* <example>08:03:36.532</example> */
        [JsonPropertyName("current_time")]
        public string? CurrentTime { get { return this.CurrentTimeOption; } set { this.CurrentTimeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of MidNight
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> MidNightOption { get; private set; }

        /// <summary>
        /// Gets or Sets MidNight
        /// </summary>
        /* <example>01:02</example> */
        [JsonPropertyName("mid_night")]
        public string? MidNight { get { return this.MidNightOption; } set { this.MidNightOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of NightEnd
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NightEndOption { get; private set; }

        /// <summary>
        /// Gets or Sets NightEnd
        /// </summary>
        /* <example>03:40</example> */
        [JsonPropertyName("night_end")]
        public string? NightEnd { get { return this.NightEndOption; } set { this.NightEndOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Morning
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<AstronomyMorning?> MorningOption { get; private set; }

        /// <summary>
        /// Gets or Sets Morning
        /// </summary>
        [JsonPropertyName("morning")]
        public AstronomyMorning? Morning { get { return this.MorningOption; } set { this.MorningOption = new Option<AstronomyMorning?>(value); } }

        /// <summary>
        /// Used to track the state of Sunrise
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> SunriseOption { get; private set; }

        /// <summary>
        /// Gets or Sets Sunrise
        /// </summary>
        /* <example>05:39</example> */
        [JsonPropertyName("sunrise")]
        public string? Sunrise { get { return this.SunriseOption; } set { this.SunriseOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Sunset
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> SunsetOption { get; private set; }

        /// <summary>
        /// Gets or Sets Sunset
        /// </summary>
        /* <example>20:24</example> */
        [JsonPropertyName("sunset")]
        public string? Sunset { get { return this.SunsetOption; } set { this.SunsetOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Evening
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<AstronomyEvening?> EveningOption { get; private set; }

        /// <summary>
        /// Gets or Sets Evening
        /// </summary>
        [JsonPropertyName("evening")]
        public AstronomyEvening? Evening { get { return this.EveningOption; } set { this.EveningOption = new Option<AstronomyEvening?>(value); } }

        /// <summary>
        /// Used to track the state of NightBegin
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NightBeginOption { get; private set; }

        /// <summary>
        /// Gets or Sets NightBegin
        /// </summary>
        /* <example>22:23</example> */
        [JsonPropertyName("night_begin")]
        public string? NightBegin { get { return this.NightBeginOption; } set { this.NightBeginOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of SunStatus
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> SunStatusOption { get; private set; }

        /// <summary>
        /// Gets or Sets SunStatus
        /// </summary>
        /* <example>-</example> */
        [JsonPropertyName("sun_status")]
        public string? SunStatus { get { return this.SunStatusOption; } set { this.SunStatusOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of SolarNoon
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> SolarNoonOption { get; private set; }

        /// <summary>
        /// Gets or Sets SolarNoon
        /// </summary>
        /* <example>13:02</example> */
        [JsonPropertyName("solar_noon")]
        public string? SolarNoon { get { return this.SolarNoonOption; } set { this.SolarNoonOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of DayLength
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DayLengthOption { get; private set; }

        /// <summary>
        /// Gets or Sets DayLength
        /// </summary>
        /* <example>14:45</example> */
        [JsonPropertyName("day_length")]
        public string? DayLength { get { return this.DayLengthOption; } set { this.DayLengthOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of SunAltitude
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> SunAltitudeOption { get; private set; }

        /// <summary>
        /// Gets or Sets SunAltitude
        /// </summary>
        /* <example>24.957683470850487</example> */
        [JsonPropertyName("sun_altitude")]
        public decimal? SunAltitude { get { return this.SunAltitudeOption; } set { this.SunAltitudeOption = new Option<decimal?>(value); } }

        /// <summary>
        /// Used to track the state of SunDistance
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> SunDistanceOption { get; private set; }

        /// <summary>
        /// Gets or Sets SunDistance
        /// </summary>
        /* <example>152059278.3394745</example> */
        [JsonPropertyName("sun_distance")]
        public decimal? SunDistance { get { return this.SunDistanceOption; } set { this.SunDistanceOption = new Option<decimal?>(value); } }

        /// <summary>
        /// Used to track the state of SunAzimuth
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> SunAzimuthOption { get; private set; }

        /// <summary>
        /// Gets or Sets SunAzimuth
        /// </summary>
        /* <example>82.93803947255543</example> */
        [JsonPropertyName("sun_azimuth")]
        public decimal? SunAzimuth { get { return this.SunAzimuthOption; } set { this.SunAzimuthOption = new Option<decimal?>(value); } }

        /// <summary>
        /// Used to track the state of MoonPhase
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> MoonPhaseOption { get; private set; }

        /// <summary>
        /// Gets or Sets MoonPhase
        /// </summary>
        /* <example>LAST_QUARTER</example> */
        [JsonPropertyName("moon_phase")]
        public string? MoonPhase { get { return this.MoonPhaseOption; } set { this.MoonPhaseOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Moonrise
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> MoonriseOption { get; private set; }

        /// <summary>
        /// Gets or Sets Moonrise
        /// </summary>
        /* <example>-:-</example> */
        [JsonPropertyName("moonrise")]
        public string? Moonrise { get { return this.MoonriseOption; } set { this.MoonriseOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Moonset
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> MoonsetOption { get; private set; }

        /// <summary>
        /// Gets or Sets Moonset
        /// </summary>
        /* <example>13:04</example> */
        [JsonPropertyName("moonset")]
        public string? Moonset { get { return this.MoonsetOption; } set { this.MoonsetOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of MoonStatus
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> MoonStatusOption { get; private set; }

        /// <summary>
        /// Gets or Sets MoonStatus
        /// </summary>
        /* <example>-</example> */
        [JsonPropertyName("moon_status")]
        public string? MoonStatus { get { return this.MoonStatusOption; } set { this.MoonStatusOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of MoonAltitude
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> MoonAltitudeOption { get; private set; }

        /// <summary>
        /// Gets or Sets MoonAltitude
        /// </summary>
        /* <example>50.865120808868284</example> */
        [JsonPropertyName("moon_altitude")]
        public decimal? MoonAltitude { get { return this.MoonAltitudeOption; } set { this.MoonAltitudeOption = new Option<decimal?>(value); } }

        /// <summary>
        /// Used to track the state of MoonDistance
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> MoonDistanceOption { get; private set; }

        /// <summary>
        /// Gets or Sets MoonDistance
        /// </summary>
        /* <example>371690.2207058187</example> */
        [JsonPropertyName("moon_distance")]
        public decimal? MoonDistance { get { return this.MoonDistanceOption; } set { this.MoonDistanceOption = new Option<decimal?>(value); } }

        /// <summary>
        /// Used to track the state of MoonAzimuth
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> MoonAzimuthOption { get; private set; }

        /// <summary>
        /// Gets or Sets MoonAzimuth
        /// </summary>
        /* <example>224.27457358894264</example> */
        [JsonPropertyName("moon_azimuth")]
        public decimal? MoonAzimuth { get { return this.MoonAzimuthOption; } set { this.MoonAzimuthOption = new Option<decimal?>(value); } }

        /// <summary>
        /// Used to track the state of MoonParallacticAngle
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> MoonParallacticAngleOption { get; private set; }

        /// <summary>
        /// Gets or Sets MoonParallacticAngle
        /// </summary>
        /* <example>32.4113797557535</example> */
        [JsonPropertyName("moon_parallactic_angle")]
        public decimal? MoonParallacticAngle { get { return this.MoonParallacticAngleOption; } set { this.MoonParallacticAngleOption = new Option<decimal?>(value); } }

        /// <summary>
        /// Used to track the state of MoonIlluminationPercentage
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> MoonIlluminationPercentageOption { get; private set; }

        /// <summary>
        /// Gets or Sets MoonIlluminationPercentage
        /// </summary>
        /* <example>-55.99</example> */
        [JsonPropertyName("moon_illumination_percentage")]
        public string? MoonIlluminationPercentage { get { return this.MoonIlluminationPercentageOption; } set { this.MoonIlluminationPercentageOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of MoonAngle
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> MoonAngleOption { get; private set; }

        /// <summary>
        /// Gets or Sets MoonAngle
        /// </summary>
        /* <example>263.11859022190265</example> */
        [JsonPropertyName("moon_angle")]
        public decimal? MoonAngle { get { return this.MoonAngleOption; } set { this.MoonAngleOption = new Option<decimal?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Astronomy {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  CurrentTime: ").Append(CurrentTime).Append("\n");
            sb.Append("  MidNight: ").Append(MidNight).Append("\n");
            sb.Append("  NightEnd: ").Append(NightEnd).Append("\n");
            sb.Append("  Morning: ").Append(Morning).Append("\n");
            sb.Append("  Sunrise: ").Append(Sunrise).Append("\n");
            sb.Append("  Sunset: ").Append(Sunset).Append("\n");
            sb.Append("  Evening: ").Append(Evening).Append("\n");
            sb.Append("  NightBegin: ").Append(NightBegin).Append("\n");
            sb.Append("  SunStatus: ").Append(SunStatus).Append("\n");
            sb.Append("  SolarNoon: ").Append(SolarNoon).Append("\n");
            sb.Append("  DayLength: ").Append(DayLength).Append("\n");
            sb.Append("  SunAltitude: ").Append(SunAltitude).Append("\n");
            sb.Append("  SunDistance: ").Append(SunDistance).Append("\n");
            sb.Append("  SunAzimuth: ").Append(SunAzimuth).Append("\n");
            sb.Append("  MoonPhase: ").Append(MoonPhase).Append("\n");
            sb.Append("  Moonrise: ").Append(Moonrise).Append("\n");
            sb.Append("  Moonset: ").Append(Moonset).Append("\n");
            sb.Append("  MoonStatus: ").Append(MoonStatus).Append("\n");
            sb.Append("  MoonAltitude: ").Append(MoonAltitude).Append("\n");
            sb.Append("  MoonDistance: ").Append(MoonDistance).Append("\n");
            sb.Append("  MoonAzimuth: ").Append(MoonAzimuth).Append("\n");
            sb.Append("  MoonParallacticAngle: ").Append(MoonParallacticAngle).Append("\n");
            sb.Append("  MoonIlluminationPercentage: ").Append(MoonIlluminationPercentage).Append("\n");
            sb.Append("  MoonAngle: ").Append(MoonAngle).Append("\n");
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
    /// A Json converter for type <see cref="Astronomy" />
    /// </summary>
    public class AstronomyJsonConverter : JsonConverter<Astronomy>
    {
        /// <summary>
        /// Deserializes json to <see cref="Astronomy" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Astronomy Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> date = default;
            Option<string?> currentTime = default;
            Option<string?> midNight = default;
            Option<string?> nightEnd = default;
            Option<AstronomyMorning?> morning = default;
            Option<string?> sunrise = default;
            Option<string?> sunset = default;
            Option<AstronomyEvening?> evening = default;
            Option<string?> nightBegin = default;
            Option<string?> sunStatus = default;
            Option<string?> solarNoon = default;
            Option<string?> dayLength = default;
            Option<decimal?> sunAltitude = default;
            Option<decimal?> sunDistance = default;
            Option<decimal?> sunAzimuth = default;
            Option<string?> moonPhase = default;
            Option<string?> moonrise = default;
            Option<string?> moonset = default;
            Option<string?> moonStatus = default;
            Option<decimal?> moonAltitude = default;
            Option<decimal?> moonDistance = default;
            Option<decimal?> moonAzimuth = default;
            Option<decimal?> moonParallacticAngle = default;
            Option<string?> moonIlluminationPercentage = default;
            Option<decimal?> moonAngle = default;

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
                        case "date":
                            date = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "current_time":
                            currentTime = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "mid_night":
                            midNight = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "night_end":
                            nightEnd = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "morning":
                            morning = new Option<AstronomyMorning?>(JsonSerializer.Deserialize<AstronomyMorning>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "sunrise":
                            sunrise = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "sunset":
                            sunset = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "evening":
                            evening = new Option<AstronomyEvening?>(JsonSerializer.Deserialize<AstronomyEvening>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "night_begin":
                            nightBegin = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "sun_status":
                            sunStatus = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "solar_noon":
                            solarNoon = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "day_length":
                            dayLength = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "sun_altitude":
                            sunAltitude = new Option<decimal?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (decimal?)null : utf8JsonReader.GetDecimal());
                            break;
                        case "sun_distance":
                            sunDistance = new Option<decimal?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (decimal?)null : utf8JsonReader.GetDecimal());
                            break;
                        case "sun_azimuth":
                            sunAzimuth = new Option<decimal?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (decimal?)null : utf8JsonReader.GetDecimal());
                            break;
                        case "moon_phase":
                            moonPhase = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "moonrise":
                            moonrise = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "moonset":
                            moonset = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "moon_status":
                            moonStatus = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "moon_altitude":
                            moonAltitude = new Option<decimal?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (decimal?)null : utf8JsonReader.GetDecimal());
                            break;
                        case "moon_distance":
                            moonDistance = new Option<decimal?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (decimal?)null : utf8JsonReader.GetDecimal());
                            break;
                        case "moon_azimuth":
                            moonAzimuth = new Option<decimal?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (decimal?)null : utf8JsonReader.GetDecimal());
                            break;
                        case "moon_parallactic_angle":
                            moonParallacticAngle = new Option<decimal?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (decimal?)null : utf8JsonReader.GetDecimal());
                            break;
                        case "moon_illumination_percentage":
                            moonIlluminationPercentage = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "moon_angle":
                            moonAngle = new Option<decimal?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (decimal?)null : utf8JsonReader.GetDecimal());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (date.IsSet && date.Value == null)
                throw new ArgumentNullException(nameof(date), "Property is not nullable for class Astronomy.");

            if (currentTime.IsSet && currentTime.Value == null)
                throw new ArgumentNullException(nameof(currentTime), "Property is not nullable for class Astronomy.");

            if (midNight.IsSet && midNight.Value == null)
                throw new ArgumentNullException(nameof(midNight), "Property is not nullable for class Astronomy.");

            if (nightEnd.IsSet && nightEnd.Value == null)
                throw new ArgumentNullException(nameof(nightEnd), "Property is not nullable for class Astronomy.");

            if (morning.IsSet && morning.Value == null)
                throw new ArgumentNullException(nameof(morning), "Property is not nullable for class Astronomy.");

            if (sunrise.IsSet && sunrise.Value == null)
                throw new ArgumentNullException(nameof(sunrise), "Property is not nullable for class Astronomy.");

            if (sunset.IsSet && sunset.Value == null)
                throw new ArgumentNullException(nameof(sunset), "Property is not nullable for class Astronomy.");

            if (evening.IsSet && evening.Value == null)
                throw new ArgumentNullException(nameof(evening), "Property is not nullable for class Astronomy.");

            if (nightBegin.IsSet && nightBegin.Value == null)
                throw new ArgumentNullException(nameof(nightBegin), "Property is not nullable for class Astronomy.");

            if (sunStatus.IsSet && sunStatus.Value == null)
                throw new ArgumentNullException(nameof(sunStatus), "Property is not nullable for class Astronomy.");

            if (solarNoon.IsSet && solarNoon.Value == null)
                throw new ArgumentNullException(nameof(solarNoon), "Property is not nullable for class Astronomy.");

            if (dayLength.IsSet && dayLength.Value == null)
                throw new ArgumentNullException(nameof(dayLength), "Property is not nullable for class Astronomy.");

            if (sunAltitude.IsSet && sunAltitude.Value == null)
                throw new ArgumentNullException(nameof(sunAltitude), "Property is not nullable for class Astronomy.");

            if (sunDistance.IsSet && sunDistance.Value == null)
                throw new ArgumentNullException(nameof(sunDistance), "Property is not nullable for class Astronomy.");

            if (sunAzimuth.IsSet && sunAzimuth.Value == null)
                throw new ArgumentNullException(nameof(sunAzimuth), "Property is not nullable for class Astronomy.");

            if (moonPhase.IsSet && moonPhase.Value == null)
                throw new ArgumentNullException(nameof(moonPhase), "Property is not nullable for class Astronomy.");

            if (moonrise.IsSet && moonrise.Value == null)
                throw new ArgumentNullException(nameof(moonrise), "Property is not nullable for class Astronomy.");

            if (moonset.IsSet && moonset.Value == null)
                throw new ArgumentNullException(nameof(moonset), "Property is not nullable for class Astronomy.");

            if (moonStatus.IsSet && moonStatus.Value == null)
                throw new ArgumentNullException(nameof(moonStatus), "Property is not nullable for class Astronomy.");

            if (moonAltitude.IsSet && moonAltitude.Value == null)
                throw new ArgumentNullException(nameof(moonAltitude), "Property is not nullable for class Astronomy.");

            if (moonDistance.IsSet && moonDistance.Value == null)
                throw new ArgumentNullException(nameof(moonDistance), "Property is not nullable for class Astronomy.");

            if (moonAzimuth.IsSet && moonAzimuth.Value == null)
                throw new ArgumentNullException(nameof(moonAzimuth), "Property is not nullable for class Astronomy.");

            if (moonParallacticAngle.IsSet && moonParallacticAngle.Value == null)
                throw new ArgumentNullException(nameof(moonParallacticAngle), "Property is not nullable for class Astronomy.");

            if (moonIlluminationPercentage.IsSet && moonIlluminationPercentage.Value == null)
                throw new ArgumentNullException(nameof(moonIlluminationPercentage), "Property is not nullable for class Astronomy.");

            if (moonAngle.IsSet && moonAngle.Value == null)
                throw new ArgumentNullException(nameof(moonAngle), "Property is not nullable for class Astronomy.");

            return new Astronomy(date, currentTime, midNight, nightEnd, morning, sunrise, sunset, evening, nightBegin, sunStatus, solarNoon, dayLength, sunAltitude, sunDistance, sunAzimuth, moonPhase, moonrise, moonset, moonStatus, moonAltitude, moonDistance, moonAzimuth, moonParallacticAngle, moonIlluminationPercentage, moonAngle);
        }

        /// <summary>
        /// Serializes a <see cref="Astronomy" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="astronomy"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Astronomy astronomy, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, astronomy, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Astronomy" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="astronomy"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Astronomy astronomy, JsonSerializerOptions jsonSerializerOptions)
        {
            if (astronomy.DateOption.IsSet && astronomy.Date == null)
                throw new ArgumentNullException(nameof(astronomy.Date), "Property is required for class Astronomy.");

            if (astronomy.CurrentTimeOption.IsSet && astronomy.CurrentTime == null)
                throw new ArgumentNullException(nameof(astronomy.CurrentTime), "Property is required for class Astronomy.");

            if (astronomy.MidNightOption.IsSet && astronomy.MidNight == null)
                throw new ArgumentNullException(nameof(astronomy.MidNight), "Property is required for class Astronomy.");

            if (astronomy.NightEndOption.IsSet && astronomy.NightEnd == null)
                throw new ArgumentNullException(nameof(astronomy.NightEnd), "Property is required for class Astronomy.");

            if (astronomy.MorningOption.IsSet && astronomy.Morning == null)
                throw new ArgumentNullException(nameof(astronomy.Morning), "Property is required for class Astronomy.");

            if (astronomy.SunriseOption.IsSet && astronomy.Sunrise == null)
                throw new ArgumentNullException(nameof(astronomy.Sunrise), "Property is required for class Astronomy.");

            if (astronomy.SunsetOption.IsSet && astronomy.Sunset == null)
                throw new ArgumentNullException(nameof(astronomy.Sunset), "Property is required for class Astronomy.");

            if (astronomy.EveningOption.IsSet && astronomy.Evening == null)
                throw new ArgumentNullException(nameof(astronomy.Evening), "Property is required for class Astronomy.");

            if (astronomy.NightBeginOption.IsSet && astronomy.NightBegin == null)
                throw new ArgumentNullException(nameof(astronomy.NightBegin), "Property is required for class Astronomy.");

            if (astronomy.SunStatusOption.IsSet && astronomy.SunStatus == null)
                throw new ArgumentNullException(nameof(astronomy.SunStatus), "Property is required for class Astronomy.");

            if (astronomy.SolarNoonOption.IsSet && astronomy.SolarNoon == null)
                throw new ArgumentNullException(nameof(astronomy.SolarNoon), "Property is required for class Astronomy.");

            if (astronomy.DayLengthOption.IsSet && astronomy.DayLength == null)
                throw new ArgumentNullException(nameof(astronomy.DayLength), "Property is required for class Astronomy.");

            if (astronomy.MoonPhaseOption.IsSet && astronomy.MoonPhase == null)
                throw new ArgumentNullException(nameof(astronomy.MoonPhase), "Property is required for class Astronomy.");

            if (astronomy.MoonriseOption.IsSet && astronomy.Moonrise == null)
                throw new ArgumentNullException(nameof(astronomy.Moonrise), "Property is required for class Astronomy.");

            if (astronomy.MoonsetOption.IsSet && astronomy.Moonset == null)
                throw new ArgumentNullException(nameof(astronomy.Moonset), "Property is required for class Astronomy.");

            if (astronomy.MoonStatusOption.IsSet && astronomy.MoonStatus == null)
                throw new ArgumentNullException(nameof(astronomy.MoonStatus), "Property is required for class Astronomy.");

            if (astronomy.MoonIlluminationPercentageOption.IsSet && astronomy.MoonIlluminationPercentage == null)
                throw new ArgumentNullException(nameof(astronomy.MoonIlluminationPercentage), "Property is required for class Astronomy.");

            if (astronomy.DateOption.IsSet)
                writer.WriteString("date", astronomy.Date);

            if (astronomy.CurrentTimeOption.IsSet)
                writer.WriteString("current_time", astronomy.CurrentTime);

            if (astronomy.MidNightOption.IsSet)
                writer.WriteString("mid_night", astronomy.MidNight);

            if (astronomy.NightEndOption.IsSet)
                writer.WriteString("night_end", astronomy.NightEnd);

            if (astronomy.MorningOption.IsSet)
            {
                writer.WritePropertyName("morning");
                JsonSerializer.Serialize(writer, astronomy.Morning, jsonSerializerOptions);
            }
            if (astronomy.SunriseOption.IsSet)
                writer.WriteString("sunrise", astronomy.Sunrise);

            if (astronomy.SunsetOption.IsSet)
                writer.WriteString("sunset", astronomy.Sunset);

            if (astronomy.EveningOption.IsSet)
            {
                writer.WritePropertyName("evening");
                JsonSerializer.Serialize(writer, astronomy.Evening, jsonSerializerOptions);
            }
            if (astronomy.NightBeginOption.IsSet)
                writer.WriteString("night_begin", astronomy.NightBegin);

            if (astronomy.SunStatusOption.IsSet)
                writer.WriteString("sun_status", astronomy.SunStatus);

            if (astronomy.SolarNoonOption.IsSet)
                writer.WriteString("solar_noon", astronomy.SolarNoon);

            if (astronomy.DayLengthOption.IsSet)
                writer.WriteString("day_length", astronomy.DayLength);

            if (astronomy.SunAltitudeOption.IsSet)
                writer.WriteNumber("sun_altitude", astronomy.SunAltitudeOption.Value!.Value);

            if (astronomy.SunDistanceOption.IsSet)
                writer.WriteNumber("sun_distance", astronomy.SunDistanceOption.Value!.Value);

            if (astronomy.SunAzimuthOption.IsSet)
                writer.WriteNumber("sun_azimuth", astronomy.SunAzimuthOption.Value!.Value);

            if (astronomy.MoonPhaseOption.IsSet)
                writer.WriteString("moon_phase", astronomy.MoonPhase);

            if (astronomy.MoonriseOption.IsSet)
                writer.WriteString("moonrise", astronomy.Moonrise);

            if (astronomy.MoonsetOption.IsSet)
                writer.WriteString("moonset", astronomy.Moonset);

            if (astronomy.MoonStatusOption.IsSet)
                writer.WriteString("moon_status", astronomy.MoonStatus);

            if (astronomy.MoonAltitudeOption.IsSet)
                writer.WriteNumber("moon_altitude", astronomy.MoonAltitudeOption.Value!.Value);

            if (astronomy.MoonDistanceOption.IsSet)
                writer.WriteNumber("moon_distance", astronomy.MoonDistanceOption.Value!.Value);

            if (astronomy.MoonAzimuthOption.IsSet)
                writer.WriteNumber("moon_azimuth", astronomy.MoonAzimuthOption.Value!.Value);

            if (astronomy.MoonParallacticAngleOption.IsSet)
                writer.WriteNumber("moon_parallactic_angle", astronomy.MoonParallacticAngleOption.Value!.Value);

            if (astronomy.MoonIlluminationPercentageOption.IsSet)
                writer.WriteString("moon_illumination_percentage", astronomy.MoonIlluminationPercentage);

            if (astronomy.MoonAngleOption.IsSet)
                writer.WriteNumber("moon_angle", astronomy.MoonAngleOption.Value!.Value);
        }
    }
}
