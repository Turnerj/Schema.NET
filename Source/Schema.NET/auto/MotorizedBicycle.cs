namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A motorized bicycle is a bicycle with an attached motor used to power the vehicle, or to assist with pedaling.
    /// </summary>
    public partial interface IMotorizedBicycle : IVehicle
    {
    }

    /// <summary>
    /// A motorized bicycle is a bicycle with an attached motor used to power the vehicle, or to assist with pedaling.
    /// </summary>
    public partial class MotorizedBicycle : Vehicle, IMotorizedBicycle
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MotorizedBicycle";
    }
}
