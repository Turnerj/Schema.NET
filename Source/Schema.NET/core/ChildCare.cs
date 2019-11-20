namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A Childcare center.
    /// </summary>
    public partial interface IChildCare : ILocalBusiness
    {
    }

    /// <summary>
    /// A Childcare center.
    /// </summary>
    [DataContract]
    public partial class ChildCare : LocalBusiness, IChildCare
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ChildCare";
    }
}
