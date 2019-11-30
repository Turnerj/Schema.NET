namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Web page type: Collection page.
    /// </summary>
    public partial interface ICollectionPage : IWebPage
    {
    }

    /// <summary>
    /// Web page type: Collection page.
    /// </summary>
    public partial class CollectionPage : WebPage, ICollectionPage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "CollectionPage";
    }
}
