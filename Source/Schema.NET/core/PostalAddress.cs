namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The mailing address.
    /// </summary>
    public partial interface IPostalAddress : IContactPoint
    {
        /// <summary>
        /// The country. For example, USA. You can also provide the two-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_3166-1"&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt;.
        /// </summary>
        Values<ICountry, string> AddressCountry { get; set; }

        /// <summary>
        /// The locality in which the street address is, and which is in the region. For example, Mountain View.
        /// </summary>
        OneOrMany<string> AddressLocality { get; set; }

        /// <summary>
        /// The region in which the locality is, and which is in the country. For example, California or another appropriate first-level &lt;a href="https://en.wikipedia.org/wiki/List_of_administrative_divisions_by_country"&gt;Administrative division&lt;/a&gt;
        /// </summary>
        OneOrMany<string> AddressRegion { get; set; }

        /// <summary>
        /// The postal code. For example, 94043.
        /// </summary>
        OneOrMany<string> PostalCode { get; set; }

        /// <summary>
        /// The post office box number for PO box addresses.
        /// </summary>
        OneOrMany<string> PostOfficeBoxNumber { get; set; }

        /// <summary>
        /// The street address. For example, 1600 Amphitheatre Pkwy.
        /// </summary>
        OneOrMany<string> StreetAddress { get; set; }
    }

    /// <summary>
    /// The mailing address.
    /// </summary>
    public partial class PostalAddress : ContactPoint, IPostalAddress
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PostalAddress";

        /// <summary>
        /// The country. For example, USA. You can also provide the two-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_3166-1"&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("addressCountry")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICountry, string> AddressCountry { get; set; }

        /// <summary>
        /// The locality in which the street address is, and which is in the region. For example, Mountain View.
        /// </summary>
        [JsonPropertyName("addressLocality")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AddressLocality { get; set; }

        /// <summary>
        /// The region in which the locality is, and which is in the country. For example, California or another appropriate first-level &lt;a href="https://en.wikipedia.org/wiki/List_of_administrative_divisions_by_country"&gt;Administrative division&lt;/a&gt;
        /// </summary>
        [JsonPropertyName("addressRegion")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AddressRegion { get; set; }

        /// <summary>
        /// The postal code. For example, 94043.
        /// </summary>
        [JsonPropertyName("postalCode")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PostalCode { get; set; }

        /// <summary>
        /// The post office box number for PO box addresses.
        /// </summary>
        [JsonPropertyName("postOfficeBoxNumber")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PostOfficeBoxNumber { get; set; }

        /// <summary>
        /// The street address. For example, 1600 Amphitheatre Pkwy.
        /// </summary>
        [JsonPropertyName("streetAddress")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> StreetAddress { get; set; }
    }
}
