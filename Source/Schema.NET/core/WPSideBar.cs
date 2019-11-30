namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A sidebar section of the page.
    /// </summary>
    public partial interface IWPSideBar : IWebPageElement
    {
    }

    /// <summary>
    /// A sidebar section of the page.
    /// </summary>
    public partial class WPSideBar : WebPageElement, IWPSideBar
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "WPSideBar";
    }
}
