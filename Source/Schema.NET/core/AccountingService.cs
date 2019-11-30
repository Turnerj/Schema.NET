namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Accountancy business.&lt;br/&gt;&lt;br/&gt;
    /// As a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; it can be described as a &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; of one or more &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;(s).
    /// </summary>
    public partial interface IAccountingService : IFinancialService
    {
    }

    /// <summary>
    /// Accountancy business.&lt;br/&gt;&lt;br/&gt;
    /// As a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; it can be described as a &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; of one or more &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;(s).
    /// </summary>
    public partial class AccountingService : FinancialService, IAccountingService
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AccountingService";
    }
}
