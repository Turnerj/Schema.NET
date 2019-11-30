namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A direction indicating a single action to do in the instructions for how to achieve a result.
    /// </summary>
    public partial interface IHowToDirection : ICreativeWorkAndListItem
    {
        /// <summary>
        /// A media object representing the circumstances after performing this direction.
        /// </summary>
        Values<IMediaObject, Uri> AfterMedia { get; set; }

        /// <summary>
        /// A media object representing the circumstances before performing this direction.
        /// </summary>
        Values<IMediaObject, Uri> BeforeMedia { get; set; }

        /// <summary>
        /// A media object representing the circumstances while performing this direction.
        /// </summary>
        Values<IMediaObject, Uri> DuringMedia { get; set; }

        /// <summary>
        /// The length of time it takes to perform instructions or a direction (not including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        OneOrMany<TimeSpan?> PerformTime { get; set; }

        /// <summary>
        /// The length of time it takes to prepare the items to be used in instructions or a direction, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        OneOrMany<TimeSpan?> PrepTime { get; set; }

        /// <summary>
        /// A sub-property of instrument. A supply consumed when performing instructions or a direction.
        /// </summary>
        Values<IHowToSupply, string> Supply { get; set; }

        /// <summary>
        /// A sub property of instrument. An object used (but not consumed) when performing instructions or a direction.
        /// </summary>
        Values<IHowToTool, string> Tool { get; set; }

        /// <summary>
        /// The total time required to perform instructions or a direction (including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        OneOrMany<TimeSpan?> TotalTime { get; set; }
    }

    /// <summary>
    /// A direction indicating a single action to do in the instructions for how to achieve a result.
    /// </summary>
    public partial class HowToDirection : CreativeWorkAndListItem, IHowToDirection
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "HowToDirection";

        /// <summary>
        /// A media object representing the circumstances after performing this direction.
        /// </summary>
        [JsonPropertyName("afterMedia")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMediaObject, Uri> AfterMedia { get; set; }

        /// <summary>
        /// A media object representing the circumstances before performing this direction.
        /// </summary>
        [JsonPropertyName("beforeMedia")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMediaObject, Uri> BeforeMedia { get; set; }

        /// <summary>
        /// A media object representing the circumstances while performing this direction.
        /// </summary>
        [JsonPropertyName("duringMedia")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMediaObject, Uri> DuringMedia { get; set; }

        /// <summary>
        /// The length of time it takes to perform instructions or a direction (not including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("performTime")]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public OneOrMany<TimeSpan?> PerformTime { get; set; }

        /// <summary>
        /// The length of time it takes to prepare the items to be used in instructions or a direction, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("prepTime")]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public OneOrMany<TimeSpan?> PrepTime { get; set; }

        /// <summary>
        /// A sub-property of instrument. A supply consumed when performing instructions or a direction.
        /// </summary>
        [JsonPropertyName("supply")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IHowToSupply, string> Supply { get; set; }

        /// <summary>
        /// A sub property of instrument. An object used (but not consumed) when performing instructions or a direction.
        /// </summary>
        [JsonPropertyName("tool")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IHowToTool, string> Tool { get; set; }

        /// <summary>
        /// The total time required to perform instructions or a direction (including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("totalTime")]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public OneOrMany<TimeSpan?> TotalTime { get; set; }
    }
}
