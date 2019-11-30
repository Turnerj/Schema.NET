namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A theater group or company, for example, the Royal Shakespeare Company or Druid Theatre.
    /// </summary>
    public partial interface ITheaterGroup : IPerformingGroup
    {
    }

    /// <summary>
    /// A theater group or company, for example, the Royal Shakespeare Company or Druid Theatre.
    /// </summary>
    public partial class TheaterGroup : PerformingGroup, ITheaterGroup
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "TheaterGroup";
    }
}
