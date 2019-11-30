namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An adult entertainment establishment.
    /// </summary>
    public partial interface IAdultEntertainment : IEntertainmentBusiness
    {
    }

    /// <summary>
    /// An adult entertainment establishment.
    /// </summary>
    public partial class AdultEntertainment : EntertainmentBusiness, IAdultEntertainment
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AdultEntertainment";
    }
}
