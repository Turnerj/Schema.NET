namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A synagogue.
    /// </summary>
    public partial interface ISynagogue : IPlaceOfWorship
    {
    }

    /// <summary>
    /// A synagogue.
    /// </summary>
    public partial class Synagogue : PlaceOfWorship, ISynagogue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Synagogue";
    }
}
