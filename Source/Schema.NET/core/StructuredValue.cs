namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Structured values are used when the value of a property has a more complex structure than simply being a textual value or a reference to another thing.
    /// </summary>
    public partial interface IStructuredValue : IIntangible
    {
    }

    /// <summary>
    /// Structured values are used when the value of a property has a more complex structure than simply being a textual value or a reference to another thing.
    /// </summary>
    public partial class StructuredValue : Intangible, IStructuredValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "StructuredValue";
    }
}
