namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A radio channel that uses AM.
    /// </summary>
    public partial interface IAMRadioChannel : IRadioChannel
    {
    }

    /// <summary>
    /// A radio channel that uses AM.
    /// </summary>
    public partial class AMRadioChannel : RadioChannel, IAMRadioChannel
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AMRadioChannel";
    }
}
