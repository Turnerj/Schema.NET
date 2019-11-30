namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Any matter of defined composition that has discrete existence, whose origin may be biological, mineral or chemical.
    /// </summary>
    public partial interface ISubstance : IMedicalEntity
    {
        /// <summary>
        /// An active ingredient, typically chemical compounds and/or biologic substances.
        /// </summary>
        OneOrMany<string> ActiveIngredient { get; set; }

        /// <summary>
        /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
        /// </summary>
        OneOrMany<IMaximumDoseSchedule> MaximumIntake { get; set; }
    }

    /// <summary>
    /// Any matter of defined composition that has discrete existence, whose origin may be biological, mineral or chemical.
    /// </summary>
    public partial class Substance : MedicalEntity, ISubstance
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Substance";

        /// <summary>
        /// An active ingredient, typically chemical compounds and/or biologic substances.
        /// </summary>
        [JsonPropertyName("activeIngredient")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<string> ActiveIngredient { get; set; }

        /// <summary>
        /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
        /// </summary>
        [JsonPropertyName("maximumIntake")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IMaximumDoseSchedule> MaximumIntake { get; set; }
    }
}
