namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An ice cream shop.
    /// </summary>
    public partial interface IIceCreamShop : IFoodEstablishment
    {
    }

    /// <summary>
    /// An ice cream shop.
    /// </summary>
    public partial class IceCreamShop : FoodEstablishment, IIceCreamShop
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "IceCreamShop";
    }
}
