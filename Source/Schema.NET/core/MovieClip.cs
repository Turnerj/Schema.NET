namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A short segment/part of a movie.
    /// </summary>
    public partial interface IMovieClip : IClip
    {
    }

    /// <summary>
    /// A short segment/part of a movie.
    /// </summary>
    public partial class MovieClip : Clip, IMovieClip
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MovieClip";
    }
}
