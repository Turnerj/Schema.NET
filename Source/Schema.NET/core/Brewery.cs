namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Brewery.
    /// </summary>
    public partial interface IBrewery : IFoodEstablishment
    {
    }

    /// <summary>
    /// Brewery.
    /// </summary>
    public partial class Brewery : FoodEstablishment, IBrewery
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Brewery";
    }
}
