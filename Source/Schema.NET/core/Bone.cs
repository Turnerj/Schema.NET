namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Rigid connective tissue that comprises up the skeletal structure of the human body.
    /// </summary>
    public partial interface IBone : IAnatomicalStructure
    {
    }

    /// <summary>
    /// Rigid connective tissue that comprises up the skeletal structure of the human body.
    /// </summary>
    public partial class Bone : AnatomicalStructure, IBone
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Bone";
    }
}
