﻿namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of physically/electronically taking delivery of an object thathas been transferred from an origin to a destination. Reciprocal of SendAction.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SendAction"&gt;SendAction&lt;/a&gt;: The reciprocal of ReceiveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/TakeAction"&gt;TakeAction&lt;/a&gt;: Unlike TakeAction, ReceiveAction does not imply that the ownership has been transfered (e.g. I can receive a package, but it does not mean the package is now mine).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IReceiveAction : ITransferAction
    {
        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        OneOrMany<DeliveryMethod?> DeliveryMethod { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the sending end of the action.
        /// </summary>
        Values<IAudience, IOrganization, IPerson> Sender { get; set; }
    }

    /// <summary>
    /// The act of physically/electronically taking delivery of an object thathas been transferred from an origin to a destination. Reciprocal of SendAction.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SendAction"&gt;SendAction&lt;/a&gt;: The reciprocal of ReceiveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/TakeAction"&gt;TakeAction&lt;/a&gt;: Unlike TakeAction, ReceiveAction does not imply that the ownership has been transfered (e.g. I can receive a package, but it does not mean the package is now mine).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial class ReceiveAction : TransferAction, IReceiveAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ReceiveAction";

        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        [JsonPropertyName("deliveryMethod")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DeliveryMethod?> DeliveryMethod { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the sending end of the action.
        /// </summary>
        [JsonPropertyName("sender")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAudience, IOrganization, IPerson> Sender { get; set; }
    }
}
