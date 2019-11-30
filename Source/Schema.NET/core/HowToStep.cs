namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A step in the instructions for how to achieve a result. It is an ordered list with HowToDirection and/or HowToTip items.
    /// </summary>
    public partial interface IHowToStep : ICreativeWorkAndItemListAndListItem
    {
    }

    /// <summary>
    /// A step in the instructions for how to achieve a result. It is an ordered list with HowToDirection and/or HowToTip items.
    /// </summary>
    public partial class HowToStep : CreativeWorkAndItemListAndListItem, IHowToStep
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "HowToStep";
    }
}
