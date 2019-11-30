namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A recycling center.
    /// </summary>
    public partial interface IRecyclingCenter : ILocalBusiness
    {
    }

    /// <summary>
    /// A recycling center.
    /// </summary>
    public partial class RecyclingCenter : LocalBusiness, IRecyclingCenter
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "RecyclingCenter";
    }
}
