namespace Schema.NET
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A patient is any person recipient of health care services.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Patient
    {
    }
}
