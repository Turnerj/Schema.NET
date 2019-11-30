namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Web page type: Search results page.
    /// </summary>
    public partial interface ISearchResultsPage : IWebPage
    {
    }

    /// <summary>
    /// Web page type: Search results page.
    /// </summary>
    public partial class SearchResultsPage : WebPage, ISearchResultsPage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "SearchResultsPage";
    }
}
