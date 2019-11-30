namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A short radio program or a segment/part of a radio program.
    /// </summary>
    public partial interface IRadioClip : IClip
    {
    }

    /// <summary>
    /// A short radio program or a segment/part of a radio program.
    /// </summary>
    public partial class RadioClip : Clip, IRadioClip
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "RadioClip";
    }
}
