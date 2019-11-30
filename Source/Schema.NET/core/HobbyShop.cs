namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A store that sells materials useful or necessary for various hobbies.
    /// </summary>
    public partial interface IHobbyShop : IStore
    {
    }

    /// <summary>
    /// A store that sells materials useful or necessary for various hobbies.
    /// </summary>
    public partial class HobbyShop : Store, IHobbyShop
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "HobbyShop";
    }
}
