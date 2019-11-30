namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A sports club.
    /// </summary>
    public partial interface ISportsClub : ISportsActivityLocation
    {
    }

    /// <summary>
    /// A sports club.
    /// </summary>
    public partial class SportsClub : SportsActivityLocation, ISportsClub
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "SportsClub";
    }
}
