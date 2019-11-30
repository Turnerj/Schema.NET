﻿namespace Schema.NET
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The kind of release which this album is: single, EP or album.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MusicAlbumReleaseType
    {
        /// <summary>
        /// AlbumRelease.
        /// </summary>
        [EnumMember(Value = "https://schema.org/AlbumRelease")]
        AlbumRelease,

        /// <summary>
        /// BroadcastRelease.
        /// </summary>
        [EnumMember(Value = "https://schema.org/BroadcastRelease")]
        BroadcastRelease,

        /// <summary>
        /// EPRelease.
        /// </summary>
        [EnumMember(Value = "https://schema.org/EPRelease")]
        EPRelease,

        /// <summary>
        /// SingleRelease.
        /// </summary>
        [EnumMember(Value = "https://schema.org/SingleRelease")]
        SingleRelease
    }
}
