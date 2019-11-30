namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Fitness-related activity designed for a specific health-related purpose, including defined exercise routines as well as activity prescribed by a clinician.
    /// </summary>
    public partial interface IExercisePlan : ICreativeWorkAndPhysicalActivity
    {
        /// <summary>
        /// Length of time to engage in the activity.
        /// </summary>
        OneOrMany<TimeSpan?> ActivityDuration { get; set; }

        /// <summary>
        /// How often one should engage in the activity.
        /// </summary>
        OneOrMany<string> ActivityFrequency { get; set; }

        /// <summary>
        /// Any additional component of the exercise prescription that may need to be articulated to the patient. This may include the order of exercises, the number of repetitions of movement, quantitative distance, progressions over time, etc.
        /// </summary>
        OneOrMany<string> AdditionalVariable { get; set; }

        /// <summary>
        /// Type(s) of exercise or activity, such as strength training, flexibility training, aerobics, cardiac rehabilitation, etc.
        /// </summary>
        OneOrMany<string> ExerciseType { get; set; }

        /// <summary>
        /// Quantitative measure gauging the degree of force involved in the exercise, for example, heartbeats per minute. May include the velocity of the movement.
        /// </summary>
        OneOrMany<string> Intensity { get; set; }

        /// <summary>
        /// Number of times one should repeat the activity.
        /// </summary>
        OneOrMany<double?> Repetitions { get; set; }

        /// <summary>
        /// How often one should break from the activity.
        /// </summary>
        OneOrMany<string> RestPeriods { get; set; }

        /// <summary>
        /// Quantitative measure of the physiologic output of the exercise; also referred to as energy expenditure.
        /// </summary>
        OneOrMany<string> Workload { get; set; }
    }

    /// <summary>
    /// Fitness-related activity designed for a specific health-related purpose, including defined exercise routines as well as activity prescribed by a clinician.
    /// </summary>
    public partial class ExercisePlan : CreativeWorkAndPhysicalActivity, IExercisePlan
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ExercisePlan";

        /// <summary>
        /// Length of time to engage in the activity.
        /// </summary>
        [JsonPropertyName("activityDuration")]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public OneOrMany<TimeSpan?> ActivityDuration { get; set; }

        /// <summary>
        /// How often one should engage in the activity.
        /// </summary>
        [JsonPropertyName("activityFrequency")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ActivityFrequency { get; set; }

        /// <summary>
        /// Any additional component of the exercise prescription that may need to be articulated to the patient. This may include the order of exercises, the number of repetitions of movement, quantitative distance, progressions over time, etc.
        /// </summary>
        [JsonPropertyName("additionalVariable")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AdditionalVariable { get; set; }

        /// <summary>
        /// Type(s) of exercise or activity, such as strength training, flexibility training, aerobics, cardiac rehabilitation, etc.
        /// </summary>
        [JsonPropertyName("exerciseType")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ExerciseType { get; set; }

        /// <summary>
        /// Quantitative measure gauging the degree of force involved in the exercise, for example, heartbeats per minute. May include the velocity of the movement.
        /// </summary>
        [JsonPropertyName("intensity")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Intensity { get; set; }

        /// <summary>
        /// Number of times one should repeat the activity.
        /// </summary>
        [JsonPropertyName("repetitions")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> Repetitions { get; set; }

        /// <summary>
        /// How often one should break from the activity.
        /// </summary>
        [JsonPropertyName("restPeriods")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> RestPeriods { get; set; }

        /// <summary>
        /// Quantitative measure of the physiologic output of the exercise; also referred to as energy expenditure.
        /// </summary>
        [JsonPropertyName("workload")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Workload { get; set; }
    }
}
