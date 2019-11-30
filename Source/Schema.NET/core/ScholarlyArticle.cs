﻿namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A scholarly article.
    /// </summary>
    public partial interface IScholarlyArticle : IArticle
    {
    }

    /// <summary>
    /// A scholarly article.
    /// </summary>
    public partial class ScholarlyArticle : Article, IScholarlyArticle
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ScholarlyArticle";
    }
}
