namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A radio episode which can be part of a series or season.
    /// </summary>
    public partial interface IRadioEpisode : IEpisode
    {
    }

    /// <summary>
    /// A radio episode which can be part of a series or season.
    /// </summary>
    public partial class RadioEpisode : Episode, IRadioEpisode
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "RadioEpisode";
    }
}
