namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
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
    [DataContract]
    public partial class ContactPage : WebPage, IContactPage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ContactPage";
    }
}
