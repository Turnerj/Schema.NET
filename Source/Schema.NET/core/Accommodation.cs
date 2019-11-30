namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An accommodation is a place that can accommodate human beings, e.g. a hotel room, a camping pitch, or a meeting room. Many accommodations are for overnight stays, but this is not a mandatory requirement.
    /// For more specific types of accommodations not defined in schema.org, one can use additionalType with external vocabularies.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// </summary>
    public partial interface IAccommodation : IPlace
    {
        /// <summary>
        /// Category of an &lt;a class="localLink" href="http://schema.org/Accommodation"&gt;Accommodation&lt;/a&gt;, following real estate conventions e.g. RESO (see &lt;a href="https://ddwiki.reso.org/display/DDW17/PropertySubType+Field"&gt;PropertySubType&lt;/a&gt;, and &lt;a href="https://ddwiki.reso.org/display/DDW17/PropertyType+Field"&gt;PropertyType&lt;/a&gt; fields  for suggested values).
        /// </summary>
        OneOrMany<string> AccommodationCategory { get; set; }

        /// <summary>
        /// The floor level for an &lt;a class="localLink" href="http://schema.org/Accommodation"&gt;Accommodation&lt;/a&gt; in a multi-storey building. Since counting
        ///   systems &lt;a href="https://en.wikipedia.org/wiki/Storey#Consecutive_number_floor_designations"&gt;vary internationally&lt;/a&gt;, the local system should be used where possible.
        /// </summary>
        OneOrMany<string> FloorLevel { get; set; }

        /// <summary>
        /// The size of the accommodation, e.g. in square meter or squarefoot.
        /// Typical unit code(s): MTK for square meter, FTK for square foot, or YDK for square yard
        /// </summary>
        OneOrMany<IQuantitativeValue> FloorSize { get; set; }

        /// <summary>
        /// Length of the lease for some &lt;a class="localLink" href="http://schema.org/Accommodation"&gt;Accommodation&lt;/a&gt;, either particular to some &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt; or in some cases intrinsic to the property.
        /// </summary>
        Values<TimeSpan?, IQuantitativeValue> LeaseLength { get; set; }

        /// <summary>
        /// The total integer number of bathrooms in a some &lt;a class="localLink" href="http://schema.org/Accommodation"&gt;Accommodation&lt;/a&gt;, following real estate conventions as &lt;a href="https://ddwiki.reso.org/display/DDW17/BathroomsTotalInteger+Field"&gt;documented in RESO&lt;/a&gt;: "The simple sum of the number of bathrooms. For example for a property with two Full Bathrooms and one Half Bathroom, the Bathrooms Total Integer will be 3.". See also &lt;a class="localLink" href="http://schema.org/numberOfRooms"&gt;numberOfRooms&lt;/a&gt;.
        /// </summary>
        OneOrMany<int?> NumberOfBathroomsTotal { get; set; }

        /// <summary>
        /// Number of full bathrooms - The total number of full and ¾ bathrooms in an &lt;a class="localLink" href="http://schema.org/Accommodation"&gt;Accommodation&lt;/a&gt;. This corresponds to the &lt;a href="https://ddwiki.reso.org/display/DDW17/BathroomsFull+Field"&gt;BathroomsFull field in RESO&lt;/a&gt;.
        /// </summary>
        OneOrMany<int?> NumberOfFullBathrooms { get; set; }

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the accommodation or lodging business.
        /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        Values<int?, IQuantitativeValue> NumberOfRooms { get; set; }

        /// <summary>
        /// Indications regarding the permitted usage of the accommodation.
        /// </summary>
        OneOrMany<string> PermittedUsage { get; set; }

        /// <summary>
        /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        Values<bool?, string> PetsAllowed { get; set; }
    }

    /// <summary>
    /// An accommodation is a place that can accommodate human beings, e.g. a hotel room, a camping pitch, or a meeting room. Many accommodations are for overnight stays, but this is not a mandatory requirement.
    /// For more specific types of accommodations not defined in schema.org, one can use additionalType with external vocabularies.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// </summary>
    public partial class Accommodation : Place, IAccommodation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Accommodation";

        /// <summary>
        /// Category of an &lt;a class="localLink" href="http://schema.org/Accommodation"&gt;Accommodation&lt;/a&gt;, following real estate conventions e.g. RESO (see &lt;a href="https://ddwiki.reso.org/display/DDW17/PropertySubType+Field"&gt;PropertySubType&lt;/a&gt;, and &lt;a href="https://ddwiki.reso.org/display/DDW17/PropertyType+Field"&gt;PropertyType&lt;/a&gt; fields  for suggested values).
        /// </summary>
        [JsonPropertyName("accommodationCategory")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AccommodationCategory { get; set; }

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        [JsonPropertyName("amenityFeature")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<ILocationFeatureSpecification> AmenityFeature { get; set; }

        /// <summary>
        /// The floor level for an &lt;a class="localLink" href="http://schema.org/Accommodation"&gt;Accommodation&lt;/a&gt; in a multi-storey building. Since counting
        ///   systems &lt;a href="https://en.wikipedia.org/wiki/Storey#Consecutive_number_floor_designations"&gt;vary internationally&lt;/a&gt;, the local system should be used where possible.
        /// </summary>
        [JsonPropertyName("floorLevel")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> FloorLevel { get; set; }

        /// <summary>
        /// The size of the accommodation, e.g. in square meter or squarefoot.
        /// Typical unit code(s): MTK for square meter, FTK for square foot, or YDK for square yard
        /// </summary>
        [JsonPropertyName("floorSize")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> FloorSize { get; set; }

        /// <summary>
        /// Length of the lease for some &lt;a class="localLink" href="http://schema.org/Accommodation"&gt;Accommodation&lt;/a&gt;, either particular to some &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt; or in some cases intrinsic to the property.
        /// </summary>
        [JsonPropertyName("leaseLength")]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public Values<TimeSpan?, IQuantitativeValue> LeaseLength { get; set; }

        /// <summary>
        /// The total integer number of bathrooms in a some &lt;a class="localLink" href="http://schema.org/Accommodation"&gt;Accommodation&lt;/a&gt;, following real estate conventions as &lt;a href="https://ddwiki.reso.org/display/DDW17/BathroomsTotalInteger+Field"&gt;documented in RESO&lt;/a&gt;: "The simple sum of the number of bathrooms. For example for a property with two Full Bathrooms and one Half Bathroom, the Bathrooms Total Integer will be 3.". See also &lt;a class="localLink" href="http://schema.org/numberOfRooms"&gt;numberOfRooms&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("numberOfBathroomsTotal")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> NumberOfBathroomsTotal { get; set; }

        /// <summary>
        /// Number of full bathrooms - The total number of full and ¾ bathrooms in an &lt;a class="localLink" href="http://schema.org/Accommodation"&gt;Accommodation&lt;/a&gt;. This corresponds to the &lt;a href="https://ddwiki.reso.org/display/DDW17/BathroomsFull+Field"&gt;BathroomsFull field in RESO&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("numberOfFullBathrooms")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> NumberOfFullBathrooms { get; set; }

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the accommodation or lodging business.
        /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        [JsonPropertyName("numberOfRooms")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<int?, IQuantitativeValue> NumberOfRooms { get; set; }

        /// <summary>
        /// Indications regarding the permitted usage of the accommodation.
        /// </summary>
        [JsonPropertyName("permittedUsage")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PermittedUsage { get; set; }

        /// <summary>
        /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        [JsonPropertyName("petsAllowed")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<bool?, string> PetsAllowed { get; set; }
    }
}
