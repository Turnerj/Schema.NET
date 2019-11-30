namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Web page type: About page.
    /// </summary>
    public partial interface IAboutPage : IWebPage
    {
    }

    /// <summary>
    /// Web page type: About page.
    /// </summary>
    public partial class AboutPage : WebPage, IAboutPage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AboutPage";
    }
}
