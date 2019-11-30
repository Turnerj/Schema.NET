namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A house is a building or structure that has the ability to be occupied for habitation by humans or other creatures (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/House"&gt;http://en.wikipedia.org/wiki/House&lt;/a&gt;).
    /// </summary>
    public partial interface IHouse : IAccommodation
    {
    }

    /// <summary>
    /// A house is a building or structure that has the ability to be occupied for habitation by humans or other creatures (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/House"&gt;http://en.wikipedia.org/wiki/House&lt;/a&gt;).
    /// </summary>
    public partial class House : Accommodation, IHouse
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "House";

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the accommodation or lodging business.
        /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        [JsonPropertyName("numberOfRooms")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<int?, IQuantitativeValue> NumberOfRooms { get; set; }
    }
}
