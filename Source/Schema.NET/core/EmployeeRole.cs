namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A subclass of OrganizationRole used to describe employee relationships.
    /// </summary>
    public partial interface IEmployeeRole : IOrganizationRole
    {
        /// <summary>
        /// The base salary of the job or of an employee in an EmployeeRole.
        /// </summary>
        Values<IMonetaryAmount, decimal?, IPriceSpecification> BaseSalary { get; set; }

        /// <summary>
        /// The currency (coded using &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; ) used for the main salary information in this job posting or for this employee.
        /// </summary>
        OneOrMany<string> SalaryCurrency { get; set; }
    }

    /// <summary>
    /// A subclass of OrganizationRole used to describe employee relationships.
    /// </summary>
    public partial class EmployeeRole : OrganizationRole, IEmployeeRole
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "EmployeeRole";

        /// <summary>
        /// The base salary of the job or of an employee in an EmployeeRole.
        /// </summary>
        [JsonPropertyName("baseSalary")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMonetaryAmount, decimal?, IPriceSpecification> BaseSalary { get; set; }

        /// <summary>
        /// The currency (coded using &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; ) used for the main salary information in this job posting or for this employee.
        /// </summary>
        [JsonPropertyName("salaryCurrency")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SalaryCurrency { get; set; }
    }
}
