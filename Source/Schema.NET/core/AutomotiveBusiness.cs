namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Car repair, sales, or parts.
    /// </summary>
    public partial interface IAutomotiveBusiness : ILocalBusiness
    {
    }

    /// <summary>
    /// Car repair, sales, or parts.
    /// </summary>
    public partial class AutomotiveBusiness : LocalBusiness, IAutomotiveBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AutomotiveBusiness";
    }
}
