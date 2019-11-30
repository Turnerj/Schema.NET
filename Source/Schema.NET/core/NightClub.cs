namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A nightclub or discotheque.
    /// </summary>
    public partial interface INightClub : IEntertainmentBusiness
    {
    }

    /// <summary>
    /// A nightclub or discotheque.
    /// </summary>
    public partial class NightClub : EntertainmentBusiness, INightClub
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "NightClub";
    }
}
