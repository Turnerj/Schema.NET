namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The average rating based on multiple ratings or reviews.
    /// </summary>
    public partial interface IAggregateRating : IRating
    {
        /// <summary>
        /// The item that is being reviewed/rated.
        /// </summary>
        OneOrMany<IThing> ItemReviewed { get; set; }

        /// <summary>
        /// The count of total number of ratings.
        /// </summary>
        OneOrMany<int?> RatingCount { get; set; }

        /// <summary>
        /// The count of total number of reviews.
        /// </summary>
        OneOrMany<int?> ReviewCount { get; set; }
    }

    /// <summary>
    /// The average rating based on multiple ratings or reviews.
    /// </summary>
    public partial class AggregateRating : Rating, IAggregateRating
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AggregateRating";

        /// <summary>
        /// The item that is being reviewed/rated.
        /// </summary>
        [JsonPropertyName("itemReviewed")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> ItemReviewed { get; set; }

        /// <summary>
        /// The count of total number of ratings.
        /// </summary>
        [JsonPropertyName("ratingCount")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> RatingCount { get; set; }

        /// <summary>
        /// The count of total number of reviews.
        /// </summary>
        [JsonPropertyName("reviewCount")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> ReviewCount { get; set; }
    }
}
