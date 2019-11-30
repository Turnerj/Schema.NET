namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// See AutomotiveBusiness, Store for more information.
    /// </summary>
    public partial interface IAutomotiveBusinessAndStore : IStore, IAutomotiveBusiness
    {
    }

    /// <summary>
    /// See AutomotiveBusiness, Store for more information.
    /// </summary>
    public abstract partial class AutomotiveBusinessAndStore : LocalBusiness, IAutomotiveBusinessAndStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AutomotiveBusinessAndStore";
    }
}
