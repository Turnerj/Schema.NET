namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A review of an item - for example, of a restaurant, movie, or store.
    /// </summary>
    public partial interface IReview : ICreativeWork
    {
        /// <summary>
        /// The item that is being reviewed/rated.
        /// </summary>
        OneOrMany<IThing> ItemReviewed { get; set; }

        /// <summary>
        /// This Review or Rating is relevant to this part or facet of the itemReviewed.
        /// </summary>
        OneOrMany<string> ReviewAspect { get; set; }

        /// <summary>
        /// The actual body of the review.
        /// </summary>
        OneOrMany<string> ReviewBody { get; set; }

        /// <summary>
        /// The rating given in this review. Note that reviews can themselves be rated. The &lt;code&gt;reviewRating&lt;/code&gt; applies to rating given by the review. The &lt;a class="localLink" href="http://schema.org/aggregateRating"&gt;aggregateRating&lt;/a&gt; property applies to the review itself, as a creative work.
        /// </summary>
        OneOrMany<IRating> ReviewRating { get; set; }
    }

    /// <summary>
    /// A review of an item - for example, of a restaurant, movie, or store.
    /// </summary>
    public partial class Review : CreativeWork, IReview
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Review";

        /// <summary>
        /// The item that is being reviewed/rated.
        /// </summary>
        [JsonPropertyName("itemReviewed")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> ItemReviewed { get; set; }

        /// <summary>
        /// This Review or Rating is relevant to this part or facet of the itemReviewed.
        /// </summary>
        [JsonPropertyName("reviewAspect")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ReviewAspect { get; set; }

        /// <summary>
        /// The actual body of the review.
        /// </summary>
        [JsonPropertyName("reviewBody")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ReviewBody { get; set; }

        /// <summary>
        /// The rating given in this review. Note that reviews can themselves be rated. The &lt;code&gt;reviewRating&lt;/code&gt; applies to rating given by the review. The &lt;a class="localLink" href="http://schema.org/aggregateRating"&gt;aggregateRating&lt;/a&gt; property applies to the review itself, as a creative work.
        /// </summary>
        [JsonPropertyName("reviewRating")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IRating> ReviewRating { get; set; }
    }
}
