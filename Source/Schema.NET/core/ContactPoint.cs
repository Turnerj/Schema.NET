namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A contact point&amp;#x2014;for example, a Customer Complaints department.
    /// </summary>
    public partial interface IContactPoint : IStructuredValue
    {
        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        Values<IAdministrativeArea, IGeoShape, IPlace, string> AreaServed { get; set; }

        /// <summary>
        /// A language someone may use with or at the item, service or place. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        Values<ILanguage, string> AvailableLanguage { get; set; }

        /// <summary>
        /// An option available on this contact point (e.g. a toll-free number or support for hearing-impaired callers).
        /// </summary>
        OneOrMany<ContactPointOption?> ContactOption { get; set; }

        /// <summary>
        /// A person or organization can have different contact points, for different purposes. For example, a sales contact point, a PR contact point and so on. This property is used to specify the kind of contact point.
        /// </summary>
        OneOrMany<string> ContactType { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        OneOrMany<string> Email { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        OneOrMany<string> FaxNumber { get; set; }

        /// <summary>
        /// The hours during which this service or contact is available.
        /// </summary>
        OneOrMany<IOpeningHoursSpecification> HoursAvailable { get; set; }

        /// <summary>
        /// The product or service this support contact point is related to (such as product support for a particular product line). This can be a specific product or product line (e.g. "iPhone") or a general category of products or services (e.g. "smartphones").
        /// </summary>
        Values<IProduct, string> ProductSupported { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        OneOrMany<string> Telephone { get; set; }
    }

    /// <summary>
    /// A contact point&amp;#x2014;for example, a Customer Complaints department.
    /// </summary>
    public partial class ContactPoint : StructuredValue, IContactPoint
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ContactPoint";

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [JsonPropertyName("areaServed")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAdministrativeArea, IGeoShape, IPlace, string> AreaServed { get; set; }

        /// <summary>
        /// A language someone may use with or at the item, service or place. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        [JsonPropertyName("availableLanguage")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ILanguage, string> AvailableLanguage { get; set; }

        /// <summary>
        /// An option available on this contact point (e.g. a toll-free number or support for hearing-impaired callers).
        /// </summary>
        [JsonPropertyName("contactOption")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ContactPointOption?> ContactOption { get; set; }

        /// <summary>
        /// A person or organization can have different contact points, for different purposes. For example, a sales contact point, a PR contact point and so on. This property is used to specify the kind of contact point.
        /// </summary>
        [JsonPropertyName("contactType")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ContactType { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [JsonPropertyName("email")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Email { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [JsonPropertyName("faxNumber")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> FaxNumber { get; set; }

        /// <summary>
        /// The hours during which this service or contact is available.
        /// </summary>
        [JsonPropertyName("hoursAvailable")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOpeningHoursSpecification> HoursAvailable { get; set; }

        /// <summary>
        /// The product or service this support contact point is related to (such as product support for a particular product line). This can be a specific product or product line (e.g. "iPhone") or a general category of products or services (e.g. "smartphones").
        /// </summary>
        [JsonPropertyName("productSupported")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IProduct, string> ProductSupported { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [JsonPropertyName("telephone")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Telephone { get; set; }
    }
}
