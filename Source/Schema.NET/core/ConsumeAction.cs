namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of ingesting information/resources/food.
    /// </summary>
    public partial interface IConsumeAction : IAction
    {
        /// <summary>
        /// A set of requirements that a must be fulfilled in order to perform an Action. If more than one value is specied, fulfilling one set of requirements will allow the Action to be performed.
        /// </summary>
        OneOrMany<IActionAccessSpecification> ActionAccessibilityRequirement { get; set; }

        /// <summary>
        /// An Offer which must be accepted before the user can perform the Action. For example, the user may need to buy a movie before being able to watch it.
        /// </summary>
        OneOrMany<IOffer> ExpectsAcceptanceOf { get; set; }
    }

    /// <summary>
    /// The act of ingesting information/resources/food.
    /// </summary>
    public partial class ConsumeAction : Action, IConsumeAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ConsumeAction";

        /// <summary>
        /// A set of requirements that a must be fulfilled in order to perform an Action. If more than one value is specied, fulfilling one set of requirements will allow the Action to be performed.
        /// </summary>
        [JsonPropertyName("actionAccessibilityRequirement")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IActionAccessSpecification> ActionAccessibilityRequirement { get; set; }

        /// <summary>
        /// An Offer which must be accepted before the user can perform the Action. For example, the user may need to buy a movie before being able to watch it.
        /// </summary>
        [JsonPropertyName("expectsAcceptanceOf")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOffer> ExpectsAcceptanceOf { get; set; }
    }
}
