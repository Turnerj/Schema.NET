namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A motorcycle dealer.
    /// </summary>
    public partial interface IMotorcycleDealer : IAutomotiveBusiness
    {
    }

    /// <summary>
    /// A motorcycle dealer.
    /// </summary>
    public partial class MotorcycleDealer : AutomotiveBusiness, IMotorcycleDealer
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MotorcycleDealer";
    }
}
