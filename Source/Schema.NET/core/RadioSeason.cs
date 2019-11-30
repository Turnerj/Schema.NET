namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Season dedicated to radio broadcast and associated online delivery.
    /// </summary>
    public partial interface IRadioSeason : ICreativeWorkSeason
    {
    }

    /// <summary>
    /// Season dedicated to radio broadcast and associated online delivery.
    /// </summary>
    public partial class RadioSeason : CreativeWorkSeason, IRadioSeason
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "RadioSeason";
    }
}
