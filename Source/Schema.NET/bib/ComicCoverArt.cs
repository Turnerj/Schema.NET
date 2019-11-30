﻿namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The artwork on the cover of a comic.
    /// </summary>
    public partial interface IComicCoverArt : IComicStoryAndCoverArt
    {
    }

    /// <summary>
    /// The artwork on the cover of a comic.
    /// </summary>
    public partial class ComicCoverArt : ComicStoryAndCoverArt, IComicCoverArt
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ComicCoverArt";
    }
}
