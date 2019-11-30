namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Residence type: Gated community.
    /// </summary>
    public partial interface IGatedResidenceCommunity : IResidence
    {
    }

    /// <summary>
    /// Residence type: Gated community.
    /// </summary>
    public partial class GatedResidenceCommunity : Residence, IGatedResidenceCommunity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "GatedResidenceCommunity";
    }
}
