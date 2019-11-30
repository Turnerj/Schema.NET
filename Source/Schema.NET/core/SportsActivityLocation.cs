namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A sports location, such as a playing field.
    /// </summary>
    public partial interface ISportsActivityLocation : ILocalBusiness
    {
    }

    /// <summary>
    /// A sports location, such as a playing field.
    /// </summary>
    public partial class SportsActivityLocation : LocalBusiness, ISportsActivityLocation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "SportsActivityLocation";
    }
}
