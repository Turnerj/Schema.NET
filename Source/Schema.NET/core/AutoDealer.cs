namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An car dealership.
    /// </summary>
    public partial interface IAutoDealer : IAutomotiveBusiness
    {
    }

    /// <summary>
    /// An car dealership.
    /// </summary>
    public partial class AutoDealer : AutomotiveBusiness, IAutoDealer
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AutoDealer";
    }
}
