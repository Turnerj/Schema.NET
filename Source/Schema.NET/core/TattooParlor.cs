namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A tattoo parlor.
    /// </summary>
    public partial interface ITattooParlor : IHealthAndBeautyBusiness
    {
    }

    /// <summary>
    /// A tattoo parlor.
    /// </summary>
    public partial class TattooParlor : HealthAndBeautyBusiness, ITattooParlor
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "TattooParlor";
    }
}
