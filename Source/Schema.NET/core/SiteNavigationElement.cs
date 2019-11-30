namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A navigation element of the page.
    /// </summary>
    public partial interface ISiteNavigationElement : IWebPageElement
    {
    }

    /// <summary>
    /// A navigation element of the page.
    /// </summary>
    public partial class SiteNavigationElement : WebPageElement, ISiteNavigationElement
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "SiteNavigationElement";
    }
}
