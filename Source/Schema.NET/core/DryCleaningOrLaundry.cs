namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A dry-cleaning business.
    /// </summary>
    public partial interface IDryCleaningOrLaundry : ILocalBusiness
    {
    }

    /// <summary>
    /// A dry-cleaning business.
    /// </summary>
    public partial class DryCleaningOrLaundry : LocalBusiness, IDryCleaningOrLaundry
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DryCleaningOrLaundry";
    }
}
