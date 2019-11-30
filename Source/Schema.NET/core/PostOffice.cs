namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A post office.
    /// </summary>
    public partial interface IPostOffice : IGovernmentOffice
    {
    }

    /// <summary>
    /// A post office.
    /// </summary>
    public partial class PostOffice : GovernmentOffice, IPostOffice
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PostOffice";
    }
}
