namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A single, identifiable product instance (e.g. a laptop with a particular serial number).
    /// </summary>
    public partial interface IIndividualProduct : IProduct
    {
        /// <summary>
        /// The serial number or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial number of the product included in the offer.
        /// </summary>
        OneOrMany<string> SerialNumber { get; set; }
    }

    /// <summary>
    /// A single, identifiable product instance (e.g. a laptop with a particular serial number).
    /// </summary>
    public partial class IndividualProduct : Product, IIndividualProduct
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "IndividualProduct";

        /// <summary>
        /// The serial number or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial number of the product included in the offer.
        /// </summary>
        [JsonPropertyName("serialNumber")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SerialNumber { get; set; }
    }
}
