namespace Schema.NET
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A value indicating a steering position.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SteeringPositionValue
    {
        /// <summary>
        /// The steering position is on the left side of the vehicle (viewed from the main direction of driving).
        /// </summary>
        [EnumMember(Value = "https://schema.org/LeftHandDriving")]
        LeftHandDriving,

        /// <summary>
        /// The steering position is on the right side of the vehicle (viewed from the main direction of driving).
        /// </summary>
        [EnumMember(Value = "https://schema.org/RightHandDriving")]
        RightHandDriving
    }
}
