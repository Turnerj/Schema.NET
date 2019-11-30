namespace Schema.NET
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A DeliveryMethod in which an item is made available via locker.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LockerDelivery
    {
    }
}
