namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A performance group, such as a band, an orchestra, or a circus.
    /// </summary>
    public partial interface IPerformingGroup : IOrganization
    {
    }

    /// <summary>
    /// A performance group, such as a band, an orchestra, or a circus.
    /// </summary>
    public partial class PerformingGroup : Organization, IPerformingGroup
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PerformingGroup";
    }
}
