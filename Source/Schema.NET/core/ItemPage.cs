namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A page devoted to a single item, such as a particular product or hotel.
    /// </summary>
    public partial interface IItemPage : IWebPage
    {
    }

    /// <summary>
    /// A page devoted to a single item, such as a particular product or hotel.
    /// </summary>
    public partial class ItemPage : WebPage, IItemPage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ItemPage";
    }
}
