namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A map.
    /// </summary>
    public partial interface IMap : ICreativeWork
    {
        /// <summary>
        /// Indicates the kind of Map, from the MapCategoryType Enumeration.
        /// </summary>
        OneOrMany<MapCategoryType?> MapType { get; set; }
    }

    /// <summary>
    /// A map.
    /// </summary>
    public partial class Map : CreativeWork, IMap
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Map";

        /// <summary>
        /// Indicates the kind of Map, from the MapCategoryType Enumeration.
        /// </summary>
        [JsonPropertyName("mapType")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<MapCategoryType?> MapType { get; set; }
    }
}
