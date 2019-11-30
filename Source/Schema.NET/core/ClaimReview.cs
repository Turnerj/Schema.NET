namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A fact-checking review of claims made (or reported) in some creative work (referenced via itemReviewed).
    /// </summary>
    public partial interface IClaimReview : IReview
    {
        /// <summary>
        /// A short summary of the specific claims reviewed in a ClaimReview.
        /// </summary>
        OneOrMany<string> ClaimReviewed { get; set; }
    }

    /// <summary>
    /// A fact-checking review of claims made (or reported) in some creative work (referenced via itemReviewed).
    /// </summary>
    public partial class ClaimReview : Review, IClaimReview
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ClaimReview";

        /// <summary>
        /// A short summary of the specific claims reviewed in a ClaimReview.
        /// </summary>
        [JsonPropertyName("claimReviewed")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ClaimReviewed { get; set; }
    }
}
