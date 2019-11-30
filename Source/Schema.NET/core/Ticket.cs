namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Used to describe a ticket to an event, a flight, a bus ride, etc.
    /// </summary>
    public partial interface ITicket : IIntangible
    {
        /// <summary>
        /// The date the ticket was issued.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> DateIssued { get; set; }

        /// <summary>
        /// The organization issuing the ticket or permit.
        /// </summary>
        OneOrMany<IOrganization> IssuedBy { get; set; }

        /// <summary>
        /// The currency of the price, or a price component when attached to &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        OneOrMany<string> PriceCurrency { get; set; }

        /// <summary>
        /// The seat associated with the ticket.
        /// </summary>
        OneOrMany<ISeat> TicketedSeat { get; set; }

        /// <summary>
        /// The unique identifier for the ticket.
        /// </summary>
        OneOrMany<string> TicketNumber { get; set; }

        /// <summary>
        /// Reference to an asset (e.g., Barcode, QR code image or PDF) usable for entrance.
        /// </summary>
        Values<string, Uri> TicketToken { get; set; }

        /// <summary>
        /// The total price for the reservation or ticket, including applicable taxes, shipping, etc.&lt;br/&gt;&lt;br/&gt;
        /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
        /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        Values<decimal?, IPriceSpecification, string> TotalPrice { get; set; }

        /// <summary>
        /// The person or organization the reservation or ticket is for.
        /// </summary>
        Values<IOrganization, IPerson> UnderName { get; set; }
    }

    /// <summary>
    /// Used to describe a ticket to an event, a flight, a bus ride, etc.
    /// </summary>
    public partial class Ticket : Intangible, ITicket
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Ticket";

        /// <summary>
        /// The date the ticket was issued.
        /// </summary>
        [JsonPropertyName("dateIssued")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> DateIssued { get; set; }

        /// <summary>
        /// The organization issuing the ticket or permit.
        /// </summary>
        [JsonPropertyName("issuedBy")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> IssuedBy { get; set; }

        /// <summary>
        /// The currency of the price, or a price component when attached to &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        [JsonPropertyName("priceCurrency")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PriceCurrency { get; set; }

        /// <summary>
        /// The seat associated with the ticket.
        /// </summary>
        [JsonPropertyName("ticketedSeat")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ISeat> TicketedSeat { get; set; }

        /// <summary>
        /// The unique identifier for the ticket.
        /// </summary>
        [JsonPropertyName("ticketNumber")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TicketNumber { get; set; }

        /// <summary>
        /// Reference to an asset (e.g., Barcode, QR code image or PDF) usable for entrance.
        /// </summary>
        [JsonPropertyName("ticketToken")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> TicketToken { get; set; }

        /// <summary>
        /// The total price for the reservation or ticket, including applicable taxes, shipping, etc.&lt;br/&gt;&lt;br/&gt;
        /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
        /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [JsonPropertyName("totalPrice")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<decimal?, IPriceSpecification, string> TotalPrice { get; set; }

        /// <summary>
        /// The person or organization the reservation or ticket is for.
        /// </summary>
        [JsonPropertyName("underName")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> UnderName { get; set; }
    }
}
