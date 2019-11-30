namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A mosque.
    /// </summary>
    public partial interface IMosque : IPlaceOfWorship
    {
    }

    /// <summary>
    /// A mosque.
    /// </summary>
    public partial class Mosque : PlaceOfWorship, IMosque
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Mosque";
    }
}
