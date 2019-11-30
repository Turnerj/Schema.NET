namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of expressing a desire about the object. An agent wants an object.
    /// </summary>
    public partial interface IWantAction : IReactAction
    {
    }

    /// <summary>
    /// The act of expressing a desire about the object. An agent wants an object.
    /// </summary>
    public partial class WantAction : ReactAction, IWantAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "WantAction";
    }
}
