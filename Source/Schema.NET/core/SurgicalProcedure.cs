namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A medical procedure involving an incision with instruments; performed for diagnose, or therapeutic purposes.
    /// </summary>
    public partial interface ISurgicalProcedure : IMedicalProcedure
    {
    }

    /// <summary>
    /// A medical procedure involving an incision with instruments; performed for diagnose, or therapeutic purposes.
    /// </summary>
    public partial class SurgicalProcedure : MedicalProcedure, ISurgicalProcedure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "SurgicalProcedure";
    }
}
