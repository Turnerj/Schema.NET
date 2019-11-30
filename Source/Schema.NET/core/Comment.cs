namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A comment on an item - for example, a comment on a blog post. The comment's content is expressed via the &lt;a class="localLink" href="http://schema.org/text"&gt;text&lt;/a&gt; property, and its topic via &lt;a class="localLink" href="http://schema.org/about"&gt;about&lt;/a&gt;, properties shared with all CreativeWorks.
    /// </summary>
    public partial interface IComment : ICreativeWork
    {
        /// <summary>
        /// The number of downvotes this question, answer or comment has received from the community.
        /// </summary>
        OneOrMany<int?> DownvoteCount { get; set; }

        /// <summary>
        /// The parent of a question, answer or item in general.
        /// </summary>
        OneOrMany<IQuestion> ParentItem { get; set; }

        /// <summary>
        /// The number of upvotes this question, answer or comment has received from the community.
        /// </summary>
        OneOrMany<int?> UpvoteCount { get; set; }
    }

    /// <summary>
    /// A comment on an item - for example, a comment on a blog post. The comment's content is expressed via the &lt;a class="localLink" href="http://schema.org/text"&gt;text&lt;/a&gt; property, and its topic via &lt;a class="localLink" href="http://schema.org/about"&gt;about&lt;/a&gt;, properties shared with all CreativeWorks.
    /// </summary>
    public partial class Comment : CreativeWork, IComment
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Comment";

        /// <summary>
        /// The number of downvotes this question, answer or comment has received from the community.
        /// </summary>
        [JsonPropertyName("downvoteCount")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> DownvoteCount { get; set; }

        /// <summary>
        /// The parent of a question, answer or item in general.
        /// </summary>
        [JsonPropertyName("parentItem")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuestion> ParentItem { get; set; }

        /// <summary>
        /// The number of upvotes this question, answer or comment has received from the community.
        /// </summary>
        [JsonPropertyName("upvoteCount")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> UpvoteCount { get; set; }
    }
}
