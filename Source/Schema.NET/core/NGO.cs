namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Organization: Non-governmental Organization.
    /// </summary>
    public partial interface INGO : IOrganization
    {
    }

    /// <summary>
    /// Organization: Non-governmental Organization.
    /// </summary>
    public partial class NGO : Organization, INGO
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "NGO";
    }
}
