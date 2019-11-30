namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A set of characteristics belonging to businesses, e.g. who compose an item's target audience.
    /// </summary>
    public partial interface IBusinessAudience : IAudience
    {
        /// <summary>
        /// The number of employees in an organization e.g. business.
        /// </summary>
        OneOrMany<IQuantitativeValue> NumberOfEmployees { get; set; }

        /// <summary>
        /// The size of the business in annual revenue.
        /// </summary>
        OneOrMany<IQuantitativeValue> YearlyRevenue { get; set; }

        /// <summary>
        /// The age of the business.
        /// </summary>
        OneOrMany<IQuantitativeValue> YearsInOperation { get; set; }
    }

    /// <summary>
    /// A set of characteristics belonging to businesses, e.g. who compose an item's target audience.
    /// </summary>
    public partial class BusinessAudience : Audience, IBusinessAudience
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "BusinessAudience";

        /// <summary>
        /// The number of employees in an organization e.g. business.
        /// </summary>
        [JsonPropertyName("numberOfEmployees")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> NumberOfEmployees { get; set; }

        /// <summary>
        /// The size of the business in annual revenue.
        /// </summary>
        [JsonPropertyName("yearlyRevenue")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> YearlyRevenue { get; set; }

        /// <summary>
        /// The age of the business.
        /// </summary>
        [JsonPropertyName("yearsInOperation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> YearsInOperation { get; set; }
    }
}
