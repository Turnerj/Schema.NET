namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A taxi stand.
    /// </summary>
    public partial interface ITaxiStand : ICivicStructure
    {
    }

    /// <summary>
    /// A taxi stand.
    /// </summary>
    public partial class TaxiStand : CivicStructure, ITaxiStand
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "TaxiStand";
    }
}
