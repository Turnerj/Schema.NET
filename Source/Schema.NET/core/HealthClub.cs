namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A health club.
    /// </summary>
    public partial interface IHealthClub : IHealthAndBeautyBusinessAndSportsActivityLocation
    {
    }

    /// <summary>
    /// A health club.
    /// </summary>
    [DataContract]
    public partial class HealthClub : HealthAndBeautyBusinessAndSportsActivityLocation, IHealthClub
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HealthClub";
    }
}
