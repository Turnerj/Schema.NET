namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A medical test performed by a laboratory that typically involves examination of a tissue sample by a pathologist.
    /// </summary>
    public partial interface IPathologyTest : IMedicalTest
    {
        /// <summary>
        /// The type of tissue sample required for the test.
        /// </summary>
        OneOrMany<string> TissueSample { get; set; }
    }

    /// <summary>
    /// A medical test performed by a laboratory that typically involves examination of a tissue sample by a pathologist.
    /// </summary>
    public partial class PathologyTest : MedicalTest, IPathologyTest
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PathologyTest";

        /// <summary>
        /// The type of tissue sample required for the test.
        /// </summary>
        [JsonPropertyName("tissueSample")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TissueSample { get; set; }
    }
}
