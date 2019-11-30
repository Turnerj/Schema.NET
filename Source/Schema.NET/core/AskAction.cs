namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of posing a question / favor to someone.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReplyAction"&gt;ReplyAction&lt;/a&gt;: Appears generally as a response to AskAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IAskAction : ICommunicateAction
    {
        /// <summary>
        /// A sub property of object. A question.
        /// </summary>
        OneOrMany<IQuestion> Question { get; set; }
    }

    /// <summary>
    /// The act of posing a question / favor to someone.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReplyAction"&gt;ReplyAction&lt;/a&gt;: Appears generally as a response to AskAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial class AskAction : CommunicateAction, IAskAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AskAction";

        /// <summary>
        /// A sub property of object. A question.
        /// </summary>
        [JsonPropertyName("question")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuestion> Question { get; set; }
    }
}
