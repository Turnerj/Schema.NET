namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An email message.
    /// </summary>
    public partial interface IEmailMessage : IMessage
    {
    }

    /// <summary>
    /// An email message.
    /// </summary>
    public partial class EmailMessage : Message, IEmailMessage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "EmailMessage";
    }
}
