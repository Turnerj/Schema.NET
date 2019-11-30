namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of distributing content to people for their amusement or edification.
    /// </summary>
    public partial interface IShareAction : ICommunicateAction
    {
    }

    /// <summary>
    /// The act of distributing content to people for their amusement or edification.
    /// </summary>
    public partial class ShareAction : CommunicateAction, IShareAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ShareAction";
    }
}
