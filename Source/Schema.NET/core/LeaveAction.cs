﻿namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An agent leaves an event / group with participants/friends at a location.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/JoinAction"&gt;JoinAction&lt;/a&gt;: The antonym of LeaveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/UnRegisterAction"&gt;UnRegisterAction&lt;/a&gt;: Unlike UnRegisterAction, LeaveAction implies leaving a group/team of people rather than a service.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface ILeaveAction : IInteractAction
    {
        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        OneOrMany<IEvent> Event { get; set; }
    }

    /// <summary>
    /// An agent leaves an event / group with participants/friends at a location.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/JoinAction"&gt;JoinAction&lt;/a&gt;: The antonym of LeaveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/UnRegisterAction"&gt;UnRegisterAction&lt;/a&gt;: Unlike UnRegisterAction, LeaveAction implies leaving a group/team of people rather than a service.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial class LeaveAction : InteractAction, ILeaveAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "LeaveAction";

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [JsonPropertyName("event")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEvent> Event { get; set; }
    }
}
