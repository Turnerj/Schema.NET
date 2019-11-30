namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A blog post.
    /// </summary>
    public partial interface IBlogPosting : ISocialMediaPosting
    {
    }

    /// <summary>
    /// A blog post.
    /// </summary>
    public partial class BlogPosting : SocialMediaPosting, IBlogPosting
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "BlogPosting";
    }
}
