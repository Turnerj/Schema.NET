namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A school.
    /// </summary>
    public partial interface ISchool : IEducationalOrganization
    {
    }

    /// <summary>
    /// A school.
    /// </summary>
    public partial class School : EducationalOrganization, ISchool
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "School";
    }
}
