namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A tourist information center.
    /// </summary>
    public partial interface ITouristInformationCenter : ILocalBusiness
    {
    }

    /// <summary>
    /// A tourist information center.
    /// </summary>
    public partial class TouristInformationCenter : LocalBusiness, ITouristInformationCenter
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "TouristInformationCenter";
    }
}
