﻿namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A Hindu temple.
    /// </summary>
    public partial interface IHinduTemple : IPlaceOfWorship
    {
    }

    /// <summary>
    /// A Hindu temple.
    /// </summary>
    public partial class HinduTemple : PlaceOfWorship, IHinduTemple
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "HinduTemple";
    }
}
