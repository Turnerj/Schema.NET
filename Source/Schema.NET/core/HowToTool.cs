namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A tool used (but not consumed) when performing instructions for how to achieve a result.
    /// </summary>
    public partial interface IHowToTool : IHowToItem
    {
    }

    /// <summary>
    /// A tool used (but not consumed) when performing instructions for how to achieve a result.
    /// </summary>
    public partial class HowToTool : HowToItem, IHowToTool
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "HowToTool";
    }
}
