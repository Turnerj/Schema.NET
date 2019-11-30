namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A business providing entertainment.
    /// </summary>
    public partial interface IEntertainmentBusiness : ILocalBusiness
    {
    }

    /// <summary>
    /// A business providing entertainment.
    /// </summary>
    public partial class EntertainmentBusiness : LocalBusiness, IEntertainmentBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "EntertainmentBusiness";
    }
}
