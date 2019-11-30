namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A reservoir of water, typically an artificially created lake, like the Lake Kariba reservoir.
    /// </summary>
    public partial interface IReservoir : IBodyOfWater
    {
    }

    /// <summary>
    /// A reservoir of water, typically an artificially created lake, like the Lake Kariba reservoir.
    /// </summary>
    public partial class Reservoir : BodyOfWater, IReservoir
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Reservoir";
    }
}
