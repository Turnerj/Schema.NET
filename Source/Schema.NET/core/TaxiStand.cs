namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A taxi stand.
    /// </summary>
    public partial interface ITaxiStand : ICivicStructure
    {
    }

    /// <summary>
    /// A taxi stand.
    /// </summary>
    [DataContract]
    public partial class TaxiStand : CivicStructure, ITaxiStand
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TaxiStand";
    }
}
