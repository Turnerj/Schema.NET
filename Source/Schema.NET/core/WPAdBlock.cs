namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An advertising section of the page.
    /// </summary>
    public partial interface IWPAdBlock : IWebPageElement
    {
    }

    /// <summary>
    /// An advertising section of the page.
    /// </summary>
    public partial class WPAdBlock : WebPageElement, IWPAdBlock
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "WPAdBlock";
    }
}
