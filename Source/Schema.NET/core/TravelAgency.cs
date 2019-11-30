namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A travel agency.
    /// </summary>
    public partial interface ITravelAgency : ILocalBusiness
    {
    }

    /// <summary>
    /// A travel agency.
    /// </summary>
    public partial class TravelAgency : LocalBusiness, ITravelAgency
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "TravelAgency";
    }
}
