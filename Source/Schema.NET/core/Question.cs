namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A specific question - e.g. from a user seeking answers online, or collected in a Frequently Asked Questions (FAQ) document.
    /// </summary>
    public partial interface IQuestion : ICreativeWork
    {
        /// <summary>
        /// The answer(s) that has been accepted as best, typically on a Question/Answer site. Sites vary in their selection mechanisms, e.g. drawing on community opinion and/or the view of the Question author.
        /// </summary>
        Values<IAnswer, IItemList> AcceptedAnswer { get; set; }

        /// <summary>
        /// The number of answers this question has received.
        /// </summary>
        OneOrMany<int?> AnswerCount { get; set; }

        /// <summary>
        /// The number of downvotes this question, answer or comment has received from the community.
        /// </summary>
        OneOrMany<int?> DownvoteCount { get; set; }

        /// <summary>
        /// An answer (possibly one of several, possibly incorrect) to a Question, e.g. on a Question/Answer site.
        /// </summary>
        Values<IAnswer, IItemList> SuggestedAnswer { get; set; }

        /// <summary>
        /// The number of upvotes this question, answer or comment has received from the community.
        /// </summary>
        OneOrMany<int?> UpvoteCount { get; set; }
    }

    /// <summary>
    /// A specific question - e.g. from a user seeking answers online, or collected in a Frequently Asked Questions (FAQ) document.
    /// </summary>
    public partial class Question : CreativeWork, IQuestion
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Question";

        /// <summary>
        /// The answer(s) that has been accepted as best, typically on a Question/Answer site. Sites vary in their selection mechanisms, e.g. drawing on community opinion and/or the view of the Question author.
        /// </summary>
        [JsonPropertyName("acceptedAnswer")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAnswer, IItemList> AcceptedAnswer { get; set; }

        /// <summary>
        /// The number of answers this question has received.
        /// </summary>
        [JsonPropertyName("answerCount")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> AnswerCount { get; set; }

        /// <summary>
        /// The number of downvotes this question, answer or comment has received from the community.
        /// </summary>
        [JsonPropertyName("downvoteCount")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> DownvoteCount { get; set; }

        /// <summary>
        /// An answer (possibly one of several, possibly incorrect) to a Question, e.g. on a Question/Answer site.
        /// </summary>
        [JsonPropertyName("suggestedAnswer")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAnswer, IItemList> SuggestedAnswer { get; set; }

        /// <summary>
        /// The number of upvotes this question, answer or comment has received from the community.
        /// </summary>
        [JsonPropertyName("upvoteCount")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> UpvoteCount { get; set; }
    }
}
