namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A college, university, or other third-level educational institution.
    /// </summary>
    public partial interface ICollegeOrUniversity : IEducationalOrganization
    {
    }

    /// <summary>
    /// A college, university, or other third-level educational institution.
    /// </summary>
    public partial class CollegeOrUniversity : EducationalOrganization, ICollegeOrUniversity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "CollegeOrUniversity";
    }
}
