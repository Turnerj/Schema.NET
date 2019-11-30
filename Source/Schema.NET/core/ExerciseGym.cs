namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A gym.
    /// </summary>
    public partial interface IExerciseGym : ISportsActivityLocation
    {
    }

    /// <summary>
    /// A gym.
    /// </summary>
    public partial class ExerciseGym : SportsActivityLocation, IExerciseGym
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ExerciseGym";
    }
}
