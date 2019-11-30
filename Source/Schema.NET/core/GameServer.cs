namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Server that provides game interaction in a multiplayer game.
    /// </summary>
    public partial interface IGameServer : IIntangible
    {
        /// <summary>
        /// Video game which is played on this server.
        /// </summary>
        OneOrMany<IVideoGame> Game { get; set; }

        /// <summary>
        /// Number of players on the server.
        /// </summary>
        OneOrMany<int?> PlayersOnline { get; set; }

        /// <summary>
        /// Status of a game server.
        /// </summary>
        OneOrMany<GameServerStatus?> ServerStatus { get; set; }
    }

    /// <summary>
    /// Server that provides game interaction in a multiplayer game.
    /// </summary>
    public partial class GameServer : Intangible, IGameServer
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "GameServer";

        /// <summary>
        /// Video game which is played on this server.
        /// </summary>
        [JsonPropertyName("game")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IVideoGame> Game { get; set; }

        /// <summary>
        /// Number of players on the server.
        /// </summary>
        [JsonPropertyName("playersOnline")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> PlayersOnline { get; set; }

        /// <summary>
        /// Status of a game server.
        /// </summary>
        [JsonPropertyName("serverStatus")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<GameServerStatus?> ServerStatus { get; set; }
    }
}
