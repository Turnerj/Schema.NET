namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An emergency service, such as a fire station or ER.
    /// </summary>
    public partial interface IEmergencyService : ILocalBusiness
    {
    }

    /// <summary>
    /// An emergency service, such as a fire station or ER.
    /// </summary>
    public partial class EmergencyService : LocalBusiness, IEmergencyService
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "EmergencyService";
    }
}
