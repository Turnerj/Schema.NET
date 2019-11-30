namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A short TV program or a segment/part of a TV program.
    /// </summary>
    public partial interface ITVClip : IClip
    {
    }

    /// <summary>
    /// A short TV program or a segment/part of a TV program.
    /// </summary>
    public partial class TVClip : Clip, ITVClip
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "TVClip";
    }
}
