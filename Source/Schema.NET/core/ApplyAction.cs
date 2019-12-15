﻿namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of registering to an organization/service without the guarantee to receive it.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: Unlike RegisterAction, ApplyAction has no guarantees that the application will be accepted.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IApplyAction : IOrganizeAction
    {
    }

    /// <summary>
    /// The act of registering to an organization/service without the guarantee to receive it.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: Unlike RegisterAction, ApplyAction has no guarantees that the application will be accepted.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial class ApplyAction : OrganizeAction, IApplyAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ApplyAction";
    }
}
