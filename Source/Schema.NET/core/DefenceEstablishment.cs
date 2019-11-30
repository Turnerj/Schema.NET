namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A defence establishment, such as an army or navy base.
    /// </summary>
    public partial interface IDefenceEstablishment : IGovernmentBuilding
    {
    }

    /// <summary>
    /// A defence establishment, such as an army or navy base.
    /// </summary>
    public partial class DefenceEstablishment : GovernmentBuilding, IDefenceEstablishment
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DefenceEstablishment";
    }
}
