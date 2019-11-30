﻿namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of notifying someone of information pertinent to them, with no expectation of a response.
    /// </summary>
    public partial interface IInformAction : ICommunicateAction
    {
        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        OneOrMany<IEvent> Event { get; set; }
    }

    /// <summary>
    /// The act of notifying someone of information pertinent to them, with no expectation of a response.
    /// </summary>
    public partial class InformAction : CommunicateAction, IInformAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "InformAction";

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [JsonPropertyName("event")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEvent> Event { get; set; }
    }
}
