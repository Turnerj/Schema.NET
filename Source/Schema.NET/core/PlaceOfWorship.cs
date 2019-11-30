namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Place of worship, such as a church, synagogue, or mosque.
    /// </summary>
    public partial interface IPlaceOfWorship : ICivicStructure
    {
    }

    /// <summary>
    /// Place of worship, such as a church, synagogue, or mosque.
    /// </summary>
    public partial class PlaceOfWorship : CivicStructure, IPlaceOfWorship
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PlaceOfWorship";
    }
}
