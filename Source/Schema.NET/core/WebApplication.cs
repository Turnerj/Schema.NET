namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Web applications.
    /// </summary>
    public partial interface IWebApplication : ISoftwareApplication
    {
        /// <summary>
        /// Specifies browser requirements in human-readable text. For example, 'requires HTML5 support'.
        /// </summary>
        OneOrMany<string> BrowserRequirements { get; set; }
    }

    /// <summary>
    /// Web applications.
    /// </summary>
    public partial class WebApplication : SoftwareApplication, IWebApplication
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "WebApplication";

        /// <summary>
        /// Specifies browser requirements in human-readable text. For example, 'requires HTML5 support'.
        /// </summary>
        [JsonPropertyName("browserRequirements")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BrowserRequirements { get; set; }
    }
}
