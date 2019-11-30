namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of searching for an object.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FindAction"&gt;FindAction&lt;/a&gt;: SearchAction generally leads to a FindAction, but not necessarily.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface ISearchAction : IAction
    {
        /// <summary>
        /// A sub property of instrument. The query used on this action.
        /// </summary>
        OneOrMany<string> Query { get; set; }

        /// <summary>
        /// Gets or sets the query input search parameter.
        /// </summary>
        Values<string, PropertyValueSpecification> QueryInput { get; set; }
    }

    /// <summary>
    /// The act of searching for an object.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FindAction"&gt;FindAction&lt;/a&gt;: SearchAction generally leads to a FindAction, but not necessarily.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial class SearchAction : Action, ISearchAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "SearchAction";

        /// <summary>
        /// A sub property of instrument. The query used on this action.
        /// </summary>
        [JsonPropertyName("query")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Query { get; set; }

        /// <summary>
        /// Gets or sets the query input search parameter.
        /// </summary>
        [JsonPropertyName("query-input")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, PropertyValueSpecification> QueryInput { get; set; }
    }
}
