namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A software application.
    /// </summary>
    public partial interface ISoftwareApplication : ICreativeWork
    {
        /// <summary>
        /// Type of software application, e.g. 'Game, Multimedia'.
        /// </summary>
        Values<string, Uri> ApplicationCategory { get; set; }

        /// <summary>
        /// Subcategory of the application, e.g. 'Arcade Game'.
        /// </summary>
        Values<string, Uri> ApplicationSubCategory { get; set; }

        /// <summary>
        /// The name of the application suite to which the application belongs (e.g. Excel belongs to Office).
        /// </summary>
        OneOrMany<string> ApplicationSuite { get; set; }

        /// <summary>
        /// Device required to run the application. Used in cases where a specific make/model is required to run the application.
        /// </summary>
        OneOrMany<string> AvailableOnDevice { get; set; }

        /// <summary>
        /// Countries for which the application is not supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        OneOrMany<string> CountriesNotSupported { get; set; }

        /// <summary>
        /// Countries for which the application is supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        OneOrMany<string> CountriesSupported { get; set; }

        /// <summary>
        /// If the file can be downloaded, URL to download the binary.
        /// </summary>
        OneOrMany<Uri> DownloadUrl { get; set; }

        /// <summary>
        /// Features or modules provided by this application (and possibly required by other applications).
        /// </summary>
        Values<string, Uri> FeatureList { get; set; }

        /// <summary>
        /// Size of the application / package (e.g. 18MB). In the absence of a unit (MB, KB etc.), KB will be assumed.
        /// </summary>
        OneOrMany<string> FileSize { get; set; }

        /// <summary>
        /// URL at which the app may be installed, if different from the URL of the item.
        /// </summary>
        OneOrMany<Uri> InstallUrl { get; set; }

        /// <summary>
        /// Minimum memory requirements.
        /// </summary>
        Values<string, Uri> MemoryRequirements { get; set; }

        /// <summary>
        /// Operating systems supported (Windows 7, OSX 10.6, Android 1.6).
        /// </summary>
        OneOrMany<string> OperatingSystem { get; set; }

        /// <summary>
        /// Permission(s) required to run the app (for example, a mobile app may require full internet access or may run only on wifi).
        /// </summary>
        OneOrMany<string> Permissions { get; set; }

        /// <summary>
        /// Processor architecture required to run the application (e.g. IA64).
        /// </summary>
        OneOrMany<string> ProcessorRequirements { get; set; }

        /// <summary>
        /// Description of what changed in this version.
        /// </summary>
        Values<string, Uri> ReleaseNotes { get; set; }

        /// <summary>
        /// A link to a screenshot image of the app.
        /// </summary>
        Values<IImageObject, Uri> Screenshot { get; set; }

        /// <summary>
        /// Additional content for a software application.
        /// </summary>
        OneOrMany<ISoftwareApplication> SoftwareAddOn { get; set; }

        /// <summary>
        /// Software application help.
        /// </summary>
        OneOrMany<ICreativeWork> SoftwareHelp { get; set; }

        /// <summary>
        /// Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (Examples: DirectX, Java or .NET runtime).
        /// </summary>
        Values<string, Uri> SoftwareRequirements { get; set; }

        /// <summary>
        /// Version of the software instance.
        /// </summary>
        OneOrMany<string> SoftwareVersion { get; set; }

        /// <summary>
        /// Storage requirements (free space required).
        /// </summary>
        Values<string, Uri> StorageRequirements { get; set; }

        /// <summary>
        /// Supporting data for a SoftwareApplication.
        /// </summary>
        OneOrMany<IDataFeed> SupportingData { get; set; }
    }

    /// <summary>
    /// A software application.
    /// </summary>
    public partial class SoftwareApplication : CreativeWork, ISoftwareApplication
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "SoftwareApplication";

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
