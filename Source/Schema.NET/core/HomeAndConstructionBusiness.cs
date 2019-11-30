namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A construction business.&lt;br/&gt;&lt;br/&gt;
    /// A HomeAndConstructionBusiness is a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; that provides services around homes and buildings.&lt;br/&gt;&lt;br/&gt;
    /// As a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; it can be described as a &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; of one or more &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;(s).
    /// </summary>
    public partial interface IHomeAndConstructionBusiness : ILocalBusiness
    {
    }

    /// <summary>
    /// A construction business.&lt;br/&gt;&lt;br/&gt;
    /// A HomeAndConstructionBusiness is a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; that provides services around homes and buildings.&lt;br/&gt;&lt;br/&gt;
    /// As a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; it can be described as a &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; of one or more &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;(s).
    /// </summary>
    public partial class HomeAndConstructionBusiness : LocalBusiness, IHomeAndConstructionBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "HomeAndConstructionBusiness";
    }
}
