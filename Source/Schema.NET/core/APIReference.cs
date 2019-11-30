namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Reference documentation for application programming interfaces (APIs).
    /// </summary>
    public partial interface IAPIReference : ITechArticle
    {
        /// <summary>
        /// Associated product/technology version. e.g., .NET Framework 4.5.
        /// </summary>
        OneOrMany<string> AssemblyVersion { get; set; }

        /// <summary>
        /// Library file name e.g., mscorlib.dll, system.web.dll.
        /// </summary>
        OneOrMany<string> ExecutableLibraryName { get; set; }

        /// <summary>
        /// Indicates whether API is managed or unmanaged.
        /// </summary>
        OneOrMany<string> ProgrammingModel { get; set; }

        /// <summary>
        /// Type of app development: phone, Metro style, desktop, XBox, etc.
        /// </summary>
        OneOrMany<string> TargetPlatform { get; set; }
    }

    /// <summary>
    /// Reference documentation for application programming interfaces (APIs).
    /// </summary>
    public partial class APIReference : TechArticle, IAPIReference
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "APIReference";

        /// <summary>
        /// Associated product/technology version. e.g., .NET Framework 4.5.
        /// </summary>
        [JsonPropertyName("assemblyVersion")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AssemblyVersion { get; set; }

        /// <summary>
        /// Library file name e.g., mscorlib.dll, system.web.dll.
        /// </summary>
        [JsonPropertyName("executableLibraryName")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ExecutableLibraryName { get; set; }

        /// <summary>
        /// Indicates whether API is managed or unmanaged.
        /// </summary>
        [JsonPropertyName("programmingModel")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ProgrammingModel { get; set; }

        /// <summary>
        /// Type of app development: phone, Metro style, desktop, XBox, etc.
        /// </summary>
        [JsonPropertyName("targetPlatform")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TargetPlatform { get; set; }
    }
}
