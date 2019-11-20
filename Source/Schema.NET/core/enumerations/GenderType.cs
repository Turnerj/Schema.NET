namespace Schema.NET
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;


    /// <summary>
    /// An enumeration of genders.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum GenderType
    {
        /// <summary>
        /// The female gender.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Female")]
        Female,

        /// <summary>
        /// The male gender.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Male")]
        Male
    }
}
