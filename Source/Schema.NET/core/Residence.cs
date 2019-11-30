namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The place where a person lives.
    /// </summary>
    public partial interface IResidence : IPlace
    {
    }

    /// <summary>
    /// The place where a person lives.
    /// </summary>
    public partial class Residence : Place, IResidence
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Residence";
    }
}
