namespace Schema.NET
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A type of bed. This is used for indicating the bed or beds available in an accommodation.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BedType
    {
    }
}
