namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
    public partial interface ICreativeWork : IThing
    {
        /// <summary>
        /// The subject matter of the content.
        /// </summary>
        OneOrMany<IThing> About { get; set; }

        /// <summary>
        /// An abstract is a short description that summarizes a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.
        /// </summary>
        OneOrMany<string> Abstract { get; set; }

        /// <summary>
        /// Indicates that the resource is compatible with the referenced accessibility API (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        OneOrMany<string> AccessibilityAPI { get; set; }

        /// <summary>
        /// Identifies input methods that are sufficient to fully control the described resource (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        OneOrMany<string> AccessibilityControl { get; set; }

        /// <summary>
        /// Content features of the resource, such as accessible media, alternatives and supported enhancements for accessibility (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        OneOrMany<string> AccessibilityFeature { get; set; }

        /// <summary>
        /// A characteristic of the described resource that is physiologically dangerous to some users. Related to WCAG 2.0 guideline 2.3 (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        OneOrMany<string> AccessibilityHazard { get; set; }

        /// <summary>
        /// A human-readable summary of specific accessibility features or deficiencies, consistent with the other accessibility metadata but expressing subtleties such as "short descriptions are present but long descriptions will be needed for non-visual users" or "short descriptions are present and no long descriptions are needed."
        /// </summary>
        OneOrMany<string> AccessibilitySummary { get; set; }

        /// <summary>
        /// The human sensory perceptual system or cognitive faculty through which a person may process or perceive information. Expected values include: auditory, tactile, textual, visual, colorDependent, chartOnVisual, chemOnVisual, diagramOnVisual, mathOnVisual, musicOnVisual, textOnVisual.
        /// </summary>
        OneOrMany<string> AccessMode { get; set; }

        /// <summary>
        /// A list of single or combined accessModes that are sufficient to understand all the intellectual content of a resource. Expected values include:  auditory, tactile, textual, visual.
        /// </summary>
        OneOrMany<IItemList> AccessModeSufficient { get; set; }

        /// <summary>
        /// Specifies the Person that is legally accountable for the CreativeWork.
        /// </summary>
        OneOrMany<IPerson> AccountablePerson { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        OneOrMany<IAggregateRating> AggregateRating { get; set; }

        /// <summary>
        /// A secondary title of the CreativeWork.
        /// </summary>
        OneOrMany<string> AlternativeHeadline { get; set; }

        /// <summary>
        /// A media object that encodes this CreativeWork. This property is a synonym for encoding.
        /// </summary>
        OneOrMany<IMediaObject> AssociatedMedia { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        OneOrMany<IAudience> Audience { get; set; }

        /// <summary>
        /// An embedded audio object.
        /// </summary>
        Values<IAudioObject, IClip> Audio { get; set; }

        /// <summary>
        /// The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.
        /// </summary>
        Values<IOrganization, IPerson> Author { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        OneOrMany<string> Award { get; set; }

        /// <summary>
        /// Fictional person connected with a creative work.
        /// </summary>
        OneOrMany<IPerson> Character { get; set; }

        /// <summary>
        /// A citation or reference to another creative work, such as another publication, web page, scholarly article, etc.
        /// </summary>
        Values<ICreativeWork, string> Citation { get; set; }

        /// <summary>
        /// Comments, typically from users.
        /// </summary>
        OneOrMany<IComment> Comment { get; set; }

        /// <summary>
        /// The number of comments this CreativeWork (e.g. Article, Question or Answer) has received. This is most applicable to works published in Web sites with commenting system; additional comments may exist elsewhere.
        /// </summary>
        OneOrMany<int?> CommentCount { get; set; }

        /// <summary>
        /// Conditions that affect the availability of, or method(s) of access to, an item. Typically used for real world items such as an &lt;a class="localLink" href="http://schema.org/ArchiveComponent"&gt;ArchiveComponent&lt;/a&gt; held by an &lt;a class="localLink" href="http://schema.org/ArchiveOrganization"&gt;ArchiveOrganization&lt;/a&gt;. This property is not suitable for use as a general Web access control mechanism. It is expressed only in natural language.&lt;br/&gt;&lt;br/&gt;
        /// For example "Available by appointment from the Reading Room" or "Accessible only from logged-in accounts ".
        /// </summary>
        OneOrMany<string> ConditionsOfAccess { get; set; }

        /// <summary>
        /// The location depicted or described in the content. For example, the location in a photograph or painting.
        /// </summary>
        OneOrMany<IPlace> ContentLocation { get; set; }

        /// <summary>
        /// Official rating of a piece of content&amp;#x2014;for example,'MPAA PG-13'.
        /// </summary>
        Values<IRating, string> ContentRating { get; set; }

        /// <summary>
        /// The specific time described by a creative work, for works (e.g. articles, video objects etc.) that emphasise a particular moment within an Event.
        /// </summary>
        OneOrMany<DateTimeOffset?> ContentReferenceTime { get; set; }

        /// <summary>
        /// A secondary contributor to the CreativeWork or Event.
        /// </summary>
        Values<IOrganization, IPerson> Contributor { get; set; }

        /// <summary>
        /// The party holding the legal copyright to the CreativeWork.
        /// </summary>
        Values<IOrganization, IPerson> CopyrightHolder { get; set; }

        /// <summary>
        /// The year during which the claimed copyright for the CreativeWork was first asserted.
        /// </summary>
        OneOrMany<int?> CopyrightYear { get; set; }

        /// <summary>
        /// Indicates a correction to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;, either via a &lt;a class="localLink" href="http://schema.org/CorrectionComment"&gt;CorrectionComment&lt;/a&gt;, textually or in another document.
        /// </summary>
        Values<string, Uri> Correction { get; set; }

        /// <summary>
        /// The status of a creative work in terms of its stage in a lifecycle. Example terms include Incomplete, Draft, Published, Obsolete. Some organizations define a set of terms for the stages of their publication lifecycle.
        /// </summary>
        OneOrMany<string> CreativeWorkStatus { get; set; }

        /// <summary>
        /// The creator/author of this CreativeWork. This is the same as the Author property for CreativeWork.
        /// </summary>
        Values<IOrganization, IPerson> Creator { get; set; }

        /// <summary>
        /// The date on which the CreativeWork was created or the item was added to a DataFeed.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> DateCreated { get; set; }

        /// <summary>
        /// The date on which the CreativeWork was most recently modified or when the item's entry was modified within a DataFeed.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> DateModified { get; set; }

        /// <summary>
        /// Date of first broadcast/publication.
        /// </summary>
        Values<int?, DateTime?> DatePublished { get; set; }

        /// <summary>
        /// A link to the page containing the comments of the CreativeWork.
        /// </summary>
        OneOrMany<Uri> DiscussionUrl { get; set; }

        /// <summary>
        /// Specifies the Person who edited the CreativeWork.
        /// </summary>
        OneOrMany<IPerson> Editor { get; set; }

        /// <summary>
        /// An alignment to an established educational framework.
        /// </summary>
        OneOrMany<IAlignmentObject> EducationalAlignment { get; set; }

        /// <summary>
        /// The purpose of a work in the context of education; for example, 'assignment', 'group work'.
        /// </summary>
        OneOrMany<string> EducationalUse { get; set; }

        /// <summary>
        /// A media object that encodes this CreativeWork. This property is a synonym for associatedMedia.
        /// </summary>
        OneOrMany<IMediaObject> Encoding { get; set; }

        /// <summary>
        /// Media type typically expressed using a MIME format (see &lt;a href="http://www.iana.org/assignments/media-types/media-types.xhtml"&gt;IANA site&lt;/a&gt; and &lt;a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types"&gt;MDN reference&lt;/a&gt;) e.g. application/zip for a SoftwareApplication binary, audio/mpeg for .mp3 etc.).&lt;br/&gt;&lt;br/&gt;
        /// In cases where a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; has several media type representations, &lt;a class="localLink" href="http://schema.org/encoding"&gt;encoding&lt;/a&gt; can be used to indicate each &lt;a class="localLink" href="http://schema.org/MediaObject"&gt;MediaObject&lt;/a&gt; alongside particular &lt;a class="localLink" href="http://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt; information.&lt;br/&gt;&lt;br/&gt;
        /// Unregistered or niche encoding and file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia/Wikidata entry.
        /// </summary>
        Values<string, Uri> EncodingFormat { get; set; }

        /// <summary>
        /// A creative work that this work is an example/instance/realization/derivation of.
        /// </summary>
        OneOrMany<ICreativeWork> ExampleOfWork { get; set; }

        /// <summary>
        /// Date the content expires and is no longer useful or available. For example a &lt;a class="localLink" href="http://schema.org/VideoObject"&gt;VideoObject&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt; whose availability or relevance is time-limited, or a &lt;a class="localLink" href="http://schema.org/ClaimReview"&gt;ClaimReview&lt;/a&gt; fact check whose publisher wants to indicate that it may no longer be relevant (or helpful to highlight) after some date.
        /// </summary>
        Values<int?, DateTime?> Expires { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        Values<IOrganization, IPerson> Funder { get; set; }

        /// <summary>
        /// Genre of the creative work, broadcast channel or group.
        /// </summary>
        Values<string, Uri> Genre { get; set; }

        /// <summary>
        /// Indicates an item or CreativeWork that is part of this item, or CreativeWork (in some sense).
        /// </summary>
        OneOrMany<ICreativeWork> HasPart { get; set; }

        /// <summary>
        /// Headline of the article.
        /// </summary>
        OneOrMany<string> Headline { get; set; }

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        Values<ILanguage, string> InLanguage { get; set; }

        /// <summary>
        /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication. The most specific child type of InteractionCounter should be used.
        /// </summary>
        OneOrMany<IInteractionCounter> InteractionStatistic { get; set; }

        /// <summary>
        /// The predominant mode of learning supported by the learning resource. Acceptable values are 'active', 'expositive', or 'mixed'.
        /// </summary>
        OneOrMany<string> InteractivityType { get; set; }

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        OneOrMany<bool?> IsAccessibleForFree { get; set; }

        /// <summary>
        /// A resource from which this work is derived or from which it is a modification or adaption.
        /// </summary>
        Values<ICreativeWork, IProduct, Uri> IsBasedOn { get; set; }

        /// <summary>
        /// Indicates whether this content is family friendly.
        /// </summary>
        OneOrMany<bool?> IsFamilyFriendly { get; set; }

        /// <summary>
        /// Indicates an item or CreativeWork that this item, or CreativeWork (in some sense), is part of.
        /// </summary>
        OneOrMany<ICreativeWork> IsPartOf { get; set; }

        /// <summary>
        /// Keywords or tags used to describe this content. Multiple entries in a keywords list are typically delimited by commas.
        /// </summary>
        OneOrMany<string> Keywords { get; set; }

        /// <summary>
        /// The predominant type or kind characterizing the learning resource. For example, 'presentation', 'handout'.
        /// </summary>
        OneOrMany<string> LearningResourceType { get; set; }

        /// <summary>
        /// A license document that applies to this content, typically indicated by URL.
        /// </summary>
        Values<ICreativeWork, Uri> License { get; set; }

        /// <summary>
        /// The location where the CreativeWork was created, which may not be the same as the location depicted in the CreativeWork.
        /// </summary>
        OneOrMany<IPlace> LocationCreated { get; set; }

        /// <summary>
        /// Indicates the primary entity described in some page or other CreativeWork.
        /// </summary>
        OneOrMany<IThing> MainEntity { get; set; }

        /// <summary>
        /// A material that something is made from, e.g. leather, wool, cotton, paper.
        /// </summary>
        Values<IProduct, string, Uri> Material { get; set; }

        /// <summary>
        /// The quantity of the materials being described or an expression of the physical space they occupy.
        /// </summary>
        Values<IQuantitativeValue, string> MaterialExtent { get; set; }

        /// <summary>
        /// Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.
        /// </summary>
        OneOrMany<IThing> Mentions { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        OneOrMany<IOffer> Offers { get; set; }

        /// <summary>
        /// The position of an item in a series or sequence of items.
        /// </summary>
        Values<int?, string> Position { get; set; }

        /// <summary>
        /// The person or organization who produced the work (e.g. music album, movie, tv/radio series etc.).
        /// </summary>
        Values<IOrganization, IPerson> Producer { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        Values<IOrganization, IPerson> Provider { get; set; }

        /// <summary>
        /// A publication event associated with the item.
        /// </summary>
        OneOrMany<IPublicationEvent> Publication { get; set; }

        /// <summary>
        /// The publisher of the creative work.
        /// </summary>
        Values<IOrganization, IPerson> Publisher { get; set; }

        /// <summary>
        /// The publishing division which published the comic.
        /// </summary>
        OneOrMany<IOrganization> PublisherImprint { get; set; }

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        Values<ICreativeWork, Uri> PublishingPrinciples { get; set; }

        /// <summary>
        /// The Event where the CreativeWork was recorded. The CreativeWork may capture all or part of the event.
        /// </summary>
        OneOrMany<IEvent> RecordedAt { get; set; }

        /// <summary>
        /// The place and time the release was issued, expressed as a PublicationEvent.
        /// </summary>
        OneOrMany<IPublicationEvent> ReleasedEvent { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        OneOrMany<IReview> Review { get; set; }

        /// <summary>
        /// Indicates (by URL or string) a particular version of a schema used in some CreativeWork. For example, a document could declare a schemaVersion using an URL such as http://schema.org/version/2.0/ if precise indication of schema version was required by some application.
        /// </summary>
        Values<string, Uri> SchemaVersion { get; set; }

        /// <summary>
        /// Indicates the date on which the current structured data was generated / published. Typically used alongside &lt;a class="localLink" href="http://schema.org/sdPublisher"&gt;sdPublisher&lt;/a&gt;
        /// </summary>
        Values<int?, DateTime?> SdDatePublished { get; set; }

        /// <summary>
        /// A license document that applies to this structured data, typically indicated by URL.
        /// </summary>
        Values<ICreativeWork, Uri> SdLicense { get; set; }

        /// <summary>
        /// Indicates the party responsible for generating and publishing the current structured data markup, typically in cases where the structured data is derived automatically from existing published content but published on a different site. For example, student projects and open data initiatives often re-publish existing content with more explicitly structured metadata. The
        /// &lt;a class="localLink" href="http://schema.org/sdPublisher"&gt;sdPublisher&lt;/a&gt; property helps make such practices more explicit.
        /// </summary>
        Values<IOrganization, IPerson> SdPublisher { get; set; }

        /// <summary>
        /// The Organization on whose behalf the creator was working.
        /// </summary>
        OneOrMany<IOrganization> SourceOrganization { get; set; }

        /// <summary>
        /// The "spatial" property can be used in cases when more specific properties
        /// (e.g. &lt;a class="localLink" href="http://schema.org/locationCreated"&gt;locationCreated&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/spatialCoverage"&gt;spatialCoverage&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/contentLocation"&gt;contentLocation&lt;/a&gt;) are not known to be appropriate.
        /// </summary>
        OneOrMany<IPlace> Spatial { get; set; }

        /// <summary>
        /// The spatialCoverage of a CreativeWork indicates the place(s) which are the focus of the content. It is a subproperty of
        ///       contentLocation intended primarily for more technical and detailed materials. For example with a Dataset, it indicates
        ///       areas that the dataset describes: a dataset of New York weather would have spatialCoverage which was the place: the state of New York.
        /// </summary>
        OneOrMany<IPlace> SpatialCoverage { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        Values<IOrganization, IPerson> Sponsor { get; set; }

        /// <summary>
        /// The "temporal" property can be used in cases where more specific properties
        /// (e.g. &lt;a class="localLink" href="http://schema.org/temporalCoverage"&gt;temporalCoverage&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/dateCreated"&gt;dateCreated&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/dateModified"&gt;dateModified&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/datePublished"&gt;datePublished&lt;/a&gt;) are not known to be appropriate.
        /// </summary>
        Values<DateTimeOffset?, string> Temporal { get; set; }

        /// <summary>
        /// The temporalCoverage of a CreativeWork indicates the period that the content applies to, i.e. that it describes, either as a DateTime or as a textual string indicating a time period in &lt;a href="https://en.wikipedia.org/wiki/ISO_8601#Time_intervals"&gt;ISO 8601 time interval format&lt;/a&gt;. In
        ///       the case of a Dataset it will typically indicate the relevant time period in a precise notation (e.g. for a 2011 census dataset, the year 2011 would be written "2011/2012"). Other forms of content e.g. ScholarlyArticle, Book, TVSeries or TVEpisode may indicate their temporalCoverage in broader terms - textually or via well-known URL.
        ///       Written works such as books may sometimes have precise temporal coverage too, e.g. a work set in 1939 - 1945 can be indicated in ISO 8601 interval format format via "1939/1945".&lt;br/&gt;&lt;br/&gt;
        /// Open-ended date ranges can be written with ".." in place of the end date. For example, "2015-11/.." indicates a range beginning in November 2015 and with no specified final date. This is tentative and might be updated in future when ISO 8601 is officially updated.
        /// </summary>
        Values<DateTimeOffset?, string, Uri> TemporalCoverage { get; set; }

        /// <summary>
        /// The textual content of this CreativeWork.
        /// </summary>
        OneOrMany<string> Text { get; set; }

        /// <summary>
        /// A thumbnail image relevant to the Thing.
        /// </summary>
        OneOrMany<Uri> ThumbnailUrl { get; set; }

        /// <summary>
        /// Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience, e.g. 'PT30M', 'PT1H25M'.
        /// </summary>
        OneOrMany<TimeSpan?> TimeRequired { get; set; }

        /// <summary>
        /// The work that this work has been translated from. e.g. 物种起源 is a translationOf “On the Origin of Species”
        /// </summary>
        OneOrMany<ICreativeWork> TranslationOfWork { get; set; }

        /// <summary>
        /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
        /// </summary>
        Values<IOrganization, IPerson> Translator { get; set; }

        /// <summary>
        /// The typical expected age range, e.g. '7-9', '11-'.
        /// </summary>
        OneOrMany<string> TypicalAgeRange { get; set; }

        /// <summary>
        /// The version of the CreativeWork embodied by a specified resource.
        /// </summary>
        Values<double?, string> Version { get; set; }

        /// <summary>
        /// An embedded video object.
        /// </summary>
        Values<IClip, IVideoObject> Video { get; set; }

        /// <summary>
        /// Example/instance/realization/derivation of the concept of this creative work. eg. The paperback edition, first edition, or eBook.
        /// </summary>
        OneOrMany<ICreativeWork> WorkExample { get; set; }

        /// <summary>
        /// A work that is a translation of the content of this work. e.g. 西遊記 has an English workTranslation “Journey to the West”,a German workTranslation “Monkeys Pilgerfahrt” and a Vietnamese  translation Tây du ký bình khảo.
        /// </summary>
        OneOrMany<ICreativeWork> WorkTranslation { get; set; }
    }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
    public partial class CreativeWork : Thing, ICreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "CreativeWork";

        /// <summary>
        /// The subject matter of the content.
        /// </summary>
        [JsonPropertyName("about")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> About { get; set; }

        /// <summary>
        /// An abstract is a short description that summarizes a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("abstract")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Abstract { get; set; }

        /// <summary>
        /// Indicates that the resource is compatible with the referenced accessibility API (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [JsonPropertyName("accessibilityAPI")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AccessibilityAPI { get; set; }

        /// <summary>
        /// Identifies input methods that are sufficient to fully control the described resource (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [JsonPropertyName("accessibilityControl")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AccessibilityControl { get; set; }

        /// <summary>
        /// Content features of the resource, such as accessible media, alternatives and supported enhancements for accessibility (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [JsonPropertyName("accessibilityFeature")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AccessibilityFeature { get; set; }

        /// <summary>
        /// A characteristic of the described resource that is physiologically dangerous to some users. Related to WCAG 2.0 guideline 2.3 (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [JsonPropertyName("accessibilityHazard")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AccessibilityHazard { get; set; }

        /// <summary>
        /// A human-readable summary of specific accessibility features or deficiencies, consistent with the other accessibility metadata but expressing subtleties such as "short descriptions are present but long descriptions will be needed for non-visual users" or "short descriptions are present and no long descriptions are needed."
        /// </summary>
        [JsonPropertyName("accessibilitySummary")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AccessibilitySummary { get; set; }

        /// <summary>
        /// The human sensory perceptual system or cognitive faculty through which a person may process or perceive information. Expected values include: auditory, tactile, textual, visual, colorDependent, chartOnVisual, chemOnVisual, diagramOnVisual, mathOnVisual, musicOnVisual, textOnVisual.
        /// </summary>
        [JsonPropertyName("accessMode")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AccessMode { get; set; }

        /// <summary>
        /// A list of single or combined accessModes that are sufficient to understand all the intellectual content of a resource. Expected values include:  auditory, tactile, textual, visual.
        /// </summary>
        [JsonPropertyName("accessModeSufficient")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IItemList> AccessModeSufficient { get; set; }

        /// <summary>
        /// Specifies the Person that is legally accountable for the CreativeWork.
        /// </summary>
        [JsonPropertyName("accountablePerson")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> AccountablePerson { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [JsonPropertyName("aggregateRating")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAggregateRating> AggregateRating { get; set; }

        /// <summary>
        /// A secondary title of the CreativeWork.
        /// </summary>
        [JsonPropertyName("alternativeHeadline")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AlternativeHeadline { get; set; }

        /// <summary>
        /// A media object that encodes this CreativeWork. This property is a synonym for encoding.
        /// </summary>
        [JsonPropertyName("associatedMedia")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMediaObject> AssociatedMedia { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [JsonPropertyName("audience")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAudience> Audience { get; set; }

        /// <summary>
        /// An embedded audio object.
        /// </summary>
        [JsonPropertyName("audio")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAudioObject, IClip> Audio { get; set; }

        /// <summary>
        /// The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.
        /// </summary>
        [JsonPropertyName("author")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Author { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [JsonPropertyName("award")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Award { get; set; }

        /// <summary>
        /// Fictional person connected with a creative work.
        /// </summary>
        [JsonPropertyName("character")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Character { get; set; }

        /// <summary>
        /// A citation or reference to another creative work, such as another publication, web page, scholarly article, etc.
        /// </summary>
        [JsonPropertyName("citation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, string> Citation { get; set; }

        /// <summary>
        /// Comments, typically from users.
        /// </summary>
        [JsonPropertyName("comment")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IComment> Comment { get; set; }

        /// <summary>
        /// The number of comments this CreativeWork (e.g. Article, Question or Answer) has received. This is most applicable to works published in Web sites with commenting system; additional comments may exist elsewhere.
        /// </summary>
        [JsonPropertyName("commentCount")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> CommentCount { get; set; }

        /// <summary>
        /// Conditions that affect the availability of, or method(s) of access to, an item. Typically used for real world items such as an &lt;a class="localLink" href="http://schema.org/ArchiveComponent"&gt;ArchiveComponent&lt;/a&gt; held by an &lt;a class="localLink" href="http://schema.org/ArchiveOrganization"&gt;ArchiveOrganization&lt;/a&gt;. This property is not suitable for use as a general Web access control mechanism. It is expressed only in natural language.&lt;br/&gt;&lt;br/&gt;
        /// For example "Available by appointment from the Reading Room" or "Accessible only from logged-in accounts ".
        /// </summary>
        [JsonPropertyName("conditionsOfAccess")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ConditionsOfAccess { get; set; }

        /// <summary>
        /// The location depicted or described in the content. For example, the location in a photograph or painting.
        /// </summary>
        [JsonPropertyName("contentLocation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> ContentLocation { get; set; }

        /// <summary>
        /// Official rating of a piece of content&amp;#x2014;for example,'MPAA PG-13'.
        /// </summary>
        [JsonPropertyName("contentRating")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IRating, string> ContentRating { get; set; }

        /// <summary>
        /// The specific time described by a creative work, for works (e.g. articles, video objects etc.) that emphasise a particular moment within an Event.
        /// </summary>
        [JsonPropertyName("contentReferenceTime")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> ContentReferenceTime { get; set; }

        /// <summary>
        /// A secondary contributor to the CreativeWork or Event.
        /// </summary>
        [JsonPropertyName("contributor")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Contributor { get; set; }

        /// <summary>
        /// The party holding the legal copyright to the CreativeWork.
        /// </summary>
        [JsonPropertyName("copyrightHolder")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> CopyrightHolder { get; set; }

        /// <summary>
        /// The year during which the claimed copyright for the CreativeWork was first asserted.
        /// </summary>
        [JsonPropertyName("copyrightYear")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> CopyrightYear { get; set; }

        /// <summary>
        /// Indicates a correction to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;, either via a &lt;a class="localLink" href="http://schema.org/CorrectionComment"&gt;CorrectionComment&lt;/a&gt;, textually or in another document.
        /// </summary>
        [JsonPropertyName("correction")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> Correction { get; set; }

        /// <summary>
        /// The status of a creative work in terms of its stage in a lifecycle. Example terms include Incomplete, Draft, Published, Obsolete. Some organizations define a set of terms for the stages of their publication lifecycle.
        /// </summary>
        [JsonPropertyName("creativeWorkStatus")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CreativeWorkStatus { get; set; }

        /// <summary>
        /// The creator/author of this CreativeWork. This is the same as the Author property for CreativeWork.
        /// </summary>
        [JsonPropertyName("creator")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Creator { get; set; }

        /// <summary>
        /// The date on which the CreativeWork was created or the item was added to a DataFeed.
        /// </summary>
        [JsonPropertyName("dateCreated")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> DateCreated { get; set; }

        /// <summary>
        /// The date on which the CreativeWork was most recently modified or when the item's entry was modified within a DataFeed.
        /// </summary>
        [JsonPropertyName("dateModified")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> DateModified { get; set; }

        /// <summary>
        /// Date of first broadcast/publication.
        /// </summary>
        [JsonPropertyName("datePublished")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> DatePublished { get; set; }

        /// <summary>
        /// A link to the page containing the comments of the CreativeWork.
        /// </summary>
        [JsonPropertyName("discussionUrl")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> DiscussionUrl { get; set; }

        /// <summary>
        /// Specifies the Person who edited the CreativeWork.
        /// </summary>
        [JsonPropertyName("editor")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Editor { get; set; }

        /// <summary>
        /// An alignment to an established educational framework.
        /// </summary>
        [JsonPropertyName("educationalAlignment")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAlignmentObject> EducationalAlignment { get; set; }

        /// <summary>
        /// The purpose of a work in the context of education; for example, 'assignment', 'group work'.
        /// </summary>
        [JsonPropertyName("educationalUse")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> EducationalUse { get; set; }

        /// <summary>
        /// A media object that encodes this CreativeWork. This property is a synonym for associatedMedia.
        /// </summary>
        [JsonPropertyName("encoding")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMediaObject> Encoding { get; set; }

        /// <summary>
        /// Media type typically expressed using a MIME format (see &lt;a href="http://www.iana.org/assignments/media-types/media-types.xhtml"&gt;IANA site&lt;/a&gt; and &lt;a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types"&gt;MDN reference&lt;/a&gt;) e.g. application/zip for a SoftwareApplication binary, audio/mpeg for .mp3 etc.).&lt;br/&gt;&lt;br/&gt;
        /// In cases where a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; has several media type representations, &lt;a class="localLink" href="http://schema.org/encoding"&gt;encoding&lt;/a&gt; can be used to indicate each &lt;a class="localLink" href="http://schema.org/MediaObject"&gt;MediaObject&lt;/a&gt; alongside particular &lt;a class="localLink" href="http://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt; information.&lt;br/&gt;&lt;br/&gt;
        /// Unregistered or niche encoding and file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia/Wikidata entry.
        /// </summary>
        [JsonPropertyName("encodingFormat")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<string, Uri> EncodingFormat { get; set; }

        /// <summary>
        /// A creative work that this work is an example/instance/realization/derivation of.
        /// </summary>
        [JsonPropertyName("exampleOfWork")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> ExampleOfWork { get; set; }

        /// <summary>
        /// Date the content expires and is no longer useful or available. For example a &lt;a class="localLink" href="http://schema.org/VideoObject"&gt;VideoObject&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt; whose availability or relevance is time-limited, or a &lt;a class="localLink" href="http://schema.org/ClaimReview"&gt;ClaimReview&lt;/a&gt; fact check whose publisher wants to indicate that it may no longer be relevant (or helpful to highlight) after some date.
        /// </summary>
        [JsonPropertyName("expires")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> Expires { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [JsonPropertyName("funder")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Funder { get; set; }

        /// <summary>
        /// Genre of the creative work, broadcast channel or group.
        /// </summary>
        [JsonPropertyName("genre")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> Genre { get; set; }

        /// <summary>
        /// Indicates an item or CreativeWork that is part of this item, or CreativeWork (in some sense).
        /// </summary>
        [JsonPropertyName("hasPart")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> HasPart { get; set; }

        /// <summary>
        /// Headline of the article.
        /// </summary>
        [JsonPropertyName("headline")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Headline { get; set; }

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("inLanguage")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ILanguage, string> InLanguage { get; set; }

        /// <summary>
        /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication. The most specific child type of InteractionCounter should be used.
        /// </summary>
        [JsonPropertyName("interactionStatistic")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IInteractionCounter> InteractionStatistic { get; set; }

        /// <summary>
        /// The predominant mode of learning supported by the learning resource. Acceptable values are 'active', 'expositive', or 'mixed'.
        /// </summary>
        [JsonPropertyName("interactivityType")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> InteractivityType { get; set; }

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        [JsonPropertyName("isAccessibleForFree")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> IsAccessibleForFree { get; set; }

        /// <summary>
        /// A resource from which this work is derived or from which it is a modification or adaption.
        /// </summary>
        [JsonPropertyName("isBasedOn")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, IProduct, Uri> IsBasedOn { get; set; }

        /// <summary>
        /// Indicates whether this content is family friendly.
        /// </summary>
        [JsonPropertyName("isFamilyFriendly")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> IsFamilyFriendly { get; set; }

        /// <summary>
        /// Indicates an item or CreativeWork that this item, or CreativeWork (in some sense), is part of.
        /// </summary>
        [JsonPropertyName("isPartOf")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> IsPartOf { get; set; }

        /// <summary>
        /// Keywords or tags used to describe this content. Multiple entries in a keywords list are typically delimited by commas.
        /// </summary>
        [JsonPropertyName("keywords")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Keywords { get; set; }

        /// <summary>
        /// The predominant type or kind characterizing the learning resource. For example, 'presentation', 'handout'.
        /// </summary>
        [JsonPropertyName("learningResourceType")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> LearningResourceType { get; set; }

        /// <summary>
        /// A license document that applies to this content, typically indicated by URL.
        /// </summary>
        [JsonPropertyName("license")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, Uri> License { get; set; }

        /// <summary>
        /// The location where the CreativeWork was created, which may not be the same as the location depicted in the CreativeWork.
        /// </summary>
        [JsonPropertyName("locationCreated")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> LocationCreated { get; set; }

        /// <summary>
        /// Indicates the primary entity described in some page or other CreativeWork.
        /// </summary>
        [JsonPropertyName("mainEntity")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> MainEntity { get; set; }

        /// <summary>
        /// A material that something is made from, e.g. leather, wool, cotton, paper.
        /// </summary>
        [JsonPropertyName("material")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IProduct, string, Uri> Material { get; set; }

        /// <summary>
        /// The quantity of the materials being described or an expression of the physical space they occupy.
        /// </summary>
        [JsonPropertyName("materialExtent")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IQuantitativeValue, string> MaterialExtent { get; set; }

        /// <summary>
        /// Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.
        /// </summary>
        [JsonPropertyName("mentions")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> Mentions { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [JsonPropertyName("offers")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOffer> Offers { get; set; }

        /// <summary>
        /// The position of an item in a series or sequence of items.
        /// </summary>
        [JsonPropertyName("position")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, string> Position { get; set; }

        /// <summary>
        /// The person or organization who produced the work (e.g. music album, movie, tv/radio series etc.).
        /// </summary>
        [JsonPropertyName("producer")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Producer { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [JsonPropertyName("provider")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Provider { get; set; }

        /// <summary>
        /// A publication event associated with the item.
        /// </summary>
        [JsonPropertyName("publication")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPublicationEvent> Publication { get; set; }

        /// <summary>
        /// The publisher of the creative work.
        /// </summary>
        [JsonPropertyName("publisher")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Publisher { get; set; }

        /// <summary>
        /// The publishing division which published the comic.
        /// </summary>
        [JsonPropertyName("publisherImprint")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> PublisherImprint { get; set; }

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        [JsonPropertyName("publishingPrinciples")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, Uri> PublishingPrinciples { get; set; }

        /// <summary>
        /// The Event where the CreativeWork was recorded. The CreativeWork may capture all or part of the event.
        /// </summary>
        [JsonPropertyName("recordedAt")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEvent> RecordedAt { get; set; }

        /// <summary>
        /// The place and time the release was issued, expressed as a PublicationEvent.
        /// </summary>
        [JsonPropertyName("releasedEvent")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPublicationEvent> ReleasedEvent { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [JsonPropertyName("review")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IReview> Review { get; set; }

        /// <summary>
        /// Indicates (by URL or string) a particular version of a schema used in some CreativeWork. For example, a document could declare a schemaVersion using an URL such as http://schema.org/version/2.0/ if precise indication of schema version was required by some application.
        /// </summary>
        [JsonPropertyName("schemaVersion")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> SchemaVersion { get; set; }

        /// <summary>
        /// Indicates the date on which the current structured data was generated / published. Typically used alongside &lt;a class="localLink" href="http://schema.org/sdPublisher"&gt;sdPublisher&lt;/a&gt;
        /// </summary>
        [JsonPropertyName("sdDatePublished")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> SdDatePublished { get; set; }

        /// <summary>
        /// A license document that applies to this structured data, typically indicated by URL.
        /// </summary>
        [JsonPropertyName("sdLicense")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, Uri> SdLicense { get; set; }

        /// <summary>
        /// Indicates the party responsible for generating and publishing the current structured data markup, typically in cases where the structured data is derived automatically from existing published content but published on a different site. For example, student projects and open data initiatives often re-publish existing content with more explicitly structured metadata. The
        /// &lt;a class="localLink" href="http://schema.org/sdPublisher"&gt;sdPublisher&lt;/a&gt; property helps make such practices more explicit.
        /// </summary>
        [JsonPropertyName("sdPublisher")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> SdPublisher { get; set; }

        /// <summary>
        /// The Organization on whose behalf the creator was working.
        /// </summary>
        [JsonPropertyName("sourceOrganization")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> SourceOrganization { get; set; }

        /// <summary>
        /// The "spatial" property can be used in cases when more specific properties
        /// (e.g. &lt;a class="localLink" href="http://schema.org/locationCreated"&gt;locationCreated&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/spatialCoverage"&gt;spatialCoverage&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/contentLocation"&gt;contentLocation&lt;/a&gt;) are not known to be appropriate.
        /// </summary>
        [JsonPropertyName("spatial")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> Spatial { get; set; }

        /// <summary>
        /// The spatialCoverage of a CreativeWork indicates the place(s) which are the focus of the content. It is a subproperty of
        ///       contentLocation intended primarily for more technical and detailed materials. For example with a Dataset, it indicates
        ///       areas that the dataset describes: a dataset of New York weather would have spatialCoverage which was the place: the state of New York.
        /// </summary>
        [JsonPropertyName("spatialCoverage")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> SpatialCoverage { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [JsonPropertyName("sponsor")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Sponsor { get; set; }

        /// <summary>
        /// The "temporal" property can be used in cases where more specific properties
        /// (e.g. &lt;a class="localLink" href="http://schema.org/temporalCoverage"&gt;temporalCoverage&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/dateCreated"&gt;dateCreated&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/dateModified"&gt;dateModified&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/datePublished"&gt;datePublished&lt;/a&gt;) are not known to be appropriate.
        /// </summary>
        [JsonPropertyName("temporal")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<DateTimeOffset?, string> Temporal { get; set; }

        /// <summary>
        /// The temporalCoverage of a CreativeWork indicates the period that the content applies to, i.e. that it describes, either as a DateTime or as a textual string indicating a time period in &lt;a href="https://en.wikipedia.org/wiki/ISO_8601#Time_intervals"&gt;ISO 8601 time interval format&lt;/a&gt;. In
        ///       the case of a Dataset it will typically indicate the relevant time period in a precise notation (e.g. for a 2011 census dataset, the year 2011 would be written "2011/2012"). Other forms of content e.g. ScholarlyArticle, Book, TVSeries or TVEpisode may indicate their temporalCoverage in broader terms - textually or via well-known URL.
        ///       Written works such as books may sometimes have precise temporal coverage too, e.g. a work set in 1939 - 1945 can be indicated in ISO 8601 interval format format via "1939/1945".&lt;br/&gt;&lt;br/&gt;
        /// Open-ended date ranges can be written with ".." in place of the end date. For example, "2015-11/.." indicates a range beginning in November 2015 and with no specified final date. This is tentative and might be updated in future when ISO 8601 is officially updated.
        /// </summary>
        [JsonPropertyName("temporalCoverage")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<DateTimeOffset?, string, Uri> TemporalCoverage { get; set; }

        /// <summary>
        /// The textual content of this CreativeWork.
        /// </summary>
        [JsonPropertyName("text")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Text { get; set; }

        /// <summary>
        /// A thumbnail image relevant to the Thing.
        /// </summary>
        [JsonPropertyName("thumbnailUrl")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> ThumbnailUrl { get; set; }

        /// <summary>
        /// Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience, e.g. 'PT30M', 'PT1H25M'.
        /// </summary>
        [JsonPropertyName("timeRequired")]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public OneOrMany<TimeSpan?> TimeRequired { get; set; }

        /// <summary>
        /// The work that this work has been translated from. e.g. 物种起源 is a translationOf “On the Origin of Species”
        /// </summary>
        [JsonPropertyName("translationOfWork")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> TranslationOfWork { get; set; }

        /// <summary>
        /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
        /// </summary>
        [JsonPropertyName("translator")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Translator { get; set; }

        /// <summary>
        /// The typical expected age range, e.g. '7-9', '11-'.
        /// </summary>
        [JsonPropertyName("typicalAgeRange")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TypicalAgeRange { get; set; }

        /// <summary>
        /// The version of the CreativeWork embodied by a specified resource.
        /// </summary>
        [JsonPropertyName("version")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, string> Version { get; set; }

        /// <summary>
        /// An embedded video object.
        /// </summary>
        [JsonPropertyName("video")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IClip, IVideoObject> Video { get; set; }

        /// <summary>
        /// Example/instance/realization/derivation of the concept of this creative work. eg. The paperback edition, first edition, or eBook.
        /// </summary>
        [JsonPropertyName("workExample")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> WorkExample { get; set; }

        /// <summary>
        /// A work that is a translation of the content of this work. e.g. 西遊記 has an English workTranslation “Journey to the West”,a German workTranslation “Monkeys Pilgerfahrt” and a Vietnamese  translation Tây du ký bình khảo.
        /// </summary>
        [JsonPropertyName("workTranslation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> WorkTranslation { get; set; }
    }
}
