namespace Schema.NET
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A type of boarding policy used by an airline.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BoardingPolicyType
    {
        /// <summary>
        /// The airline boards by groups based on check-in time, priority, etc.
        /// </summary>
        [EnumMember(Value = "https://schema.org/GroupBoardingPolicy")]
        GroupBoardingPolicy,

        /// <summary>
        /// The airline boards by zones of the plane.
        /// </summary>
        [EnumMember(Value = "https://schema.org/ZoneBoardingPolicy")]
        ZoneBoardingPolicy
    }
}
