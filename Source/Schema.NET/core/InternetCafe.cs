namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An internet cafe.
    /// </summary>
    public partial interface IInternetCafe : ILocalBusiness
    {
    }

    /// <summary>
    /// An internet cafe.
    /// </summary>
    public partial class InternetCafe : LocalBusiness, IInternetCafe
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "InternetCafe";
    }
}
