namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Professional service: Attorney. &lt;br/&gt;&lt;br/&gt;
    /// This type is deprecated - &lt;a class="localLink" href="http://schema.org/LegalService"&gt;LegalService&lt;/a&gt; is more inclusive and less ambiguous.
    /// </summary>
    public partial interface IAttorney : ILegalService
    {
    }

    /// <summary>
    /// Professional service: Attorney. &lt;br/&gt;&lt;br/&gt;
    /// This type is deprecated - &lt;a class="localLink" href="http://schema.org/LegalService"&gt;LegalService&lt;/a&gt; is more inclusive and less ambiguous.
    /// </summary>
    public partial class Attorney : LegalService, IAttorney
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Attorney";
    }
}
