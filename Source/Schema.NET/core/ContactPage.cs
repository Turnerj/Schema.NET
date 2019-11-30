namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Web page type: Contact page.
    /// </summary>
    public partial interface IContactPage : IWebPage
    {
    }

    /// <summary>
    /// Web page type: Contact page.
    /// </summary>
    public partial class ContactPage : WebPage, IContactPage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ContactPage";
    }
}
