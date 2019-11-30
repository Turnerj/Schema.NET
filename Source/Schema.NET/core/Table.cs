namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A table on a Web page.
    /// </summary>
    public partial interface ITable : IWebPageElement
    {
    }

    /// <summary>
    /// A table on a Web page.
    /// </summary>
    public partial class Table : WebPageElement, ITable
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Table";
    }
}
