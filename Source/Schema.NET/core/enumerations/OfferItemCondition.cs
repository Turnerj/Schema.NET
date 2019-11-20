namespace Schema.NET
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;


    /// <summary>
    /// A list of possible conditions for the item.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OfferItemCondition
    {
        /// <summary>
        /// Indicates that the item is damaged.
        /// </summary>
        [EnumMember(Value = "https://schema.org/DamagedCondition")]
        DamagedCondition,

        /// <summary>
        /// Indicates that the item is new.
        /// </summary>
        [EnumMember(Value = "https://schema.org/NewCondition")]
        NewCondition,

        /// <summary>
        /// Indicates that the item is refurbished.
        /// </summary>
        [EnumMember(Value = "https://schema.org/RefurbishedCondition")]
        RefurbishedCondition,

        /// <summary>
        /// Indicates that the item is used.
        /// </summary>
        [EnumMember(Value = "https://schema.org/UsedCondition")]
        UsedCondition
    }
}
