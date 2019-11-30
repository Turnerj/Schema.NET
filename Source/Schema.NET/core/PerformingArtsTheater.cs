namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A theater or other performing art center.
    /// </summary>
    public partial interface IPerformingArtsTheater : ICivicStructure
    {
    }

    /// <summary>
    /// A theater or other performing art center.
    /// </summary>
    public partial class PerformingArtsTheater : CivicStructure, IPerformingArtsTheater
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PerformingArtsTheater";
    }
}
