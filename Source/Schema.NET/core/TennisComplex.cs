namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A tennis complex.
    /// </summary>
    public partial interface ITennisComplex : ISportsActivityLocation
    {
    }

    /// <summary>
    /// A tennis complex.
    /// </summary>
    public partial class TennisComplex : SportsActivityLocation, ITennisComplex
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "TennisComplex";
    }
}
