namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A music video file.
    /// </summary>
    public partial interface IMusicVideoObject : IMediaObject
    {
    }

    /// <summary>
    /// A music video file.
    /// </summary>
    public partial class MusicVideoObject : MediaObject, IMusicVideoObject
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MusicVideoObject";
    }
}
