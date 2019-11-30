namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The geographic coordinates of a place or event.
    /// </summary>
    public partial interface IGeoCoordinates : IStructuredValue
    {
        /// <summary>
        /// Physical address of the item.
        /// </summary>
        Values<IPostalAddress, string> Address { get; set; }

        /// <summary>
        /// The country. For example, USA. You can also provide the two-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_3166-1"&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt;.
        /// </summary>
        Values<ICountry, string> AddressCountry { get; set; }

        /// <summary>
        /// The elevation of a location (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;). Values may be of the form 'NUMBER UNIT&lt;em&gt;OF&lt;/em&gt;MEASUREMENT' (e.g., '1,000 m', '3,200 ft') while numbers alone should be assumed to be a value in meters.
        /// </summary>
        Values<double?, string> Elevation { get; set; }

        /// <summary>
        /// The latitude of a location. For example &lt;code&gt;37.42242&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        Values<double?, string> Latitude { get; set; }

        /// <summary>
        /// The longitude of a location. For example &lt;code&gt;-122.08585&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        Values<double?, string> Longitude { get; set; }

        /// <summary>
        /// The postal code. For example, 94043.
        /// </summary>
        OneOrMany<string> PostalCode { get; set; }
    }

    /// <summary>
    /// The geographic coordinates of a place or event.
    /// </summary>
    public partial class GeoCoordinates : StructuredValue, IGeoCoordinates
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "GeoCoordinates";

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [JsonPropertyName("address")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPostalAddress, string> Address { get; set; }

        /// <summary>
        /// The country. For example, USA. You can also provide the two-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_3166-1"&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("addressCountry")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICountry, string> AddressCountry { get; set; }

        /// <summary>
        /// The elevation of a location (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;). Values may be of the form 'NUMBER UNIT&lt;em&gt;OF&lt;/em&gt;MEASUREMENT' (e.g., '1,000 m', '3,200 ft') while numbers alone should be assumed to be a value in meters.
        /// </summary>
        [JsonPropertyName("elevation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, string> Elevation { get; set; }

        /// <summary>
        /// The latitude of a location. For example &lt;code&gt;37.42242&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [JsonPropertyName("latitude")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, string> Latitude { get; set; }

        /// <summary>
        /// The longitude of a location. For example &lt;code&gt;-122.08585&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [JsonPropertyName("longitude")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, string> Longitude { get; set; }

        /// <summary>
        /// The postal code. For example, 94043.
        /// </summary>
        [JsonPropertyName("postalCode")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PostalCode { get; set; }
    }
}
