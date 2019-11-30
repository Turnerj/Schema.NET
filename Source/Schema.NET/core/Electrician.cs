namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An electrician.
    /// </summary>
    public partial interface IElectrician : IHomeAndConstructionBusiness
    {
    }

    /// <summary>
    /// An electrician.
    /// </summary>
    public partial class Electrician : HomeAndConstructionBusiness, IElectrician
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Electrician";
    }
}
