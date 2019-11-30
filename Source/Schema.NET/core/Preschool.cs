namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A preschool.
    /// </summary>
    public partial interface IPreschool : IEducationalOrganization
    {
    }

    /// <summary>
    /// A preschool.
    /// </summary>
    public partial class Preschool : EducationalOrganization, IPreschool
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Preschool";
    }
}
