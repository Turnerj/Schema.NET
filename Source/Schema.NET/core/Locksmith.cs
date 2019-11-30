namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A locksmith.
    /// </summary>
    public partial interface ILocksmith : IHomeAndConstructionBusiness
    {
    }

    /// <summary>
    /// A locksmith.
    /// </summary>
    public partial class Locksmith : HomeAndConstructionBusiness, ILocksmith
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Locksmith";
    }
}
