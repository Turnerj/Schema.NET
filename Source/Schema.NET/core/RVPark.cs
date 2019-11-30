namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A place offering space for "Recreational Vehicles", Caravans, mobile homes and the like.
    /// </summary>
    public partial interface IRVPark : ICivicStructure
    {
    }

    /// <summary>
    /// A place offering space for "Recreational Vehicles", Caravans, mobile homes and the like.
    /// </summary>
    public partial class RVPark : CivicStructure, IRVPark
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "RVPark";
    }
}
