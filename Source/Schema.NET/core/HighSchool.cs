namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A high school.
    /// </summary>
    public partial interface IHighSchool : IEducationalOrganization
    {
    }

    /// <summary>
    /// A high school.
    /// </summary>
    public partial class HighSchool : EducationalOrganization, IHighSchool
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "HighSchool";
    }
}
