namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An office equipment store.
    /// </summary>
    public partial interface IOfficeEquipmentStore : IStore
    {
    }

    /// <summary>
    /// An office equipment store.
    /// </summary>
    public partial class OfficeEquipmentStore : Store, IOfficeEquipmentStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "OfficeEquipmentStore";
    }
}
