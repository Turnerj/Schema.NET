namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A winery.
    /// </summary>
    public partial interface IWinery : IFoodEstablishment
    {
    }

    /// <summary>
    /// A winery.
    /// </summary>
    public partial class Winery : FoodEstablishment, IWinery
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Winery";
    }
}
