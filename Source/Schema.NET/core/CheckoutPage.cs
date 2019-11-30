namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Web page type: Checkout page.
    /// </summary>
    public partial interface ICheckoutPage : IWebPage
    {
    }

    /// <summary>
    /// Web page type: Checkout page.
    /// </summary>
    public partial class CheckoutPage : WebPage, ICheckoutPage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "CheckoutPage";
    }
}
