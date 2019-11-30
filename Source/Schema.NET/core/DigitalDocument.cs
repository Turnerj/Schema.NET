namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An electronic file or document.
    /// </summary>
    public partial interface IDigitalDocument : ICreativeWork
    {
        /// <summary>
        /// A permission related to the access to this document (e.g. permission to read or write an electronic document). For a public document, specify a grantee with an Audience with audienceType equal to "public".
        /// </summary>
        OneOrMany<IDigitalDocumentPermission> HasDigitalDocumentPermission { get; set; }
    }

    /// <summary>
    /// An electronic file or document.
    /// </summary>
    public partial class DigitalDocument : CreativeWork, IDigitalDocument
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DigitalDocument";

        /// <summary>
        /// A permission related to the access to this document (e.g. permission to read or write an electronic document). For a public document, specify a grantee with an Audience with audienceType equal to "public".
        /// </summary>
        [JsonPropertyName("hasDigitalDocumentPermission")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDigitalDocumentPermission> HasDigitalDocumentPermission { get; set; }
    }
}
