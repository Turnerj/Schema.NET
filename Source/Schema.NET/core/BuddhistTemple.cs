namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A Buddhist temple.
    /// </summary>
    public partial interface IBuddhistTemple : IPlaceOfWorship
    {
    }

    /// <summary>
    /// A Buddhist temple.
    /// </summary>
    public partial class BuddhistTemple : PlaceOfWorship, IBuddhistTemple
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "BuddhistTemple";
    }
}
