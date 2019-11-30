namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A process of care relying upon counseling, dialogue and communication  aimed at improving a mental health condition without use of drugs.
    /// </summary>
    public partial interface IPsychologicalTreatment : ITherapeuticProcedure
    {
    }

    /// <summary>
    /// A process of care relying upon counseling, dialogue and communication  aimed at improving a mental health condition without use of drugs.
    /// </summary>
    public partial class PsychologicalTreatment : TherapeuticProcedure, IPsychologicalTreatment
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PsychologicalTreatment";
    }
}
