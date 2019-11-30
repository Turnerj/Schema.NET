namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A real-estate agent.
    /// </summary>
    public partial interface IRealEstateAgent : ILocalBusiness
    {
    }

    /// <summary>
    /// A real-estate agent.
    /// </summary>
    public partial class RealEstateAgent : LocalBusiness, IRealEstateAgent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "RealEstateAgent";
    }
}
