namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A church.
    /// </summary>
    public partial interface IChurch : IPlaceOfWorship
    {
    }

    /// <summary>
    /// A church.
    /// </summary>
    public partial class Church : PlaceOfWorship, IChurch
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Church";
    }
}
