namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A spreadsheet file.
    /// </summary>
    public partial interface ISpreadsheetDigitalDocument : IDigitalDocument
    {
    }

    /// <summary>
    /// A spreadsheet file.
    /// </summary>
    public partial class SpreadsheetDigitalDocument : DigitalDocument, ISpreadsheetDigitalDocument
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "SpreadsheetDigitalDocument";
    }
}
