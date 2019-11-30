namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A permit issued by an organization, e.g. a parking pass.
    /// </summary>
    public partial interface IPermit : IIntangible
    {
        /// <summary>
        /// The organization issuing the ticket or permit.
        /// </summary>
        OneOrMany<IOrganization> IssuedBy { get; set; }

        /// <summary>
        /// The service through with the permit was granted.
        /// </summary>
        OneOrMany<IService> IssuedThrough { get; set; }

        /// <summary>
        /// The target audience for this permit.
        /// </summary>
        OneOrMany<IAudience> PermitAudience { get; set; }

        /// <summary>
        /// The duration of validity of a permit or similar thing.
        /// </summary>
        OneOrMany<TimeSpan?> ValidFor { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> ValidFrom { get; set; }

        /// <summary>
        /// The geographic area where a permit or similar thing is valid.
        /// </summary>
        OneOrMany<IAdministrativeArea> ValidIn { get; set; }

        /// <summary>
        /// The date when the item is no longer valid.
        /// </summary>
        Values<int?, DateTime?> ValidUntil { get; set; }
    }

    /// <summary>
    /// A permit issued by an organization, e.g. a parking pass.
    /// </summary>
    public partial class Permit : Intangible, IPermit
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Permit";

        /// <summary>
        /// The organization issuing the ticket or permit.
        /// </summary>
        [JsonPropertyName("issuedBy")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> IssuedBy { get; set; }

        /// <summary>
        /// The service through with the permit was granted.
        /// </summary>
        [JsonPropertyName("issuedThrough")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IService> IssuedThrough { get; set; }

        /// <summary>
        /// The target audience for this permit.
        /// </summary>
        [JsonPropertyName("permitAudience")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAudience> PermitAudience { get; set; }

        /// <summary>
        /// The duration of validity of a permit or similar thing.
        /// </summary>
        [JsonPropertyName("validFor")]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public OneOrMany<TimeSpan?> ValidFor { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [JsonPropertyName("validFrom")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> ValidFrom { get; set; }

        /// <summary>
        /// The geographic area where a permit or similar thing is valid.
        /// </summary>
        [JsonPropertyName("validIn")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAdministrativeArea> ValidIn { get; set; }

        /// <summary>
        /// The date when the item is no longer valid.
        /// </summary>
        [JsonPropertyName("validUntil")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> ValidUntil { get; set; }
    }
}
