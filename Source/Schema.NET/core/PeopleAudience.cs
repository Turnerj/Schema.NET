namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    /// </summary>
    public partial interface IPeopleAudience : IAudience
    {
        /// <summary>
        /// Specifying the health condition(s) of a patient, medical study, or other target audience.
        /// </summary>
        OneOrMany<IMedicalCondition> HealthCondition { get; set; }

        /// <summary>
        /// Audiences defined by a person's gender.
        /// </summary>
        OneOrMany<string> RequiredGender { get; set; }

        /// <summary>
        /// Audiences defined by a person's maximum age.
        /// </summary>
        OneOrMany<int?> RequiredMaxAge { get; set; }

        /// <summary>
        /// Audiences defined by a person's minimum age.
        /// </summary>
        OneOrMany<int?> RequiredMinAge { get; set; }

        /// <summary>
        /// The gender of the person or audience.
        /// </summary>
        OneOrMany<string> SuggestedGender { get; set; }

        /// <summary>
        /// Maximal age recommended for viewing content.
        /// </summary>
        OneOrMany<int?> SuggestedMaxAge { get; set; }

        /// <summary>
        /// Minimal age recommended for viewing content.
        /// </summary>
        OneOrMany<int?> SuggestedMinAge { get; set; }
    }

    /// <summary>
    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    /// </summary>
    public partial class PeopleAudience : Audience, IPeopleAudience
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PeopleAudience";

        /// <summary>
        /// Specifying the health condition(s) of a patient, medical study, or other target audience.
        /// </summary>
        [JsonPropertyName("healthCondition")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalCondition> HealthCondition { get; set; }

        /// <summary>
        /// Audiences defined by a person's gender.
        /// </summary>
        [JsonPropertyName("requiredGender")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> RequiredGender { get; set; }

        /// <summary>
        /// Audiences defined by a person's maximum age.
        /// </summary>
        [JsonPropertyName("requiredMaxAge")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> RequiredMaxAge { get; set; }

        /// <summary>
        /// Audiences defined by a person's minimum age.
        /// </summary>
        [JsonPropertyName("requiredMinAge")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> RequiredMinAge { get; set; }

        /// <summary>
        /// The gender of the person or audience.
        /// </summary>
        [JsonPropertyName("suggestedGender")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SuggestedGender { get; set; }

        /// <summary>
        /// Maximal age recommended for viewing content.
        /// </summary>
        [JsonPropertyName("suggestedMaxAge")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> SuggestedMaxAge { get; set; }

        /// <summary>
        /// Minimal age recommended for viewing content.
        /// </summary>
        [JsonPropertyName("suggestedMinAge")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> SuggestedMinAge { get; set; }
    }
}
