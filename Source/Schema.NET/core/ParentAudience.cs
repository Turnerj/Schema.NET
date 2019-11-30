namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A set of characteristics describing parents, who can be interested in viewing some content.
    /// </summary>
    public partial interface IParentAudience : IPeopleAudience
    {
        /// <summary>
        /// Maximal age of the child.
        /// </summary>
        OneOrMany<int?> ChildMaxAge { get; set; }

        /// <summary>
        /// Minimal age of the child.
        /// </summary>
        OneOrMany<int?> ChildMinAge { get; set; }
    }

    /// <summary>
    /// A set of characteristics describing parents, who can be interested in viewing some content.
    /// </summary>
    public partial class ParentAudience : PeopleAudience, IParentAudience
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ParentAudience";

        /// <summary>
        /// Maximal age of the child.
        /// </summary>
        [JsonPropertyName("childMaxAge")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> ChildMaxAge { get; set; }

        /// <summary>
        /// Minimal age of the child.
        /// </summary>
        [JsonPropertyName("childMinAge")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> ChildMinAge { get; set; }
    }
}
