namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A fast-food restaurant.
    /// </summary>
    public partial interface IFastFoodRestaurant : IFoodEstablishment
    {
    }

    /// <summary>
    /// A fast-food restaurant.
    /// </summary>
    public partial class FastFoodRestaurant : FoodEstablishment, IFastFoodRestaurant
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "FastFoodRestaurant";
    }
}
