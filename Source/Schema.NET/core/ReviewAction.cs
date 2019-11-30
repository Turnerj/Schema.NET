namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of producing a balanced opinion about the object for an audience. An agent reviews an object with participants resulting in a review.
    /// </summary>
    public partial interface IReviewAction : IAssessAction
    {
        /// <summary>
        /// A sub property of result. The review that resulted in the performing of the action.
        /// </summary>
        OneOrMany<IReview> ResultReview { get; set; }
    }

    /// <summary>
    /// The act of producing a balanced opinion about the object for an audience. An agent reviews an object with participants resulting in a review.
    /// </summary>
    public partial class ReviewAction : AssessAction, IReviewAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ReviewAction";

        /// <summary>
        /// A sub property of result. The review that resulted in the performing of the action.
        /// </summary>
        [JsonPropertyName("resultReview")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IReview> ResultReview { get; set; }
    }
}
