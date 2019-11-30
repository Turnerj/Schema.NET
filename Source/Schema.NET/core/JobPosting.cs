namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
    public partial interface IJobPosting : IIntangible
    {
        /// <summary>
        /// The title of the job.
        /// </summary>
        OneOrMany<string> Title { get; set; }

        /// <summary>
        /// The location(s) applicants can apply from. This is usually used for telecommuting jobs where the applicant does not need to be in a physical office. Note: This should not be used for citizenship or work visa requirements.
        /// </summary>
        OneOrMany<IAdministrativeArea> ApplicantLocationRequirements { get; set; }

        /// <summary>
        /// The base salary of the job or of an employee in an EmployeeRole.
        /// </summary>
        Values<IMonetaryAmount, decimal?, IPriceSpecification> BaseSalary { get; set; }

        /// <summary>
        /// Publication date for the job posting.
        /// </summary>
        Values<int?, DateTime?> DatePosted { get; set; }

        /// <summary>
        /// Educational background needed for the position or Occupation.
        /// </summary>
        OneOrMany<string> EducationRequirements { get; set; }

        /// <summary>
        /// Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).
        /// </summary>
        OneOrMany<string> EmploymentType { get; set; }

        /// <summary>
        /// Indicates the department, unit and/or facility where the employee reports and/or in which the job is to be performed.
        /// </summary>
        OneOrMany<IOrganization> EmploymentUnit { get; set; }

        /// <summary>
        /// An estimated salary for a job posting or occupation, based on a variety of variables including, but not limited to industry, job title, and location. Estimated salaries  are often computed by outside organizations rather than the hiring organization, who may not have committed to the estimated value.
        /// </summary>
        Values<IMonetaryAmount, IMonetaryAmountDistribution, decimal?> EstimatedSalary { get; set; }

        /// <summary>
        /// Description of skills and experience needed for the position or Occupation.
        /// </summary>
        OneOrMany<string> ExperienceRequirements { get; set; }

        /// <summary>
        /// Organization offering the job position.
        /// </summary>
        OneOrMany<IOrganization> HiringOrganization { get; set; }

        /// <summary>
        /// Description of bonus and commission compensation aspects of the job.
        /// </summary>
        OneOrMany<string> IncentiveCompensation { get; set; }

        /// <summary>
        /// The industry associated with the job position.
        /// </summary>
        OneOrMany<string> Industry { get; set; }

        /// <summary>
        /// Description of benefits associated with the job.
        /// </summary>
        OneOrMany<string> JobBenefits { get; set; }

        /// <summary>
        /// An indicator as to whether a position is available for an immediate start.
        /// </summary>
        OneOrMany<bool?> JobImmediateStart { get; set; }

        /// <summary>
        /// A (typically single) geographic location associated with the job position.
        /// </summary>
        OneOrMany<IPlace> JobLocation { get; set; }

        /// <summary>
        /// A description of the job location (e.g TELECOMMUTE for telecommute jobs).
        /// </summary>
        OneOrMany<string> JobLocationType { get; set; }

        /// <summary>
        /// The date on which a successful applicant for this job would be expected to start work. Choose a specific date in the future or use the jobImmediateStart property to indicate the position is to be filled as soon as possible.
        /// </summary>
        Values<int?, DateTime?, string> JobStartDate { get; set; }

        /// <summary>
        /// A category describing the job, preferably using a term from a taxonomy such as &lt;a href="http://www.onetcenter.org/taxonomy.html"&gt;BLS O*NET-SOC&lt;/a&gt;, &lt;a href="https://www.ilo.org/public/english/bureau/stat/isco/isco08/"&gt;ISCO-08&lt;/a&gt; or similar, with the property repeated for each applicable value. Ideally the taxonomy should be identified, and both the textual label and formal code for the category should be provided.&lt;br/&gt;&lt;br/&gt;
        /// Note: for historical reasons, any textual label and formal code provided as a literal may be assumed to be from O*NET-SOC.
        /// </summary>
        OneOrMany<string> OccupationalCategory { get; set; }

        /// <summary>
        /// Specific qualifications required for this role or Occupation.
        /// </summary>
        OneOrMany<string> Qualifications { get; set; }

        /// <summary>
        /// The Occupation for the JobPosting.
        /// </summary>
        OneOrMany<IOccupation> RelevantOccupation { get; set; }

        /// <summary>
        /// Responsibilities associated with this role or Occupation.
        /// </summary>
        OneOrMany<string> Responsibilities { get; set; }

        /// <summary>
        /// The currency (coded using &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; ) used for the main salary information in this job posting or for this employee.
        /// </summary>
        OneOrMany<string> SalaryCurrency { get; set; }

        /// <summary>
        /// A statement of knowledge, skill, ability, task or any other assertion expressing a competency that is desired or required to fulfill this role or to work in this occupation.
        /// </summary>
        OneOrMany<string> Skills { get; set; }

        /// <summary>
        /// Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.
        /// </summary>
        OneOrMany<string> SpecialCommitments { get; set; }

        /// <summary>
        /// The number of positions open for this job posting. Use a positive integer. Do not use if the number of positions is unclear or not known.
        /// </summary>
        OneOrMany<int?> TotalJobOpenings { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }

        /// <summary>
        /// The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).
        /// </summary>
        OneOrMany<string> WorkHours { get; set; }
    }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
    public partial class JobPosting : Intangible, IJobPosting
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "JobPosting";

        /// <summary>
        /// The title of the job.
        /// </summary>
        [JsonPropertyName("title")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Title { get; set; }

        /// <summary>
        /// The location(s) applicants can apply from. This is usually used for telecommuting jobs where the applicant does not need to be in a physical office. Note: This should not be used for citizenship or work visa requirements.
        /// </summary>
        [JsonPropertyName("applicantLocationRequirements")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAdministrativeArea> ApplicantLocationRequirements { get; set; }

        /// <summary>
        /// The base salary of the job or of an employee in an EmployeeRole.
        /// </summary>
        [JsonPropertyName("baseSalary")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMonetaryAmount, decimal?, IPriceSpecification> BaseSalary { get; set; }

        /// <summary>
        /// Publication date for the job posting.
        /// </summary>
        [JsonPropertyName("datePosted")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> DatePosted { get; set; }

        /// <summary>
        /// Educational background needed for the position or Occupation.
        /// </summary>
        [JsonPropertyName("educationRequirements")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> EducationRequirements { get; set; }

        /// <summary>
        /// Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).
        /// </summary>
        [JsonPropertyName("employmentType")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> EmploymentType { get; set; }

        /// <summary>
        /// Indicates the department, unit and/or facility where the employee reports and/or in which the job is to be performed.
        /// </summary>
        [JsonPropertyName("employmentUnit")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> EmploymentUnit { get; set; }

        /// <summary>
        /// An estimated salary for a job posting or occupation, based on a variety of variables including, but not limited to industry, job title, and location. Estimated salaries  are often computed by outside organizations rather than the hiring organization, who may not have committed to the estimated value.
        /// </summary>
        [JsonPropertyName("estimatedSalary")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMonetaryAmount, IMonetaryAmountDistribution, decimal?> EstimatedSalary { get; set; }

        /// <summary>
        /// Description of skills and experience needed for the position or Occupation.
        /// </summary>
        [JsonPropertyName("experienceRequirements")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ExperienceRequirements { get; set; }

        /// <summary>
        /// Organization offering the job position.
        /// </summary>
        [JsonPropertyName("hiringOrganization")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> HiringOrganization { get; set; }

        /// <summary>
        /// Description of bonus and commission compensation aspects of the job.
        /// </summary>
        [JsonPropertyName("incentiveCompensation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> IncentiveCompensation { get; set; }

        /// <summary>
        /// The industry associated with the job position.
        /// </summary>
        [JsonPropertyName("industry")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Industry { get; set; }

        /// <summary>
        /// Description of benefits associated with the job.
        /// </summary>
        [JsonPropertyName("jobBenefits")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> JobBenefits { get; set; }

        /// <summary>
        /// An indicator as to whether a position is available for an immediate start.
        /// </summary>
        [JsonPropertyName("jobImmediateStart")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> JobImmediateStart { get; set; }

        /// <summary>
        /// A (typically single) geographic location associated with the job position.
        /// </summary>
        [JsonPropertyName("jobLocation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> JobLocation { get; set; }

        /// <summary>
        /// A description of the job location (e.g TELECOMMUTE for telecommute jobs).
        /// </summary>
        [JsonPropertyName("jobLocationType")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> JobLocationType { get; set; }

        /// <summary>
        /// The date on which a successful applicant for this job would be expected to start work. Choose a specific date in the future or use the jobImmediateStart property to indicate the position is to be filled as soon as possible.
        /// </summary>
        [JsonPropertyName("jobStartDate")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, string> JobStartDate { get; set; }

        /// <summary>
        /// A category describing the job, preferably using a term from a taxonomy such as &lt;a href="http://www.onetcenter.org/taxonomy.html"&gt;BLS O*NET-SOC&lt;/a&gt;, &lt;a href="https://www.ilo.org/public/english/bureau/stat/isco/isco08/"&gt;ISCO-08&lt;/a&gt; or similar, with the property repeated for each applicable value. Ideally the taxonomy should be identified, and both the textual label and formal code for the category should be provided.&lt;br/&gt;&lt;br/&gt;
        /// Note: for historical reasons, any textual label and formal code provided as a literal may be assumed to be from O*NET-SOC.
        /// </summary>
        [JsonPropertyName("occupationalCategory")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> OccupationalCategory { get; set; }

        /// <summary>
        /// Specific qualifications required for this role or Occupation.
        /// </summary>
        [JsonPropertyName("qualifications")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Qualifications { get; set; }

        /// <summary>
        /// The Occupation for the JobPosting.
        /// </summary>
        [JsonPropertyName("relevantOccupation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOccupation> RelevantOccupation { get; set; }

        /// <summary>
        /// Responsibilities associated with this role or Occupation.
        /// </summary>
        [JsonPropertyName("responsibilities")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Responsibilities { get; set; }

        /// <summary>
        /// The currency (coded using &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; ) used for the main salary information in this job posting or for this employee.
        /// </summary>
        [JsonPropertyName("salaryCurrency")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SalaryCurrency { get; set; }

        /// <summary>
        /// A statement of knowledge, skill, ability, task or any other assertion expressing a competency that is desired or required to fulfill this role or to work in this occupation.
        /// </summary>
        [JsonPropertyName("skills")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Skills { get; set; }

        /// <summary>
        /// Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.
        /// </summary>
        [JsonPropertyName("specialCommitments")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SpecialCommitments { get; set; }

        /// <summary>
        /// The number of positions open for this job posting. Use a positive integer. Do not use if the number of positions is unclear or not known.
        /// </summary>
        [JsonPropertyName("totalJobOpenings")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> TotalJobOpenings { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [JsonPropertyName("validThrough")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }

        /// <summary>
        /// The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).
        /// </summary>
        [JsonPropertyName("workHours")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> WorkHours { get; set; }
    }
}
