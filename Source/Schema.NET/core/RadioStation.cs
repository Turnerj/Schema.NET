namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A radio station.
    /// </summary>
    public partial interface IRadioStation : ILocalBusiness
    {
    }

    /// <summary>
    /// A radio station.
    /// </summary>
    public partial class RadioStation : LocalBusiness, IRadioStation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "RadioStation";
    }
}
