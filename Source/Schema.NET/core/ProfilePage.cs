namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Web page type: Profile page.
    /// </summary>
    public partial interface IProfilePage : IWebPage
    {
    }

    /// <summary>
    /// Web page type: Profile page.
    /// </summary>
    public partial class ProfilePage : WebPage, IProfilePage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ProfilePage";
    }
}
