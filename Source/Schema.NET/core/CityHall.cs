namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A city hall.
    /// </summary>
    public partial interface ICityHall : IGovernmentBuilding
    {
    }

    /// <summary>
    /// A city hall.
    /// </summary>
    public partial class CityHall : GovernmentBuilding, ICityHall
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "CityHall";
    }
}
