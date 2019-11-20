namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A pond.
    /// </summary>
    public partial interface IPond : IBodyOfWater
    {
    }

    /// <summary>
    /// A pond.
    /// </summary>
    [DataContract]
    public partial class Pond : BodyOfWater, IPond
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Pond";
    }
}
