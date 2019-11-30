namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A public swimming pool.
    /// </summary>
    public partial interface IPublicSwimmingPool : ISportsActivityLocation
    {
    }

    /// <summary>
    /// A public swimming pool.
    /// </summary>
    public partial class PublicSwimmingPool : SportsActivityLocation, IPublicSwimmingPool
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PublicSwimmingPool";
    }
}
