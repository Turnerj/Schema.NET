namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Any collection of tests commonly ordered together.
    /// </summary>
    public partial interface IMedicalTestPanel : IMedicalTest
    {
        /// <summary>
        /// A component test of the panel.
        /// </summary>
        OneOrMany<IMedicalTest> SubTest { get; set; }
    }

    /// <summary>
    /// Any collection of tests commonly ordered together.
    /// </summary>
    public partial class MedicalTestPanel : MedicalTest, IMedicalTestPanel
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MedicalTestPanel";

        /// <summary>
        /// A component test of the panel.
        /// </summary>
        [JsonPropertyName("subTest")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalTest> SubTest { get; set; }
    }
}
