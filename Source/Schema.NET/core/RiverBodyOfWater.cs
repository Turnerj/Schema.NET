namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A river (for example, the broad majestic Shannon).
    /// </summary>
    public partial interface IRiverBodyOfWater : IBodyOfWater
    {
    }

    /// <summary>
    /// A river (for example, the broad majestic Shannon).
    /// </summary>
    public partial class RiverBodyOfWater : BodyOfWater, IRiverBodyOfWater
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "RiverBodyOfWater";
    }
}
