namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A photograph.
    /// </summary>
    public partial interface IPhotograph : ICreativeWork
    {
    }

    /// <summary>
    /// A photograph.
    /// </summary>
    public partial class Photograph : CreativeWork, IPhotograph
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Photograph";
    }
}
