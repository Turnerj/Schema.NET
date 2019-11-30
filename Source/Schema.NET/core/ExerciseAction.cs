namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// </summary>
    public partial interface IExerciseAction : IPlayAction
    {
        /// <summary>
        /// A sub property of instrument. The diet used in this action.
        /// </summary>
        OneOrMany<IDiet> Diet { get; set; }

        /// <summary>
        /// The distance travelled, e.g. exercising or travelling.
        /// </summary>
        OneOrMany<string> Distance { get; set; }

        /// <summary>
        /// A sub property of location. The course where this action was taken.
        /// </summary>
        OneOrMany<IPlace> ExerciseCourse { get; set; }

        /// <summary>
        /// A sub property of instrument. The exercise plan used on this action.
        /// </summary>
        OneOrMany<IExercisePlan> ExercisePlan { get; set; }

        /// <summary>
        /// A sub property of instrument. The diet used in this action.
        /// </summary>
        OneOrMany<IDiet> ExerciseRelatedDiet { get; set; }

        /// <summary>
        /// Type(s) of exercise or activity, such as strength training, flexibility training, aerobics, cardiac rehabilitation, etc.
        /// </summary>
        OneOrMany<string> ExerciseType { get; set; }

        /// <summary>
        /// A sub property of location. The original location of the object or the agent before the action.
        /// </summary>
        OneOrMany<IPlace> FromLocation { get; set; }

        /// <summary>
        /// A sub property of participant. The opponent on this action.
        /// </summary>
        OneOrMany<IPerson> Opponent { get; set; }

        /// <summary>
        /// A sub property of location. The sports activity location where this action occurred.
        /// </summary>
        OneOrMany<ISportsActivityLocation> SportsActivityLocation { get; set; }

        /// <summary>
        /// A sub property of location. The sports event where this action occurred.
        /// </summary>
        OneOrMany<ISportsEvent> SportsEvent { get; set; }

        /// <summary>
        /// A sub property of participant. The sports team that participated on this action.
        /// </summary>
        OneOrMany<ISportsTeam> SportsTeam { get; set; }

        /// <summary>
        /// A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        OneOrMany<IPlace> ToLocation { get; set; }
    }

    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// </summary>
    public partial class ExerciseAction : PlayAction, IExerciseAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ExerciseAction";

        /// <summary>
        /// A sub property of instrument. The diet used in this action.
        /// </summary>
        [JsonPropertyName("diet")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDiet> Diet { get; set; }

        /// <summary>
        /// The distance travelled, e.g. exercising or travelling.
        /// </summary>
        [JsonPropertyName("distance")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Distance { get; set; }

        /// <summary>
        /// A sub property of location. The course where this action was taken.
        /// </summary>
        [JsonPropertyName("exerciseCourse")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> ExerciseCourse { get; set; }

        /// <summary>
        /// A sub property of instrument. The exercise plan used on this action.
        /// </summary>
        [JsonPropertyName("exercisePlan")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IExercisePlan> ExercisePlan { get; set; }

        /// <summary>
        /// A sub property of instrument. The diet used in this action.
        /// </summary>
        [JsonPropertyName("exerciseRelatedDiet")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDiet> ExerciseRelatedDiet { get; set; }

        /// <summary>
        /// Type(s) of exercise or activity, such as strength training, flexibility training, aerobics, cardiac rehabilitation, etc.
        /// </summary>
        [JsonPropertyName("exerciseType")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ExerciseType { get; set; }

        /// <summary>
        /// A sub property of location. The original location of the object or the agent before the action.
        /// </summary>
        [JsonPropertyName("fromLocation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> FromLocation { get; set; }

        /// <summary>
        /// A sub property of participant. The opponent on this action.
        /// </summary>
        [JsonPropertyName("opponent")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Opponent { get; set; }

        /// <summary>
        /// A sub property of location. The sports activity location where this action occurred.
        /// </summary>
        [JsonPropertyName("sportsActivityLocation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ISportsActivityLocation> SportsActivityLocation { get; set; }

        /// <summary>
        /// A sub property of location. The sports event where this action occurred.
        /// </summary>
        [JsonPropertyName("sportsEvent")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ISportsEvent> SportsEvent { get; set; }

        /// <summary>
        /// A sub property of participant. The sports team that participated on this action.
        /// </summary>
        [JsonPropertyName("sportsTeam")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ISportsTeam> SportsTeam { get; set; }

        /// <summary>
        /// A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        [JsonPropertyName("toLocation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> ToLocation { get; set; }
    }
}
