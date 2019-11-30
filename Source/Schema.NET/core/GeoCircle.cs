namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A GeoCircle is a GeoShape representing a circular geographic area. As it is a GeoShape
    ///           it provides the simple textual property 'circle', but also allows the combination of postalCode alongside geoRadius.
    ///           The center of the circle can be indicated via the 'geoMidpoint' property, or more approximately using 'address', 'postalCode'.
    /// </summary>
    public partial interface IGeoCircle : IGeoShape
    {
        /// <summary>
        /// Indicates the GeoCoordinates at the centre of a GeoShape e.g. GeoCircle.
        /// </summary>
        OneOrMany<IGeoCoordinates> GeoMidpoint { get; set; }

        /// <summary>
        /// Indicates the approximate radius of a GeoCircle (metres unless indicated otherwise via Distance notation).
        /// </summary>
        Values<string, double?, string> GeoRadius { get; set; }
    }

    /// <summary>
    /// A GeoCircle is a GeoShape representing a circular geographic area. As it is a GeoShape
    ///           it provides the simple textual property 'circle', but also allows the combination of postalCode alongside geoRadius.
    ///           The center of the circle can be indicated via the 'geoMidpoint' property, or more approximately using 'address', 'postalCode'.
    /// </summary>
    public partial class GeoCircle : GeoShape, IGeoCircle
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "GeoCircle";

        /// <summary>
        /// Indicates the GeoCoordinates at the centre of a GeoShape e.g. GeoCircle.
        /// </summary>
        [JsonPropertyName("geoMidpoint")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IGeoCoordinates> GeoMidpoint { get; set; }

        /// <summary>
        /// Indicates the approximate radius of a GeoCircle (metres unless indicated otherwise via Distance notation).
        /// </summary>
        [JsonPropertyName("geoRadius")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, double?, string> GeoRadius { get; set; }
    }
}
