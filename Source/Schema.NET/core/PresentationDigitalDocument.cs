namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A file containing slides or used for a presentation.
    /// </summary>
    public partial interface IPresentationDigitalDocument : IDigitalDocument
    {
    }

    /// <summary>
    /// A file containing slides or used for a presentation.
    /// </summary>
    public partial class PresentationDigitalDocument : DigitalDocument, IPresentationDigitalDocument
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PresentationDigitalDocument";
    }
}
