namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The footer section of the page.
    /// </summary>
    public partial interface IWPFooter : IWebPageElement
    {
    }

    /// <summary>
    /// The footer section of the page.
    /// </summary>
    public partial class WPFooter : WebPageElement, IWPFooter
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "WPFooter";
    }
}
