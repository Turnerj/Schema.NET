namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A motorcycle repair shop.
    /// </summary>
    public partial interface IMotorcycleRepair : IAutomotiveBusiness
    {
    }

    /// <summary>
    /// A motorcycle repair shop.
    /// </summary>
    public partial class MotorcycleRepair : AutomotiveBusiness, IMotorcycleRepair
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MotorcycleRepair";
    }
}
