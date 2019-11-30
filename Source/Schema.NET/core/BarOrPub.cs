namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A bar or pub.
    /// </summary>
    public partial interface IBarOrPub : IFoodEstablishment
    {
    }

    /// <summary>
    /// A bar or pub.
    /// </summary>
    public partial class BarOrPub : FoodEstablishment, IBarOrPub
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "BarOrPub";
    }
}
