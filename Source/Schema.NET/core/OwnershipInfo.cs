namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A structured value providing information about when a certain organization or person owned a certain product.
    /// </summary>
    public partial interface IOwnershipInfo : IStructuredValue
    {
        /// <summary>
        /// The organization or person from which the product was acquired.
        /// </summary>
        Values<IOrganization, IPerson> AcquiredFrom { get; set; }

        /// <summary>
        /// The date and time of obtaining the product.
        /// </summary>
        OneOrMany<DateTimeOffset?> OwnedFrom { get; set; }

        /// <summary>
        /// The date and time of giving up ownership on the product.
        /// </summary>
        OneOrMany<DateTimeOffset?> OwnedThrough { get; set; }

        /// <summary>
        /// The product that this structured value is referring to.
        /// </summary>
        Values<IProduct, IService> TypeOfGood { get; set; }
    }

    /// <summary>
    /// A structured value providing information about when a certain organization or person owned a certain product.
    /// </summary>
    public partial class OwnershipInfo : StructuredValue, IOwnershipInfo
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "OwnershipInfo";

        /// <summary>
        /// The organization or person from which the product was acquired.
        /// </summary>
        [JsonPropertyName("acquiredFrom")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> AcquiredFrom { get; set; }

        /// <summary>
        /// The date and time of obtaining the product.
        /// </summary>
        [JsonPropertyName("ownedFrom")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> OwnedFrom { get; set; }

        /// <summary>
        /// The date and time of giving up ownership on the product.
        /// </summary>
        [JsonPropertyName("ownedThrough")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> OwnedThrough { get; set; }

        /// <summary>
        /// The product that this structured value is referring to.
        /// </summary>
        [JsonPropertyName("typeOfGood")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IProduct, IService> TypeOfGood { get; set; }
    }
}
