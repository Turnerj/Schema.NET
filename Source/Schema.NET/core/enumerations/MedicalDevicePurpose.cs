namespace Schema.NET
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Categories of medical devices, organized by the purpose or intended use of the device.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MedicalDevicePurpose
    {
        /// <summary>
        /// A medical device used for diagnostic purposes.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Diagnostic")]
        Diagnostic,

        /// <summary>
        /// A medical device used for therapeutic purposes.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Therapeutic")]
        Therapeutic
    }
}
