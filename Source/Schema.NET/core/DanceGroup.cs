namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A dance group&amp;#x2014;for example, the Alvin Ailey Dance Theater or Riverdance.
    /// </summary>
    public partial interface IDanceGroup : IPerformingGroup
    {
    }

    /// <summary>
    /// A dance group&amp;#x2014;for example, the Alvin Ailey Dance Theater or Riverdance.
    /// </summary>
    [DataContract]
    public partial class DanceGroup : PerformingGroup, IDanceGroup
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DanceGroup";
    }
}
