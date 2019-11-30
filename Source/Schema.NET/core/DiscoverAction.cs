namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of discovering/finding an object.
    /// </summary>
    public partial interface IDiscoverAction : IFindAction
    {
    }

    /// <summary>
    /// The act of discovering/finding an object.
    /// </summary>
    public partial class DiscoverAction : FindAction, IDiscoverAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DiscoverAction";
    }
}
