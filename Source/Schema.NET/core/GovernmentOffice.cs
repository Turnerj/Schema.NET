namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A government office&amp;#x2014;for example, an IRS or DMV office.
    /// </summary>
    public partial interface IGovernmentOffice : ILocalBusiness
    {
    }

    /// <summary>
    /// A government office&amp;#x2014;for example, an IRS or DMV office.
    /// </summary>
    public partial class GovernmentOffice : LocalBusiness, IGovernmentOffice
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "GovernmentOffice";
    }
}
