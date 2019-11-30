namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A volcano, like Fuji san.
    /// </summary>
    public partial interface IVolcano : ILandform
    {
    }

    /// <summary>
    /// A volcano, like Fuji san.
    /// </summary>
    public partial class Volcano : Landform, IVolcano
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Volcano";
    }
}
