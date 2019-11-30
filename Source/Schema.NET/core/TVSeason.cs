namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Season dedicated to TV broadcast and associated online delivery.
    /// </summary>
    public partial interface ITVSeason : ICreativeWorkSeason
    {
        /// <summary>
        /// The country of the principal offices of the production company or individual responsible for the movie or program.
        /// </summary>
        OneOrMany<ICountry> CountryOfOrigin { get; set; }
    }

    /// <summary>
    /// Season dedicated to TV broadcast and associated online delivery.
    /// </summary>
    public partial class TVSeason : CreativeWorkSeason, ITVSeason
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "TVSeason";

        /// <summary>
        /// The country of the principal offices of the production company or individual responsible for the movie or program.
        /// </summary>
        [JsonPropertyName("countryOfOrigin")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICountry> CountryOfOrigin { get; set; }
    }
}
