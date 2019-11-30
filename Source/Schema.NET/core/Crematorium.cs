namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A crematorium.
    /// </summary>
    public partial interface ICrematorium : ICivicStructure
    {
    }

    /// <summary>
    /// A crematorium.
    /// </summary>
    public partial class Crematorium : CivicStructure, ICrematorium
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Crematorium";
    }
}
