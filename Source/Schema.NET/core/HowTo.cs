﻿namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Instructions that explain how to achieve a result by performing a sequence of steps.
    /// </summary>
    public partial interface IHowTo : ICreativeWork
    {
        /// <summary>
        /// The estimated cost of the supply or supplies consumed when performing instructions.
        /// </summary>
        Values<IMonetaryAmount, string> EstimatedCost { get; set; }

        /// <summary>
        /// The length of time it takes to perform instructions or a direction (not including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        OneOrMany<TimeSpan?> PerformTime { get; set; }

        /// <summary>
        /// The length of time it takes to prepare the items to be used in instructions or a direction, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        OneOrMany<TimeSpan?> PrepTime { get; set; }

        /// <summary>
        /// A single step item (as HowToStep, text, document, video, etc.) or a HowToSection.
        /// </summary>
        Values<ICreativeWork, IHowToSection, IHowToStep, string> Step { get; set; }

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

        /// <summary>
        /// The quantity that results by performing instructions. For example, a paper airplane, 10 personalized candles.
        /// </summary>
        Values<IQuantitativeValue, string> Yield { get; set; }
    }

    /// <summary>
    /// Instructions that explain how to achieve a result by performing a sequence of steps.
    /// </summary>
    public partial class HowTo : CreativeWork, IHowTo
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "HowTo";

        /// <summary>
        /// The estimated cost of the supply or supplies consumed when performing instructions.
        /// </summary>
        [JsonPropertyName("estimatedCost")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMonetaryAmount, string> EstimatedCost { get; set; }

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
        /// A single step item (as HowToStep, text, document, video, etc.) or a HowToSection.
        /// </summary>
        [JsonPropertyName("step")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, IHowToSection, IHowToStep, string> Step { get; set; }

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

        /// <summary>
        /// The quantity that results by performing instructions. For example, a paper airplane, 10 personalized candles.
        /// </summary>
        [JsonPropertyName("yield")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IQuantitativeValue, string> Yield { get; set; }
    }
}
