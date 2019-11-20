namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A medical procedure intended primarily for diagnostic, as opposed to therapeutic, purposes.
    /// </summary>
    public partial interface IDiagnosticProcedure : IMedicalProcedure
    {
    }

    /// <summary>
    /// A medical procedure intended primarily for diagnostic, as opposed to therapeutic, purposes.
    /// </summary>
    [DataContract]
    public partial class DiagnosticProcedure : MedicalProcedure, IDiagnosticProcedure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DiagnosticProcedure";
    }
}
