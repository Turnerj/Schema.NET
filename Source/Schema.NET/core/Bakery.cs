namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A bakery.
    /// </summary>
    public partial interface IBakery : IFoodEstablishment
    {
    }

    /// <summary>
    /// A bakery.
    /// </summary>
    public partial class Bakery : FoodEstablishment, IBakery
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Bakery";
    }
}
