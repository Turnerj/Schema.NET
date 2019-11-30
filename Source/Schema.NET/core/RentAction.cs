namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of giving money in return for temporary use, but not ownership, of an object such as a vehicle or property. For example, an agent rents a property from a landlord in exchange for a periodic payment.
    /// </summary>
    public partial interface IRentAction : ITradeAction
    {
        /// <summary>
        /// A sub property of participant. The owner of the real estate property.
        /// </summary>
        Values<IOrganization, IPerson> Landlord { get; set; }

        /// <summary>
        /// A sub property of participant. The real estate agent involved in the action.
        /// </summary>
        OneOrMany<IRealEstateAgent> RealEstateAgent { get; set; }
    }

    /// <summary>
    /// The act of giving money in return for temporary use, but not ownership, of an object such as a vehicle or property. For example, an agent rents a property from a landlord in exchange for a periodic payment.
    /// </summary>
    public partial class RentAction : TradeAction, IRentAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "RentAction";

        /// <summary>
        /// A sub property of participant. The owner of the real estate property.
        /// </summary>
        [JsonPropertyName("landlord")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Landlord { get; set; }

        /// <summary>
        /// A sub property of participant. The real estate agent involved in the action.
        /// </summary>
        [JsonPropertyName("realEstateAgent")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IRealEstateAgent> RealEstateAgent { get; set; }
    }
}
