namespace Schema.NET
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Any branch of a field in which people typically develop specific expertise, usually after significant study, time, and effort.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Specialty
    {
    }
}
