namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A mountain, like Mount Whitney or Mount Everest.
    /// </summary>
    public partial interface IMountain : ILandform
    {
    }

    /// <summary>
    /// A mountain, like Mount Whitney or Mount Everest.
    /// </summary>
    public partial class Mountain : Landform, IMountain
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Mountain";
    }
}
