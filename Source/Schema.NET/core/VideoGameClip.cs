﻿namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A short segment/part of a video game.
    /// </summary>
    public partial interface IVideoGameClip : IClip
    {
    }

    /// <summary>
    /// A short segment/part of a video game.
    /// </summary>
    public partial class VideoGameClip : Clip, IVideoGameClip
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "VideoGameClip";
    }
}
