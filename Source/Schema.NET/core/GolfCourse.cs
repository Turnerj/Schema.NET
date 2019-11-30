namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A golf course.
    /// </summary>
    public partial interface IGolfCourse : ISportsActivityLocation
    {
    }

    /// <summary>
    /// A golf course.
    /// </summary>
    public partial class GolfCourse : SportsActivityLocation, IGolfCourse
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "GolfCourse";
    }
}
