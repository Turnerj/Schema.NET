namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A synagogue.
    /// </summary>
    public partial interface ISynagogue : IPlaceOfWorship
    {
    }

    /// <summary>
    /// A synagogue.
    /// </summary>
    [DataContract]
    public partial class Synagogue : PlaceOfWorship, ISynagogue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Synagogue";
    }
}
