namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A body of water, such as a sea, ocean, or lake.
    /// </summary>
    public partial interface IBodyOfWater : ILandform
    {
    }

    /// <summary>
    /// A body of water, such as a sea, ocean, or lake.
    /// </summary>
    public partial class BodyOfWater : Landform, IBodyOfWater
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "BodyOfWater";
    }
}
