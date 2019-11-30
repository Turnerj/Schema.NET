namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A food service, like breakfast, lunch, or dinner.
    /// </summary>
    public partial interface IFoodService : IService
    {
    }

    /// <summary>
    /// A food service, like breakfast, lunch, or dinner.
    /// </summary>
    public partial class FoodService : Service, IFoodService
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "FoodService";
    }
}
