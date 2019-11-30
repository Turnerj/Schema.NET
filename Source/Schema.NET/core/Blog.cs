namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A blog.
    /// </summary>
    public partial interface IBlog : ICreativeWork
    {
        /// <summary>
        /// A posting that is part of this blog.
        /// </summary>
        OneOrMany<IBlogPosting> BlogPost { get; set; }

        /// <summary>
        /// The International Standard Serial Number (ISSN) that identifies this serial publication. You can repeat this property to identify different formats of, or the linking ISSN (ISSN-L) for, this serial publication.
        /// </summary>
        OneOrMany<string> Issn { get; set; }
    }

    /// <summary>
    /// A blog.
    /// </summary>
    public partial class Blog : CreativeWork, IBlog
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Blog";

        /// <summary>
        /// A posting that is part of this blog.
        /// </summary>
        [JsonPropertyName("blogPost")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IBlogPosting> BlogPost { get; set; }

        /// <summary>
        /// The International Standard Serial Number (ISSN) that identifies this serial publication. You can repeat this property to identify different formats of, or the linking ISSN (ISSN-L) for, this serial publication.
        /// </summary>
        [JsonPropertyName("issn")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Issn { get; set; }
    }
}
