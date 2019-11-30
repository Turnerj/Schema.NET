﻿namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An explanation in the instructions for how to achieve a result. It provides supplementary information about a technique, supply, author's preference, etc. It can explain what could be done, or what should not be done, but doesn't specify what should be done (see HowToDirection).
    /// </summary>
    public partial interface IHowToTip : ICreativeWorkAndListItem
    {
    }

    /// <summary>
    /// An explanation in the instructions for how to achieve a result. It provides supplementary information about a technique, supply, author's preference, etc. It can explain what could be done, or what should not be done, but doesn't specify what should be done (see HowToDirection).
    /// </summary>
    public partial class HowToTip : CreativeWorkAndListItem, IHowToTip
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "HowToTip";
    }
}
