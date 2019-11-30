namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of installing an application.
    /// </summary>
    public partial interface IInstallAction : IConsumeAction
    {
    }

    /// <summary>
    /// The act of installing an application.
    /// </summary>
    public partial class InstallAction : ConsumeAction, IInstallAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "InstallAction";
    }
}
