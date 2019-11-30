namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A radio channel that uses FM.
    /// </summary>
    public partial interface IFMRadioChannel : IRadioChannel
    {
    }

    /// <summary>
    /// A radio channel that uses FM.
    /// </summary>
    public partial class FMRadioChannel : RadioChannel, IFMRadioChannel
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "FMRadioChannel";
    }
}
