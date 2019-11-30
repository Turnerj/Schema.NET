namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.
    /// </summary>
    public partial interface IProgramMembership : IIntangible
    {
        /// <summary>
        /// The organization (airline, travelers' club, etc.) the membership is made with.
        /// </summary>
        OneOrMany<IOrganization> HostingOrganization { get; set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        Values<IOrganization, IPerson> Member { get; set; }

        /// <summary>
        /// A unique identifier for the membership.
        /// </summary>
        OneOrMany<string> MembershipNumber { get; set; }

        /// <summary>
        /// The number of membership points earned by the member. If necessary, the unitText can be used to express the units the points are issued in. (e.g. stars, miles, etc.)
        /// </summary>
        Values<double?, IQuantitativeValue> MembershipPointsEarned { get; set; }

        /// <summary>
        /// The program providing the membership.
        /// </summary>
        OneOrMany<string> ProgramName { get; set; }
    }

    /// <summary>
    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.
    /// </summary>
    public partial class ProgramMembership : Intangible, IProgramMembership
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ProgramMembership";

        /// <summary>
        /// The organization (airline, travelers' club, etc.) the membership is made with.
        /// </summary>
        [JsonPropertyName("hostingOrganization")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> HostingOrganization { get; set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [JsonPropertyName("member")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Member { get; set; }

        /// <summary>
        /// A unique identifier for the membership.
        /// </summary>
        [JsonPropertyName("membershipNumber")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> MembershipNumber { get; set; }

        /// <summary>
        /// The number of membership points earned by the member. If necessary, the unitText can be used to express the units the points are issued in. (e.g. stars, miles, etc.)
        /// </summary>
        [JsonPropertyName("membershipPointsEarned")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, IQuantitativeValue> MembershipPointsEarned { get; set; }

        /// <summary>
        /// The program providing the membership.
        /// </summary>
        [JsonPropertyName("programName")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ProgramName { get; set; }
    }
}
