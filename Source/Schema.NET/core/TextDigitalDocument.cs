namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A file composed primarily of text.
    /// </summary>
    public partial interface ITextDigitalDocument : IDigitalDocument
    {
    }

    /// <summary>
    /// A file composed primarily of text.
    /// </summary>
    public partial class TextDigitalDocument : DigitalDocument, ITextDigitalDocument
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "TextDigitalDocument";
    }
}
