namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An agent bookmarks/flags/labels/tags/marks an object.
    /// </summary>
    public partial interface IBookmarkAction : IOrganizeAction
    {
    }

    /// <summary>
    /// An agent bookmarks/flags/labels/tags/marks an object.
    /// </summary>
    public partial class BookmarkAction : OrganizeAction, IBookmarkAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "BookmarkAction";
    }
}
