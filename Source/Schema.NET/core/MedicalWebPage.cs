namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A web page that provides medical information.
    /// </summary>
    public partial interface IMedicalWebPage : IWebPage
    {
    }

    /// <summary>
    /// A web page that provides medical information.
    /// </summary>
    public partial class MedicalWebPage : WebPage, IMedicalWebPage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MedicalWebPage";
    }
}
