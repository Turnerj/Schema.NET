namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A structured value providing information about the opening hours of a place or a certain service inside a place.&lt;br/&gt;&lt;br/&gt;
    /// The place is &lt;strong&gt;open&lt;/strong&gt; if the &lt;a class="localLink" href="http://schema.org/opens"&gt;opens&lt;/a&gt; property is specified, and &lt;strong&gt;closed&lt;/strong&gt; otherwise.&lt;br/&gt;&lt;br/&gt;
    /// If the value for the &lt;a class="localLink" href="http://schema.org/closes"&gt;closes&lt;/a&gt; property is less than the value for the &lt;a class="localLink" href="http://schema.org/opens"&gt;opens&lt;/a&gt; property then the hour range is assumed to span over the next day.
    /// </summary>
    public partial interface IOpeningHoursSpecification : IStructuredValue
    {
        /// <summary>
        /// The closing hour of the place or service on the given day(s) of the week.
        /// </summary>
        OneOrMany<TimeSpan?> Closes { get; set; }

        /// <summary>
        /// The day of the week for which these opening hours are valid.
        /// </summary>
        OneOrMany<DayOfWeek?> DayOfWeek { get; set; }

        /// <summary>
        /// The opening hour of the place or service on the given day(s) of the week.
        /// </summary>
        OneOrMany<TimeSpan?> Opens { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }
    }

    /// <summary>
    /// A structured value providing information about the opening hours of a place or a certain service inside a place.&lt;br/&gt;&lt;br/&gt;
    /// The place is &lt;strong&gt;open&lt;/strong&gt; if the &lt;a class="localLink" href="http://schema.org/opens"&gt;opens&lt;/a&gt; property is specified, and &lt;strong&gt;closed&lt;/strong&gt; otherwise.&lt;br/&gt;&lt;br/&gt;
    /// If the value for the &lt;a class="localLink" href="http://schema.org/closes"&gt;closes&lt;/a&gt; property is less than the value for the &lt;a class="localLink" href="http://schema.org/opens"&gt;opens&lt;/a&gt; property then the hour range is assumed to span over the next day.
    /// </summary>
    public partial class OpeningHoursSpecification : StructuredValue, IOpeningHoursSpecification
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "OpeningHoursSpecification";

        /// <summary>
        /// The closing hour of the place or service on the given day(s) of the week.
        /// </summary>
        [JsonPropertyName("closes")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<TimeSpan?> Closes { get; set; }

        /// <summary>
        /// The day of the week for which these opening hours are valid.
        /// </summary>
        [JsonPropertyName("dayOfWeek")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DayOfWeek?> DayOfWeek { get; set; }

        /// <summary>
        /// The opening hour of the place or service on the given day(s) of the week.
        /// </summary>
        [JsonPropertyName("opens")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<TimeSpan?> Opens { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [JsonPropertyName("validFrom")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [JsonPropertyName("validThrough")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }
    }
}
