namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A middle school (typically for children aged around 11-14, although this varies somewhat).
    /// </summary>
    public partial interface IMiddleSchool : IEducationalOrganization
    {
    }

    /// <summary>
    /// A middle school (typically for children aged around 11-14, although this varies somewhat).
    /// </summary>
    public partial class MiddleSchool : EducationalOrganization, IMiddleSchool
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MiddleSchool";
    }
}
