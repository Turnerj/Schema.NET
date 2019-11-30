namespace Schema.NET
{
    using System;
    using System.Text.Json;
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
    public partial class ChildCare : LocalBusiness, IChildCare
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ChildCare";
    }
}
