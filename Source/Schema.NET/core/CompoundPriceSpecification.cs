namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A compound price specification is one that bundles multiple prices that all apply in combination for different dimensions of consumption. Use the name property of the attached unit price specification for indicating the dimension of a price component (e.g. "electricity" or "final cleaning").
    /// </summary>
    public partial interface ICompoundPriceSpecification : IPriceSpecification
    {
        /// <summary>
        /// This property links to all &lt;a class="localLink" href="http://schema.org/UnitPriceSpecification"&gt;UnitPriceSpecification&lt;/a&gt; nodes that apply in parallel for the &lt;a class="localLink" href="http://schema.org/CompoundPriceSpecification"&gt;CompoundPriceSpecification&lt;/a&gt; node.
        /// </summary>
        OneOrMany<IUnitPriceSpecification> PriceComponent { get; set; }
    }

    /// <summary>
    /// A compound price specification is one that bundles multiple prices that all apply in combination for different dimensions of consumption. Use the name property of the attached unit price specification for indicating the dimension of a price component (e.g. "electricity" or "final cleaning").
    /// </summary>
    public partial class CompoundPriceSpecification : PriceSpecification, ICompoundPriceSpecification
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "CompoundPriceSpecification";

        /// <summary>
        /// This property links to all &lt;a class="localLink" href="http://schema.org/UnitPriceSpecification"&gt;UnitPriceSpecification&lt;/a&gt; nodes that apply in parallel for the &lt;a class="localLink" href="http://schema.org/CompoundPriceSpecification"&gt;CompoundPriceSpecification&lt;/a&gt; node.
        /// </summary>
        [JsonPropertyName("priceComponent")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IUnitPriceSpecification> PriceComponent { get; set; }
    }
}
