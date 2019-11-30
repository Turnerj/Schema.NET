namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
    public partial interface IPerson : IThing
    {
        /// <summary>
        /// An additional name for a Person, can be used for a middle name.
        /// </summary>
        OneOrMany<string> AdditionalName { get; set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        Values<IPostalAddress, string> Address { get; set; }

        /// <summary>
        /// An organization that this person is affiliated with. For example, a school/university, a club, or a team.
        /// </summary>
        OneOrMany<IOrganization> Affiliation { get; set; }

        /// <summary>
        /// An organization that the person is an alumni of.
        /// </summary>
        Values<IEducationalOrganization, IOrganization> AlumniOf { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        OneOrMany<string> Award { get; set; }

        /// <summary>
        /// Date of birth.
        /// </summary>
        Values<int?, DateTime?> BirthDate { get; set; }

        /// <summary>
        /// The place where the person was born.
        /// </summary>
        OneOrMany<IPlace> BirthPlace { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        Values<IBrand, IOrganization> Brand { get; set; }

        /// <summary>
        /// A &lt;a href="https://en.wikipedia.org/wiki/Call_sign"&gt;callsign&lt;/a&gt;, as used in broadcasting and radio communications to identify people, radio and TV stations, or vehicles.
        /// </summary>
        OneOrMany<string> CallSign { get; set; }

        /// <summary>
        /// A child of the person.
        /// </summary>
        OneOrMany<IPerson> Children { get; set; }

        /// <summary>
        /// A colleague of the person.
        /// </summary>
        Values<IPerson, Uri> Colleague { get; set; }

        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        OneOrMany<IContactPoint> ContactPoint { get; set; }

        /// <summary>
        /// Date of death.
        /// </summary>
        Values<int?, DateTime?> DeathDate { get; set; }

        /// <summary>
        /// The place where the person died.
        /// </summary>
        OneOrMany<IPlace> DeathPlace { get; set; }

        /// <summary>
        /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        OneOrMany<string> Duns { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        OneOrMany<string> Email { get; set; }

        /// <summary>
        /// Family name. In the U.S., the last name of an Person. This can be used along with givenName instead of the name property.
        /// </summary>
        OneOrMany<string> FamilyName { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        OneOrMany<string> FaxNumber { get; set; }

        /// <summary>
        /// The most generic uni-directional social relation.
        /// </summary>
        OneOrMany<IPerson> Follows { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        Values<IOrganization, IPerson> Funder { get; set; }

        /// <summary>
        /// Gender of something, typically a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt;, but possibly also fictional characters, animals, etc. While http://schema.org/Male and http://schema.org/Female may be used, text strings are also acceptable for people who do not identify as a binary gender. The &lt;a class="localLink" href="http://schema.org/gender"&gt;gender&lt;/a&gt; property can also be used in an extended sense to cover e.g. the gender of sports teams. As with the gender of individuals, we do not try to enumerate all possibilities. A mixed-gender &lt;a class="localLink" href="http://schema.org/SportsTeam"&gt;SportsTeam&lt;/a&gt; can be indicated with a text value of "Mixed".
        /// </summary>
        Values<GenderType?, string> Gender { get; set; }

        /// <summary>
        /// Given name. In the U.S., the first name of a Person. This can be used along with familyName instead of the name property.
        /// </summary>
        OneOrMany<string> GivenName { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        OneOrMany<string> GlobalLocationNumber { get; set; }

        /// <summary>
        /// The Person's occupation. For past professions, use Role for expressing dates.
        /// </summary>
        OneOrMany<IOccupation> HasOccupation { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        OneOrMany<IOfferCatalog> HasOfferCatalog { get; set; }

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        OneOrMany<IPlace> HasPOS { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        Values<string, IQuantitativeValue> Height { get; set; }

        /// <summary>
        /// A contact location for a person's residence.
        /// </summary>
        Values<IContactPoint, IPlace> HomeLocation { get; set; }

        /// <summary>
        /// An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.
        /// </summary>
        OneOrMany<string> HonorificPrefix { get; set; }

        /// <summary>
        /// An honorific suffix preceding a Person's name such as M.D. /PhD/MSCSW.
        /// </summary>
        OneOrMany<string> HonorificSuffix { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        OneOrMany<string> IsicV4 { get; set; }

        /// <summary>
        /// The job title of the person (for example, Financial Manager).
        /// </summary>
        OneOrMany<string> JobTitle { get; set; }

        /// <summary>
        /// The most generic bi-directional social/work relation.
        /// </summary>
        OneOrMany<IPerson> Knows { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a topic that is known about - suggesting possible expertise but not implying it. We do not distinguish skill levels here, or relate this to educational content, events, objectives or &lt;a class="localLink" href="http://schema.org/JobPosting"&gt;JobPosting&lt;/a&gt; descriptions.
        /// </summary>
        Values<string, IThing, Uri> KnowsAbout { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a known language. We do not distinguish skill levels or reading/writing/speaking/signing here. Use language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;.
        /// </summary>
        Values<ILanguage, string> KnowsLanguage { get; set; }

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        OneOrMany<IOffer> MakesOffer { get; set; }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        Values<IOrganization, IProgramMembership> MemberOf { get; set; }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        OneOrMany<string> Naics { get; set; }

        /// <summary>
        /// Nationality of the person.
        /// </summary>
        OneOrMany<ICountry> Nationality { get; set; }

        /// <summary>
        /// The total financial value of the person as calculated by subtracting assets from liabilities.
        /// </summary>
        Values<IMonetaryAmount, IPriceSpecification> NetWorth { get; set; }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        Values<IOwnershipInfo, IProduct> Owns { get; set; }

        /// <summary>
        /// A parent of this person.
        /// </summary>
        OneOrMany<IPerson> Parent { get; set; }

        /// <summary>
        /// Event that this person is a performer or participant in.
        /// </summary>
        OneOrMany<IEvent> PerformerIn { get; set; }

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        Values<ICreativeWork, Uri> PublishingPrinciples { get; set; }

        /// <summary>
        /// The most generic familial relation.
        /// </summary>
        OneOrMany<IPerson> RelatedTo { get; set; }

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        OneOrMany<IDemand> Seeks { get; set; }

        /// <summary>
        /// A sibling of the person.
        /// </summary>
        OneOrMany<IPerson> Sibling { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        Values<IOrganization, IPerson> Sponsor { get; set; }

        /// <summary>
        /// The person's spouse.
        /// </summary>
        OneOrMany<IPerson> Spouse { get; set; }

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        OneOrMany<string> TaxID { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        OneOrMany<string> Telephone { get; set; }

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        OneOrMany<string> VatID { get; set; }

        /// <summary>
        /// The weight of the product or person.
        /// </summary>
        OneOrMany<IQuantitativeValue> Weight { get; set; }

        /// <summary>
        /// A contact location for a person's place of work.
        /// </summary>
        Values<IContactPoint, IPlace> WorkLocation { get; set; }

        /// <summary>
        /// Organizations that the person works for.
        /// </summary>
        OneOrMany<IOrganization> WorksFor { get; set; }
    }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
    public partial class Person : Thing, IPerson
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Person";

        /// <summary>
        /// An additional name for a Person, can be used for a middle name.
        /// </summary>
        [JsonPropertyName("additionalName")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AdditionalName { get; set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [JsonPropertyName("address")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPostalAddress, string> Address { get; set; }

        /// <summary>
        /// An organization that this person is affiliated with. For example, a school/university, a club, or a team.
        /// </summary>
        [JsonPropertyName("affiliation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> Affiliation { get; set; }

        /// <summary>
        /// An organization that the person is an alumni of.
        /// </summary>
        [JsonPropertyName("alumniOf")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IEducationalOrganization, IOrganization> AlumniOf { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [JsonPropertyName("award")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Award { get; set; }

        /// <summary>
        /// Date of birth.
        /// </summary>
        [JsonPropertyName("birthDate")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> BirthDate { get; set; }

        /// <summary>
        /// The place where the person was born.
        /// </summary>
        [JsonPropertyName("birthPlace")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> BirthPlace { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [JsonPropertyName("brand")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IBrand, IOrganization> Brand { get; set; }

        /// <summary>
        /// A &lt;a href="https://en.wikipedia.org/wiki/Call_sign"&gt;callsign&lt;/a&gt;, as used in broadcasting and radio communications to identify people, radio and TV stations, or vehicles.
        /// </summary>
        [JsonPropertyName("callSign")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CallSign { get; set; }

        /// <summary>
        /// A child of the person.
        /// </summary>
        [JsonPropertyName("children")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Children { get; set; }

        /// <summary>
        /// A colleague of the person.
        /// </summary>
        [JsonPropertyName("colleague")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPerson, Uri> Colleague { get; set; }

        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        [JsonPropertyName("contactPoint")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IContactPoint> ContactPoint { get; set; }

        /// <summary>
        /// Date of death.
        /// </summary>
        [JsonPropertyName("deathDate")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> DeathDate { get; set; }

        /// <summary>
        /// The place where the person died.
        /// </summary>
        [JsonPropertyName("deathPlace")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> DeathPlace { get; set; }

        /// <summary>
        /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        [JsonPropertyName("duns")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Duns { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [JsonPropertyName("email")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Email { get; set; }

        /// <summary>
        /// Family name. In the U.S., the last name of an Person. This can be used along with givenName instead of the name property.
        /// </summary>
        [JsonPropertyName("familyName")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> FamilyName { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [JsonPropertyName("faxNumber")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> FaxNumber { get; set; }

        /// <summary>
        /// The most generic uni-directional social relation.
        /// </summary>
        [JsonPropertyName("follows")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Follows { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [JsonPropertyName("funder")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Funder { get; set; }

        /// <summary>
        /// Gender of something, typically a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt;, but possibly also fictional characters, animals, etc. While http://schema.org/Male and http://schema.org/Female may be used, text strings are also acceptable for people who do not identify as a binary gender. The &lt;a class="localLink" href="http://schema.org/gender"&gt;gender&lt;/a&gt; property can also be used in an extended sense to cover e.g. the gender of sports teams. As with the gender of individuals, we do not try to enumerate all possibilities. A mixed-gender &lt;a class="localLink" href="http://schema.org/SportsTeam"&gt;SportsTeam&lt;/a&gt; can be indicated with a text value of "Mixed".
        /// </summary>
        [JsonPropertyName("gender")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<GenderType?, string> Gender { get; set; }

        /// <summary>
        /// Given name. In the U.S., the first name of a Person. This can be used along with familyName instead of the name property.
        /// </summary>
        [JsonPropertyName("givenName")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> GivenName { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [JsonPropertyName("globalLocationNumber")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> GlobalLocationNumber { get; set; }

        /// <summary>
        /// The Person's occupation. For past professions, use Role for expressing dates.
        /// </summary>
        [JsonPropertyName("hasOccupation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOccupation> HasOccupation { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [JsonPropertyName("hasOfferCatalog")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOfferCatalog> HasOfferCatalog { get; set; }

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        [JsonPropertyName("hasPOS")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> HasPOS { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [JsonPropertyName("height")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IQuantitativeValue> Height { get; set; }

        /// <summary>
        /// A contact location for a person's residence.
        /// </summary>
        [JsonPropertyName("homeLocation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IContactPoint, IPlace> HomeLocation { get; set; }

        /// <summary>
        /// An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.
        /// </summary>
        [JsonPropertyName("honorificPrefix")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> HonorificPrefix { get; set; }

        /// <summary>
        /// An honorific suffix preceding a Person's name such as M.D. /PhD/MSCSW.
        /// </summary>
        [JsonPropertyName("honorificSuffix")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> HonorificSuffix { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [JsonPropertyName("isicV4")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> IsicV4 { get; set; }

        /// <summary>
        /// The job title of the person (for example, Financial Manager).
        /// </summary>
        [JsonPropertyName("jobTitle")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> JobTitle { get; set; }

        /// <summary>
        /// The most generic bi-directional social/work relation.
        /// </summary>
        [JsonPropertyName("knows")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Knows { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a topic that is known about - suggesting possible expertise but not implying it. We do not distinguish skill levels here, or relate this to educational content, events, objectives or &lt;a class="localLink" href="http://schema.org/JobPosting"&gt;JobPosting&lt;/a&gt; descriptions.
        /// </summary>
        [JsonPropertyName("knowsAbout")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IThing, Uri> KnowsAbout { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a known language. We do not distinguish skill levels or reading/writing/speaking/signing here. Use language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("knowsLanguage")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ILanguage, string> KnowsLanguage { get; set; }

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        [JsonPropertyName("makesOffer")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOffer> MakesOffer { get; set; }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        [JsonPropertyName("memberOf")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IProgramMembership> MemberOf { get; set; }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        [JsonPropertyName("naics")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Naics { get; set; }

        /// <summary>
        /// Nationality of the person.
        /// </summary>
        [JsonPropertyName("nationality")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICountry> Nationality { get; set; }

        /// <summary>
        /// The total financial value of the person as calculated by subtracting assets from liabilities.
        /// </summary>
        [JsonPropertyName("netWorth")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMonetaryAmount, IPriceSpecification> NetWorth { get; set; }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        [JsonPropertyName("owns")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOwnershipInfo, IProduct> Owns { get; set; }

        /// <summary>
        /// A parent of this person.
        /// </summary>
        [JsonPropertyName("parent")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Parent { get; set; }

        /// <summary>
        /// Event that this person is a performer or participant in.
        /// </summary>
        [JsonPropertyName("performerIn")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEvent> PerformerIn { get; set; }

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        [JsonPropertyName("publishingPrinciples")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, Uri> PublishingPrinciples { get; set; }

        /// <summary>
        /// The most generic familial relation.
        /// </summary>
        [JsonPropertyName("relatedTo")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> RelatedTo { get; set; }

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        [JsonPropertyName("seeks")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDemand> Seeks { get; set; }

        /// <summary>
        /// A sibling of the person.
        /// </summary>
        [JsonPropertyName("sibling")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Sibling { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [JsonPropertyName("sponsor")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Sponsor { get; set; }

        /// <summary>
        /// The person's spouse.
        /// </summary>
        [JsonPropertyName("spouse")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Spouse { get; set; }

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        [JsonPropertyName("taxID")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TaxID { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [JsonPropertyName("telephone")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Telephone { get; set; }

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        [JsonPropertyName("vatID")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> VatID { get; set; }

        /// <summary>
        /// The weight of the product or person.
        /// </summary>
        [JsonPropertyName("weight")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> Weight { get; set; }

        /// <summary>
        /// A contact location for a person's place of work.
        /// </summary>
        [JsonPropertyName("workLocation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IContactPoint, IPlace> WorkLocation { get; set; }

        /// <summary>
        /// Organizations that the person works for.
        /// </summary>
        [JsonPropertyName("worksFor")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> WorksFor { get; set; }
    }
}
