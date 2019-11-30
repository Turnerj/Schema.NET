namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A self-storage facility.
    /// </summary>
    public partial interface ISelfStorage : ILocalBusiness
    {
    }

    /// <summary>
    /// A self-storage facility.
    /// </summary>
    public partial class SelfStorage : LocalBusiness, ISelfStorage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "SelfStorage";
    }
}
