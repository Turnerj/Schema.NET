namespace Schema.NET
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;


    /// <summary>
    /// Status of a game server.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum GameServerStatus
    {
        /// <summary>
        /// Game server status: OfflinePermanently. Server is offline and not available.
        /// </summary>
        [EnumMember(Value = "https://schema.org/OfflinePermanently")]
        OfflinePermanently,

        /// <summary>
        /// Game server status: OfflineTemporarily. Server is offline now but it can be online soon.
        /// </summary>
        [EnumMember(Value = "https://schema.org/OfflineTemporarily")]
        OfflineTemporarily,

        /// <summary>
        /// Game server status: Online. Server is available.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Online")]
        Online,

        /// <summary>
        /// Game server status: OnlineFull. Server is online but unavailable. The maximum number of players has reached.
        /// </summary>
        [EnumMember(Value = "https://schema.org/OnlineFull")]
        OnlineFull
    }
}
