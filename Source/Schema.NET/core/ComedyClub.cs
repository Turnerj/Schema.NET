namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A comedy club.
    /// </summary>
    public partial interface IComedyClub : IEntertainmentBusiness
    {
    }

    /// <summary>
    /// A comedy club.
    /// </summary>
    public partial class ComedyClub : EntertainmentBusiness, IComedyClub
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ComedyClub";
    }
}
