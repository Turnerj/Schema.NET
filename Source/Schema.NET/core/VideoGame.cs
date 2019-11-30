namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    /// </summary>
    public partial interface IVideoGame : IGameAndSoftwareApplication
    {
        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson> Actor { get; set; }

        /// <summary>
        /// Cheat codes to the game.
        /// </summary>
        OneOrMany<ICreativeWork> CheatCode { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson> Director { get; set; }

        /// <summary>
        /// The electronic systems used to play &lt;a href="http://en.wikipedia.org/wiki/Category:Video_game_platforms"&gt;video games&lt;/a&gt;.
        /// </summary>
        Values<string, IThing, Uri> GamePlatform { get; set; }

        /// <summary>
        /// The server on which  it is possible to play the game.
        /// </summary>
        OneOrMany<IGameServer> GameServer { get; set; }

        /// <summary>
        /// Links to tips, tactics, etc.
        /// </summary>
        OneOrMany<ICreativeWork> GameTip { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        Values<IMusicGroup, IPerson> MusicBy { get; set; }

        /// <summary>
        /// Indicates whether this game is multi-player, co-op or single-player.  The game can be marked as multi-player, co-op and single-player at the same time.
        /// </summary>
        OneOrMany<GamePlayMode?> PlayMode { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        OneOrMany<IVideoObject> Trailer { get; set; }
    }

    /// <summary>
    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    /// </summary>
    public partial class VideoGame : GameAndSoftwareApplication, IVideoGame
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "VideoGame";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [JsonPropertyName("actor")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Actor { get; set; }

        /// <summary>
        /// Cheat codes to the game.
        /// </summary>
        [JsonPropertyName("cheatCode")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> CheatCode { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [JsonPropertyName("director")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Director { get; set; }

        /// <summary>
        /// The electronic systems used to play &lt;a href="http://en.wikipedia.org/wiki/Category:Video_game_platforms"&gt;video games&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("gamePlatform")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IThing, Uri> GamePlatform { get; set; }

        /// <summary>
        /// The server on which  it is possible to play the game.
        /// </summary>
        [JsonPropertyName("gameServer")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IGameServer> GameServer { get; set; }

        /// <summary>
        /// Links to tips, tactics, etc.
        /// </summary>
        [JsonPropertyName("gameTip")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> GameTip { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [JsonPropertyName("musicBy")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMusicGroup, IPerson> MusicBy { get; set; }

        /// <summary>
        /// Indicates whether this game is multi-player, co-op or single-player.  The game can be marked as multi-player, co-op and single-player at the same time.
        /// </summary>
        [JsonPropertyName("playMode")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<GamePlayMode?> PlayMode { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [JsonPropertyName("trailer")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IVideoObject> Trailer { get; set; }
    }
}
