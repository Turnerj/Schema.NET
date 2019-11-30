namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of downloading an object.
    /// </summary>
    public partial interface IDownloadAction : ITransferAction
    {
    }

    /// <summary>
    /// The act of downloading an object.
    /// </summary>
    public partial class DownloadAction : TransferAction, IDownloadAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DownloadAction";
    }
}
