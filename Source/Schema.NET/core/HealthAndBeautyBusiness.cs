﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Health and beauty.
    /// </summary>
    public partial interface IHealthAndBeautyBusiness : ILocalBusiness
    {
    }

    /// <summary>
    /// Health and beauty.
    /// </summary>
    [DataContract]
    public partial class HealthAndBeautyBusiness : LocalBusiness, IHealthAndBeautyBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HealthAndBeautyBusiness";
    }
}
