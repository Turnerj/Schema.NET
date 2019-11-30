namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A blog post intended to provide a rolling textual coverage of an ongoing event through continuous updates.
    /// </summary>
    public partial interface ILiveBlogPosting : IBlogPosting
    {
        /// <summary>
        /// The time when the live blog will stop covering the Event. Note that coverage may continue after the Event concludes.
        /// </summary>
        OneOrMany<DateTimeOffset?> CoverageEndTime { get; set; }

        /// <summary>
        /// The time when the live blog will begin covering the Event. Note that coverage may begin before the Event's start time. The LiveBlogPosting may also be created before coverage begins.
        /// </summary>
        OneOrMany<DateTimeOffset?> CoverageStartTime { get; set; }

        /// <summary>
        /// An update to the LiveBlog.
        /// </summary>
        OneOrMany<IBlogPosting> LiveBlogUpdate { get; set; }
    }

    /// <summary>
    /// A blog post intended to provide a rolling textual coverage of an ongoing event through continuous updates.
    /// </summary>
    public partial class LiveBlogPosting : BlogPosting, ILiveBlogPosting
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "LiveBlogPosting";

        /// <summary>
        /// The time when the live blog will stop covering the Event. Note that coverage may continue after the Event concludes.
        /// </summary>
        [JsonPropertyName("coverageEndTime")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> CoverageEndTime { get; set; }

        /// <summary>
        /// The time when the live blog will begin covering the Event. Note that coverage may begin before the Event's start time. The LiveBlogPosting may also be created before coverage begins.
        /// </summary>
        [JsonPropertyName("coverageStartTime")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> CoverageStartTime { get; set; }

        /// <summary>
        /// An update to the LiveBlog.
        /// </summary>
        [JsonPropertyName("liveBlogUpdate")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IBlogPosting> LiveBlogUpdate { get; set; }
    }
}
