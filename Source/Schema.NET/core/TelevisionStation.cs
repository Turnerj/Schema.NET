namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A television station.
    /// </summary>
    public partial interface ITelevisionStation : ILocalBusiness
    {
    }

    /// <summary>
    /// A television station.
    /// </summary>
    public partial class TelevisionStation : LocalBusiness, ITelevisionStation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "TelevisionStation";
    }
}
