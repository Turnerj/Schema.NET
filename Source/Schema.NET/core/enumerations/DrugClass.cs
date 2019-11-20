namespace Schema.NET
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;


    /// <summary>
    /// A class of medical drugs, e.g., statins. Classes can represent general pharmacological class, common mechanisms of action, common physiological effects, etc.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DrugClass
    {
    }
}
