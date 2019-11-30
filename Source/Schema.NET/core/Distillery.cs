namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A distillery.
    /// </summary>
    public partial interface IDistillery : IFoodEstablishment
    {
    }

    /// <summary>
    /// A distillery.
    /// </summary>
    public partial class Distillery : FoodEstablishment, IDistillery
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Distillery";
    }
}
