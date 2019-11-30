namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An elementary school.
    /// </summary>
    public partial interface IElementarySchool : IEducationalOrganization
    {
    }

    /// <summary>
    /// An elementary school.
    /// </summary>
    public partial class ElementarySchool : EducationalOrganization, IElementarySchool
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ElementarySchool";
    }
}
