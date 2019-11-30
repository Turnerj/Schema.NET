namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A motorcycle or motorbike is a single-track, two-wheeled motor vehicle.
    /// </summary>
    public partial interface IMotorcycle : IVehicle
    {
    }

    /// <summary>
    /// A motorcycle or motorbike is a single-track, two-wheeled motor vehicle.
    /// </summary>
    public partial class Motorcycle : Vehicle, IMotorcycle
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Motorcycle";
    }
}
