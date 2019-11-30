namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A permit issued by a government agency.
    /// </summary>
    public partial interface IGovernmentPermit : IPermit
    {
    }

    /// <summary>
    /// A permit issued by a government agency.
    /// </summary>
    public partial class GovernmentPermit : Permit, IGovernmentPermit
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "GovernmentPermit";
    }
}
