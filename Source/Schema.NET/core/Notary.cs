namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A notary.
    /// </summary>
    public partial interface INotary : ILegalService
    {
    }

    /// <summary>
    /// A notary.
    /// </summary>
    public partial class Notary : LegalService, INotary
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Notary";
    }
}
