﻿namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The artwork on the outer surface of a CreativeWork.
    /// </summary>
    public partial interface ICoverArt : IVisualArtwork
    {
    }

    /// <summary>
    /// The artwork on the outer surface of a CreativeWork.
    /// </summary>
    public partial class CoverArt : VisualArtwork, ICoverArt
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "CoverArt";
    }
}
