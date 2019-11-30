namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A collection or bound volume of maps, charts, plates or tables, physical or in media form illustrating any subject.
    /// </summary>
    public partial interface IAtlas : ICreativeWork
    {
    }

    /// <summary>
    /// A collection or bound volume of maps, charts, plates or tables, physical or in media form illustrating any subject.
    /// </summary>
    public partial class Atlas : CreativeWork, IAtlas
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Atlas";
    }
}
