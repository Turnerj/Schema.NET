namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A Catholic church.
    /// </summary>
    public partial interface ICatholicChurch : IChurch
    {
    }

    /// <summary>
    /// A Catholic church.
    /// </summary>
    public partial class CatholicChurch : Church, ICatholicChurch
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "CatholicChurch";
    }
}
