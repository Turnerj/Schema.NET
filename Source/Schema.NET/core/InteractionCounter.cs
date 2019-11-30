namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A summary of how users have interacted with this CreativeWork. In most cases, authors will use a subtype to specify the specific type of interaction.
    /// </summary>
    public partial interface IInteractionCounter : IStructuredValue
    {
        /// <summary>
        /// The WebSite or SoftwareApplication where the interactions took place.
        /// </summary>
        Values<ISoftwareApplication, IWebSite> InteractionService { get; set; }

        /// <summary>
        /// The Action representing the type of interaction. For up votes, +1s, etc. use &lt;a class="localLink" href="http://schema.org/LikeAction"&gt;LikeAction&lt;/a&gt;. For down votes use &lt;a class="localLink" href="http://schema.org/DislikeAction"&gt;DislikeAction&lt;/a&gt;. Otherwise, use the most specific Action.
        /// </summary>
        OneOrMany<IAction> InteractionType { get; set; }

        /// <summary>
        /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication.
        /// </summary>
        OneOrMany<int?> UserInteractionCount { get; set; }
    }

    /// <summary>
    /// A summary of how users have interacted with this CreativeWork. In most cases, authors will use a subtype to specify the specific type of interaction.
    /// </summary>
    public partial class InteractionCounter : StructuredValue, IInteractionCounter
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "InteractionCounter";

        /// <summary>
        /// The WebSite or SoftwareApplication where the interactions took place.
        /// </summary>
        [JsonPropertyName("interactionService")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ISoftwareApplication, IWebSite> InteractionService { get; set; }

        /// <summary>
        /// The Action representing the type of interaction. For up votes, +1s, etc. use &lt;a class="localLink" href="http://schema.org/LikeAction"&gt;LikeAction&lt;/a&gt;. For down votes use &lt;a class="localLink" href="http://schema.org/DislikeAction"&gt;DislikeAction&lt;/a&gt;. Otherwise, use the most specific Action.
        /// </summary>
        [JsonPropertyName("interactionType")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAction> InteractionType { get; set; }

        /// <summary>
        /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication.
        /// </summary>
        [JsonPropertyName("userInteractionCount")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> UserInteractionCount { get; set; }
    }
}
