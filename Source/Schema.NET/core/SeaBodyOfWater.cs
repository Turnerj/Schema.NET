namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A sea (for example, the Caspian sea).
    /// </summary>
    public partial interface ISeaBodyOfWater : IBodyOfWater
    {
    }

    /// <summary>
    /// A sea (for example, the Caspian sea).
    /// </summary>
    public partial class SeaBodyOfWater : BodyOfWater, ISeaBodyOfWater
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "SeaBodyOfWater";
    }
}
