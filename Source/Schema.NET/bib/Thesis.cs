namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A thesis or dissertation document submitted in support of candidature for an academic degree or professional qualification.
    /// </summary>
    public partial interface IThesis : ICreativeWork
    {
        /// <summary>
        /// Qualification, candidature, degree, application that Thesis supports.
        /// </summary>
        OneOrMany<string> InSupportOf { get; set; }
    }

    /// <summary>
    /// A thesis or dissertation document submitted in support of candidature for an academic degree or professional qualification.
    /// </summary>
    public partial class Thesis : CreativeWork, IThesis
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Thesis";

        /// <summary>
        /// Qualification, candidature, degree, application that Thesis supports.
        /// </summary>
        [JsonPropertyName("inSupportOf")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> InSupportOf { get; set; }
    }
}
