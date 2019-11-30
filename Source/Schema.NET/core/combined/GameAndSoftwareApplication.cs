namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// See Game, SoftwareApplication for more information.
    /// </summary>
    public partial interface IGameAndSoftwareApplication : IGame, ISoftwareApplication
    {
    }

    /// <summary>
    /// See Game, SoftwareApplication for more information.
    /// </summary>
    public abstract partial class GameAndSoftwareApplication : CreativeWork, IGameAndSoftwareApplication
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "GameAndSoftwareApplication";

        /// <summary>
        /// Type of software application, e.g. 'Game, Multimedia'.
        /// </summary>
        [JsonPropertyName("applicationCategory")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> ApplicationCategory { get; set; }

        /// <summary>
        /// Subcategory of the application, e.g. 'Arcade Game'.
        /// </summary>
        [JsonPropertyName("applicationSubCategory")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> ApplicationSubCategory { get; set; }

        /// <summary>
        /// The name of the application suite to which the application belongs (e.g. Excel belongs to Office).
        /// </summary>
        [JsonPropertyName("applicationSuite")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ApplicationSuite { get; set; }

        /// <summary>
        /// Device required to run the application. Used in cases where a specific make/model is required to run the application.
        /// </summary>
        [JsonPropertyName("availableOnDevice")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AvailableOnDevice { get; set; }

        /// <summary>
        /// A piece of data that represents a particular aspect of a fictional character (skill, power, character points, advantage, disadvantage).
        /// </summary>
        [JsonPropertyName("characterAttribute")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> CharacterAttribute { get; set; }

        /// <summary>
        /// Countries for which the application is not supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        [JsonPropertyName("countriesNotSupported")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CountriesNotSupported { get; set; }

        /// <summary>
        /// Countries for which the application is supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        [JsonPropertyName("countriesSupported")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CountriesSupported { get; set; }

        /// <summary>
        /// If the file can be downloaded, URL to download the binary.
        /// </summary>
        [JsonPropertyName("downloadUrl")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> DownloadUrl { get; set; }

        /// <summary>
        /// Features or modules provided by this application (and possibly required by other applications).
        /// </summary>
        [JsonPropertyName("featureList")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> FeatureList { get; set; }

        /// <summary>
        /// Size of the application / package (e.g. 18MB). In the absence of a unit (MB, KB etc.), KB will be assumed.
        /// </summary>
        [JsonPropertyName("fileSize")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> FileSize { get; set; }

        /// <summary>
        /// An item is an object within the game world that can be collected by a player or, occasionally, a non-player character.
        /// </summary>
        [JsonPropertyName("gameItem")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> GameItem { get; set; }

        /// <summary>
        /// Real or fictional location of the game (or part of game).
        /// </summary>
        [JsonPropertyName("gameLocation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPlace, IPostalAddress, Uri> GameLocation { get; set; }

        /// <summary>
        /// URL at which the app may be installed, if different from the URL of the item.
        /// </summary>
        [JsonPropertyName("installUrl")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> InstallUrl { get; set; }

        /// <summary>
        /// Minimum memory requirements.
        /// </summary>
        [JsonPropertyName("memoryRequirements")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> MemoryRequirements { get; set; }

        /// <summary>
        /// Indicate how many people can play this game (minimum, maximum, or range).
        /// </summary>
        [JsonPropertyName("numberOfPlayers")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> NumberOfPlayers { get; set; }

        /// <summary>
        /// Operating systems supported (Windows 7, OSX 10.6, Android 1.6).
        /// </summary>
        [JsonPropertyName("operatingSystem")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> OperatingSystem { get; set; }

        /// <summary>
        /// Permission(s) required to run the app (for example, a mobile app may require full internet access or may run only on wifi).
        /// </summary>
        [JsonPropertyName("permissions")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Permissions { get; set; }

        /// <summary>
        /// Processor architecture required to run the application (e.g. IA64).
        /// </summary>
        [JsonPropertyName("processorRequirements")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ProcessorRequirements { get; set; }

        /// <summary>
        /// The task that a player-controlled character, or group of characters may complete in order to gain a reward.
        /// </summary>
        [JsonPropertyName("quest")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> Quest { get; set; }

        /// <summary>
        /// Description of what changed in this version.
        /// </summary>
        [JsonPropertyName("releaseNotes")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> ReleaseNotes { get; set; }

        /// <summary>
        /// A link to a screenshot image of the app.
        /// </summary>
        [JsonPropertyName("screenshot")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IImageObject, Uri> Screenshot { get; set; }

        /// <summary>
        /// Additional content for a software application.
        /// </summary>
        [JsonPropertyName("softwareAddOn")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ISoftwareApplication> SoftwareAddOn { get; set; }

        /// <summary>
        /// Software application help.
        /// </summary>
        [JsonPropertyName("softwareHelp")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> SoftwareHelp { get; set; }

        /// <summary>
        /// Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (Examples: DirectX, Java or .NET runtime).
        /// </summary>
        [JsonPropertyName("softwareRequirements")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> SoftwareRequirements { get; set; }

        /// <summary>
        /// Version of the software instance.
        /// </summary>
        [JsonPropertyName("softwareVersion")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SoftwareVersion { get; set; }

        /// <summary>
        /// Storage requirements (free space required).
        /// </summary>
        [JsonPropertyName("storageRequirements")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> StorageRequirements { get; set; }

        /// <summary>
        /// Supporting data for a SoftwareApplication.
        /// </summary>
        [JsonPropertyName("supportingData")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDataFeed> SupportingData { get; set; }
    }
}
