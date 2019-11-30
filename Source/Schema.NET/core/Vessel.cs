namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A component of the human body circulatory system comprised of an intricate network of hollow tubes that transport blood throughout the entire body.
    /// </summary>
    public partial interface IVessel : IAnatomicalStructure
    {
    }

    /// <summary>
    /// A component of the human body circulatory system comprised of an intricate network of hollow tubes that transport blood throughout the entire body.
    /// </summary>
    public partial class Vessel : AnatomicalStructure, IVessel
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Vessel";
    }
}
