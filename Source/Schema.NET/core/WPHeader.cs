namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The header section of the page.
    /// </summary>
    public partial interface IWPHeader : IWebPageElement
    {
    }

    /// <summary>
    /// The header section of the page.
    /// </summary>
    public partial class WPHeader : WebPageElement, IWPHeader
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "WPHeader";
    }
}
