namespace Schema.NET
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;


    /// <summary>
    /// Enumerated for values for itemListOrder for indicating how an ordered ItemList is organized.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ItemListOrderType
    {
        /// <summary>
        /// An ItemList ordered with lower values listed first.
        /// </summary>
        [EnumMember(Value = "https://schema.org/ItemListOrderAscending")]
        ItemListOrderAscending,

        /// <summary>
        /// An ItemList ordered with higher values listed first.
        /// </summary>
        [EnumMember(Value = "https://schema.org/ItemListOrderDescending")]
        ItemListOrderDescending,

        /// <summary>
        /// An ItemList ordered with no explicit order.
        /// </summary>
        [EnumMember(Value = "https://schema.org/ItemListUnordered")]
        ItemListUnordered
    }
}
