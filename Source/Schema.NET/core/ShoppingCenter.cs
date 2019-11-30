namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A shopping center or mall.
    /// </summary>
    public partial interface IShoppingCenter : ILocalBusiness
    {
    }

    /// <summary>
    /// A shopping center or mall.
    /// </summary>
    public partial class ShoppingCenter : LocalBusiness, IShoppingCenter
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ShoppingCenter";
    }
}
