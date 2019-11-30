namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of responding to a question/message asked/sent by the object. Related to &lt;a class="localLink" href="http://schema.org/AskAction"&gt;AskAction&lt;/a&gt;&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/AskAction"&gt;AskAction&lt;/a&gt;: Appears generally as an origin of a ReplyAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IReplyAction : ICommunicateAction
    {
        /// <summary>
        /// A sub property of result. The Comment created or sent as a result of this action.
        /// </summary>
        OneOrMany<IComment> ResultComment { get; set; }
    }

    /// <summary>
    /// The act of responding to a question/message asked/sent by the object. Related to &lt;a class="localLink" href="http://schema.org/AskAction"&gt;AskAction&lt;/a&gt;&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/AskAction"&gt;AskAction&lt;/a&gt;: Appears generally as an origin of a ReplyAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial class ReplyAction : CommunicateAction, IReplyAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ReplyAction";

        /// <summary>
        /// A sub property of result. The Comment created or sent as a result of this action.
        /// </summary>
        [JsonPropertyName("resultComment")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IComment> ResultComment { get; set; }
    }
}
