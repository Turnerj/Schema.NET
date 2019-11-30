﻿namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of playing/exercising/training/performing for enjoyment, leisure, recreation, Competition or exercise.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ListenAction"&gt;ListenAction&lt;/a&gt;: Unlike ListenAction (which is under ConsumeAction), PlayAction refers to performing for an audience or at an event, rather than consuming music.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/WatchAction"&gt;WatchAction&lt;/a&gt;: Unlike WatchAction (which is under ConsumeAction), PlayAction refers to showing/displaying for an audience or at an event, rather than consuming visual content.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IPlayAction : IAction
    {
        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        OneOrMany<IAudience> Audience { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        OneOrMany<IEvent> Event { get; set; }
    }

    /// <summary>
    /// The act of playing/exercising/training/performing for enjoyment, leisure, recreation, Competition or exercise.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ListenAction"&gt;ListenAction&lt;/a&gt;: Unlike ListenAction (which is under ConsumeAction), PlayAction refers to performing for an audience or at an event, rather than consuming music.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/WatchAction"&gt;WatchAction&lt;/a&gt;: Unlike WatchAction (which is under ConsumeAction), PlayAction refers to showing/displaying for an audience or at an event, rather than consuming visual content.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial class PlayAction : Action, IPlayAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PlayAction";

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [JsonPropertyName("audience")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAudience> Audience { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [JsonPropertyName("event")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEvent> Event { get; set; }
    }
}
