namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A posting to a discussion forum.
    /// </summary>
    public partial interface IDiscussionForumPosting : ISocialMediaPosting
    {
    }

    /// <summary>
    /// A posting to a discussion forum.
    /// </summary>
    public partial class DiscussionForumPosting : SocialMediaPosting, IDiscussionForumPosting
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DiscussionForumPosting";
    }
}
