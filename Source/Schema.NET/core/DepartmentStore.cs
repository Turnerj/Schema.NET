namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A department store.
    /// </summary>
    public partial interface IDepartmentStore : IStore
    {
    }

    /// <summary>
    /// A department store.
    /// </summary>
    public partial class DepartmentStore : Store, IDepartmentStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DepartmentStore";
    }
}
