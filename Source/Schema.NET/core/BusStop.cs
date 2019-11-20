﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A bus stop.
    /// </summary>
    public partial interface IBusStop : ICivicStructure
    {
    }

    /// <summary>
    /// A bus stop.
    /// </summary>
    [DataContract]
    public partial class BusStop : CivicStructure, IBusStop
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BusStop";
    }
}
