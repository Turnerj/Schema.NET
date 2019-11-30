namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A shop that will buy, or lend money against the security of, personal possessions.
    /// </summary>
    public partial interface IPawnShop : IStore
    {
    }

    /// <summary>
    /// A shop that will buy, or lend money against the security of, personal possessions.
    /// </summary>
    public partial class PawnShop : Store, IPawnShop
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PawnShop";
    }
}
