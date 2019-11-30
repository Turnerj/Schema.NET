namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of notifying someone that a future event/action is going to happen as expected.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/CancelAction"&gt;CancelAction&lt;/a&gt;: The antonym of ConfirmAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IConfirmAction : IInformAction
    {
    }

    /// <summary>
    /// The act of notifying someone that a future event/action is going to happen as expected.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/CancelAction"&gt;CancelAction&lt;/a&gt;: The antonym of ConfirmAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial class ConfirmAction : InformAction, IConfirmAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ConfirmAction";
    }
}
