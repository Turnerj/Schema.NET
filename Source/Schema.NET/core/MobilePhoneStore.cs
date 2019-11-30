namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A store that sells mobile phones and related accessories.
    /// </summary>
    public partial interface IMobilePhoneStore : IStore
    {
    }

    /// <summary>
    /// A store that sells mobile phones and related accessories.
    /// </summary>
    public partial class MobilePhoneStore : Store, IMobilePhoneStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MobilePhoneStore";
    }
}
