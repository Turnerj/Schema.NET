namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A lake (for example, Lake Pontrachain).
    /// </summary>
    public partial interface ILakeBodyOfWater : IBodyOfWater
    {
    }

    /// <summary>
    /// A lake (for example, Lake Pontrachain).
    /// </summary>
    public partial class LakeBodyOfWater : BodyOfWater, ILakeBodyOfWater
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "LakeBodyOfWater";
    }
}
