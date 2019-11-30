namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A means for accessing a service, e.g. a government office location, web site, or phone number.
    /// </summary>
    public partial interface IServiceChannel : IIntangible
    {
        /// <summary>
        /// A language someone may use with or at the item, service or place. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        Values<ILanguage, string> AvailableLanguage { get; set; }

        /// <summary>
        /// Estimated processing time for the service using this channel.
        /// </summary>
        OneOrMany<TimeSpan?> ProcessingTime { get; set; }

        /// <summary>
        /// The service provided by this channel.
        /// </summary>
        OneOrMany<IService> ProvidesService { get; set; }

        /// <summary>
        /// The location (e.g. civic structure, local business, etc.) where a person can go to access the service.
        /// </summary>
        OneOrMany<IPlace> ServiceLocation { get; set; }

        /// <summary>
        /// The phone number to use to access the service.
        /// </summary>
        OneOrMany<IContactPoint> ServicePhone { get; set; }

        /// <summary>
        /// The address for accessing the service by mail.
        /// </summary>
        OneOrMany<IPostalAddress> ServicePostalAddress { get; set; }

        /// <summary>
        /// The number to access the service by text message.
        /// </summary>
        OneOrMany<IContactPoint> ServiceSmsNumber { get; set; }

        /// <summary>
        /// The website to access the service.
        /// </summary>
        OneOrMany<Uri> ServiceUrl { get; set; }
    }

    /// <summary>
    /// A means for accessing a service, e.g. a government office location, web site, or phone number.
    /// </summary>
    public partial class ServiceChannel : Intangible, IServiceChannel
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ServiceChannel";

        /// <summary>
        /// A language someone may use with or at the item, service or place. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        [JsonPropertyName("availableLanguage")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ILanguage, string> AvailableLanguage { get; set; }

        /// <summary>
        /// Estimated processing time for the service using this channel.
        /// </summary>
        [JsonPropertyName("processingTime")]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public OneOrMany<TimeSpan?> ProcessingTime { get; set; }

        /// <summary>
        /// The service provided by this channel.
        /// </summary>
        [JsonPropertyName("providesService")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IService> ProvidesService { get; set; }

        /// <summary>
        /// The location (e.g. civic structure, local business, etc.) where a person can go to access the service.
        /// </summary>
        [JsonPropertyName("serviceLocation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> ServiceLocation { get; set; }

        /// <summary>
        /// The phone number to use to access the service.
        /// </summary>
        [JsonPropertyName("servicePhone")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IContactPoint> ServicePhone { get; set; }

        /// <summary>
        /// The address for accessing the service by mail.
        /// </summary>
        [JsonPropertyName("servicePostalAddress")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPostalAddress> ServicePostalAddress { get; set; }

        /// <summary>
        /// The number to access the service by text message.
        /// </summary>
        [JsonPropertyName("serviceSmsNumber")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IContactPoint> ServiceSmsNumber { get; set; }

        /// <summary>
        /// The website to access the service.
        /// </summary>
        [JsonPropertyName("serviceUrl")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> ServiceUrl { get; set; }
    }
}
