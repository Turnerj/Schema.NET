namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A painting.
    /// </summary>
    public partial interface IPainting : ICreativeWork
    {
    }

    /// <summary>
    /// A painting.
    /// </summary>
    public partial class Painting : CreativeWork, IPainting
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Painting";
    }
}
