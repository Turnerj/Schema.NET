﻿namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// See Organization, Place for more information.
    /// </summary>
    public partial interface IOrganizationAndPlace : IOrganization, IPlace
    {
    }

    /// <summary>
    /// See Organization, Place for more information.
    /// </summary>
    public abstract partial class OrganizationAndPlace : Thing, IOrganizationAndPlace
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "OrganizationAndPlace";

        /// <summary>
        /// For a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt; or other news-related &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, a statement about public engagement activities (for news media, the newsroom’s), including involving the public - digitally or otherwise -- in coverage decisions, reporting and activities after publication.
        /// </summary>
        [JsonPropertyName("actionableFeedbackPolicy")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<ICreativeWork, Uri> ActionableFeedbackPolicy { get; set; }

        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;br/&gt;&lt;br/&gt;
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        [JsonPropertyName("additionalProperty")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPropertyValue> AdditionalProperty { get; set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [JsonPropertyName("address")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<IPostalAddress, string> Address { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [JsonPropertyName("aggregateRating")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IAggregateRating> AggregateRating { get; set; }

        /// <summary>
        /// Alumni of an organization.
        /// </summary>
        [JsonPropertyName("alumni")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPerson> Alumni { get; set; }

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        [JsonPropertyName("amenityFeature")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<ILocationFeatureSpecification> AmenityFeature { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [JsonPropertyName("areaServed")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<IAdministrativeArea, IGeoShape, IPlace, string> AreaServed { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [JsonPropertyName("award")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<string> Award { get; set; }

        /// <summary>
        /// A short textual code (also called "store code") that uniquely identifies a place of business. The code is typically assigned by the parentOrganization and used in structured URLs.&lt;br/&gt;&lt;br/&gt;
        /// For example, in the URL http://www.starbucks.co.uk/store-locator/etc/detail/3047 the code "3047" is a branchCode for a particular branch.
        /// </summary>
        [JsonPropertyName("branchCode")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<string> BranchCode { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [JsonPropertyName("brand")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<IBrand, IOrganization> Brand { get; set; }

        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        [JsonPropertyName("contactPoint")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IContactPoint> ContactPoint { get; set; }

        /// <summary>
        /// The basic containment relation between a place and one that contains it.
        /// </summary>
        [JsonPropertyName("containedInPlace")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPlace> ContainedInPlace { get; set; }

        /// <summary>
        /// The basic containment relation between a place and another that it contains.
        /// </summary>
        [JsonPropertyName("containsPlace")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPlace> ContainsPlace { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a statement describing (in news media, the newsroom’s) disclosure and correction policy for errors.
        /// </summary>
        [JsonPropertyName("correctionsPolicy")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<ICreativeWork, Uri> CorrectionsPolicy { get; set; }

        /// <summary>
        /// A relationship between an organization and a department of that organization, also described as an organization (allowing different urls, logos, opening hours). For example: a store with a pharmacy, or a bakery with a cafe.
        /// </summary>
        [JsonPropertyName("department")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IOrganization> Department { get; set; }

        /// <summary>
        /// The date that this organization was dissolved.
        /// </summary>
        [JsonPropertyName("dissolutionDate")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public virtual Values<int?, DateTime?> DissolutionDate { get; set; }

        /// <summary>
        /// Statement on diversity policy by an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; e.g. a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;. For a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;, a statement describing the newsroom’s diversity policy on both staffing and sources, typically providing staffing data.
        /// </summary>
        [JsonPropertyName("diversityPolicy")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<ICreativeWork, Uri> DiversityPolicy { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (often but not necessarily a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a report on staffing diversity issues. In a news context this might be for example ASNE or RTDNA (US) reports, or self-reported.
        /// </summary>
        [JsonPropertyName("diversityStaffingReport")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<IArticle, Uri> DiversityStaffingReport { get; set; }

        /// <summary>
        /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        [JsonPropertyName("duns")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<string> Duns { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [JsonPropertyName("email")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<string> Email { get; set; }

        /// <summary>
        /// Someone working for this organization.
        /// </summary>
        [JsonPropertyName("employee")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPerson> Employee { get; set; }

        /// <summary>
        /// Statement about ethics policy, e.g. of a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt; regarding journalistic and publishing practices, or of a &lt;a class="localLink" href="http://schema.org/Restaurant"&gt;Restaurant&lt;/a&gt;, a page describing food source policies. In the case of a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;, an ethicsPolicy is typically a statement describing the personal, organizational, and corporate standards of behavior expected by the organization.
        /// </summary>
        [JsonPropertyName("ethicsPolicy")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<ICreativeWork, Uri> EthicsPolicy { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [JsonPropertyName("event")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IEvent> Event { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [JsonPropertyName("faxNumber")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<string> FaxNumber { get; set; }

        /// <summary>
        /// A person who founded this organization.
        /// </summary>
        [JsonPropertyName("founder")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPerson> Founder { get; set; }

        /// <summary>
        /// The date that this organization was founded.
        /// </summary>
        [JsonPropertyName("foundingDate")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public virtual Values<int?, DateTime?> FoundingDate { get; set; }

        /// <summary>
        /// The place where the Organization was founded.
        /// </summary>
        [JsonPropertyName("foundingLocation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPlace> FoundingLocation { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [JsonPropertyName("funder")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<IOrganization, IPerson> Funder { get; set; }

        /// <summary>
        /// The geo coordinates of the place.
        /// </summary>
        [JsonPropertyName("geo")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<IGeoCoordinates, IGeoShape> Geo { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a containing geometry to a contained geometry. "a contains b iff no points of b lie in the exterior of a, and at least one point of the interior of b lies in the interior of a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("geoContains")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPlace> GeoContains { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that covers it. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("geoCoveredBy")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPlace> GeoCoveredBy { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a covering geometry to a covered geometry. "Every point of b is a point of (the interior or boundary of) a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("geoCovers")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPlace> GeoCovers { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that crosses it: "a crosses b: they have some but not all interior points in common, and the dimension of the intersection is less than that of at least one of them". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("geoCrosses")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPlace> GeoCrosses { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) are topologically disjoint: they have no point in common. They form a set of disconnected geometries." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;)
        /// </summary>
        [JsonPropertyName("geoDisjoint")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPlace> GeoDisjoint { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) are topologically equal, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;. "Two geometries are topologically equal if their interiors intersect and no part of the interior or boundary of one geometry intersects the exterior of the other" (a symmetric relationship)
        /// </summary>
        [JsonPropertyName("geoEquals")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPlace> GeoEquals { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) have at least one point in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("geoIntersects")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPlace> GeoIntersects { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that geospatially overlaps it, i.e. they have some but not all points in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("geoOverlaps")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPlace> GeoOverlaps { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) touch: they have at least one boundary point in common, but no interior points." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt; )
        /// </summary>
        [JsonPropertyName("geoTouches")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPlace> GeoTouches { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to one that contains it, i.e. it is inside (i.e. within) its interior. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("geoWithin")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPlace> GeoWithin { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [JsonPropertyName("globalLocationNumber")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<string> GlobalLocationNumber { get; set; }

        /// <summary>
        /// A URL to a map of the place.
        /// </summary>
        [JsonPropertyName("hasMap")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<IMap, Uri> HasMap { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [JsonPropertyName("hasOfferCatalog")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IOfferCatalog> HasOfferCatalog { get; set; }

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        [JsonPropertyName("hasPOS")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPlace> HasPOS { get; set; }

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        [JsonPropertyName("isAccessibleForFree")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<bool?> IsAccessibleForFree { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [JsonPropertyName("isicV4")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<string> IsicV4 { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a topic that is known about - suggesting possible expertise but not implying it. We do not distinguish skill levels here, or relate this to educational content, events, objectives or &lt;a class="localLink" href="http://schema.org/JobPosting"&gt;JobPosting&lt;/a&gt; descriptions.
        /// </summary>
        [JsonPropertyName("knowsAbout")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<string, IThing, Uri> KnowsAbout { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a known language. We do not distinguish skill levels or reading/writing/speaking/signing here. Use language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("knowsLanguage")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<ILanguage, string> KnowsLanguage { get; set; }

        /// <summary>
        /// The latitude of a location. For example &lt;code&gt;37.42242&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [JsonPropertyName("latitude")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<double?, string> Latitude { get; set; }

        /// <summary>
        /// The official name of the organization, e.g. the registered company name.
        /// </summary>
        [JsonPropertyName("legalName")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<string> LegalName { get; set; }

        /// <summary>
        /// An organization identifier that uniquely identifies a legal entity as defined in ISO 17442.
        /// </summary>
        [JsonPropertyName("leiCode")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<string> LeiCode { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [JsonPropertyName("location")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<IPlace, IPostalAddress, string> Location { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [JsonPropertyName("logo")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<IImageObject, Uri> Logo { get; set; }

        /// <summary>
        /// The longitude of a location. For example &lt;code&gt;-122.08585&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [JsonPropertyName("longitude")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<double?, string> Longitude { get; set; }

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        [JsonPropertyName("makesOffer")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IOffer> MakesOffer { get; set; }

        /// <summary>
        /// The total number of individuals that may attend an event or venue.
        /// </summary>
        [JsonPropertyName("maximumAttendeeCapacity")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<int?> MaximumAttendeeCapacity { get; set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [JsonPropertyName("member")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<IOrganization, IPerson> Member { get; set; }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        [JsonPropertyName("memberOf")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<IOrganization, IProgramMembership> MemberOf { get; set; }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        [JsonPropertyName("naics")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<string> Naics { get; set; }

        /// <summary>
        /// The number of employees in an organization e.g. business.
        /// </summary>
        [JsonPropertyName("numberOfEmployees")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IQuantitativeValue> NumberOfEmployees { get; set; }

        /// <summary>
        /// The opening hours of a certain place.
        /// </summary>
        [JsonPropertyName("openingHoursSpecification")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IOpeningHoursSpecification> OpeningHoursSpecification { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (often but not necessarily a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a description of organizational ownership structure; funding and grants. In a news/media setting, this is with particular reference to editorial independence.   Note that the &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt; is also available and can be used to make basic funder information machine-readable.
        /// </summary>
        [JsonPropertyName("ownershipFundingInfo")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<IAboutPage, ICreativeWork, string, Uri> OwnershipFundingInfo { get; set; }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        [JsonPropertyName("owns")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<IOwnershipInfo, IProduct> Owns { get; set; }

        /// <summary>
        /// The larger organization that this organization is a &lt;a class="localLink" href="http://schema.org/subOrganization"&gt;subOrganization&lt;/a&gt; of, if any.
        /// </summary>
        [JsonPropertyName("parentOrganization")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IOrganization> ParentOrganization { get; set; }

        /// <summary>
        /// A photograph of this place.
        /// </summary>
        [JsonPropertyName("photo")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<IImageObject, IPhotograph> Photo { get; set; }

        /// <summary>
        /// A flag to signal that the &lt;a class="localLink" href="http://schema.org/Place"&gt;Place&lt;/a&gt; is open to public visitors.  If this property is omitted there is no assumed default boolean value
        /// </summary>
        [JsonPropertyName("publicAccess")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<bool?> PublicAccess { get; set; }

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        [JsonPropertyName("publishingPrinciples")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<ICreativeWork, Uri> PublishingPrinciples { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [JsonPropertyName("review")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IReview> Review { get; set; }

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        [JsonPropertyName("seeks")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IDemand> Seeks { get; set; }

        /// <summary>
        /// A slogan or motto associated with the item.
        /// </summary>
        [JsonPropertyName("slogan")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<string> Slogan { get; set; }

        /// <summary>
        /// Indicates whether it is allowed to smoke in the place, e.g. in the restaurant, hotel or hotel room.
        /// </summary>
        [JsonPropertyName("smokingAllowed")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<bool?> SmokingAllowed { get; set; }

        /// <summary>
        /// The special opening hours of a certain place.&lt;br/&gt;&lt;br/&gt;
        /// Use this to explicitly override general opening hours brought in scope by &lt;a class="localLink" href="http://schema.org/openingHoursSpecification"&gt;openingHoursSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/openingHours"&gt;openingHours&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("specialOpeningHoursSpecification")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IOpeningHoursSpecification> SpecialOpeningHoursSpecification { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [JsonPropertyName("sponsor")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<IOrganization, IPerson> Sponsor { get; set; }

        /// <summary>
        /// A relationship between two organizations where the first includes the second, e.g., as a subsidiary. See also: the more specific 'department' property.
        /// </summary>
        [JsonPropertyName("subOrganization")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IOrganization> SubOrganization { get; set; }

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        [JsonPropertyName("taxID")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<string> TaxID { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [JsonPropertyName("telephone")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<string> Telephone { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (typically a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a statement about policy on use of unnamed sources and the decision process required.
        /// </summary>
        [JsonPropertyName("unnamedSourcesPolicy")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<ICreativeWork, Uri> UnnamedSourcesPolicy { get; set; }

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        [JsonPropertyName("vatID")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<string> VatID { get; set; }
    }
}
