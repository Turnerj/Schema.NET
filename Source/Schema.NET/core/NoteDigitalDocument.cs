namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A file containing a note, primarily for the author.
    /// </summary>
    public partial interface INoteDigitalDocument : IDigitalDocument
    {
    }

    /// <summary>
    /// A file containing a note, primarily for the author.
    /// </summary>
    public partial class NoteDigitalDocument : DigitalDocument, INoteDigitalDocument
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "NoteDigitalDocument";
    }
}
