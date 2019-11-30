﻿namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Organization: A business corporation.
    /// </summary>
    public partial interface ICorporation : IOrganization
    {
        /// <summary>
        /// The exchange traded instrument associated with a Corporation object. The tickerSymbol is expressed as an exchange and an instrument name separated by a space character. For the exchange component of the tickerSymbol attribute, we recommend using the controlled vocabulary of Market Identifier Codes (MIC) specified in ISO15022.
        /// </summary>
        OneOrMany<string> TickerSymbol { get; set; }
    }

    /// <summary>
    /// Organization: A business corporation.
    /// </summary>
    public partial class Corporation : Organization, ICorporation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Corporation";

        /// <summary>
        /// The exchange traded instrument associated with a Corporation object. The tickerSymbol is expressed as an exchange and an instrument name separated by a space character. For the exchange component of the tickerSymbol attribute, we recommend using the controlled vocabulary of Market Identifier Codes (MIC) specified in ISO15022.
        /// </summary>
        [JsonPropertyName("tickerSymbol")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TickerSymbol { get; set; }
    }
}
