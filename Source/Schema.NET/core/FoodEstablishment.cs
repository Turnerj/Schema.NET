﻿namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A food-related business.
    /// </summary>
    public partial interface IFoodEstablishment : ILocalBusiness
    {
        /// <summary>
        /// Indicates whether a FoodEstablishment accepts reservations. Values can be Boolean, an URL at which reservations can be made or (for backwards compatibility) the strings &lt;code&gt;Yes&lt;/code&gt; or &lt;code&gt;No&lt;/code&gt;.
        /// </summary>
        Values<bool?, string, Uri> AcceptsReservations { get; set; }

        /// <summary>
        /// Either the actual menu as a structured representation, as text, or a URL of the menu.
        /// </summary>
        Values<IMenu, string, Uri> HasMenu { get; set; }

        /// <summary>
        /// The cuisine of the restaurant.
        /// </summary>
        OneOrMany<string> ServesCuisine { get; set; }

        /// <summary>
        /// An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).
        /// </summary>
        OneOrMany<IRating> StarRating { get; set; }
    }

    /// <summary>
    /// A food-related business.
    /// </summary>
    public partial class FoodEstablishment : LocalBusiness, IFoodEstablishment
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "FoodEstablishment";

        /// <summary>
        /// Indicates whether a FoodEstablishment accepts reservations. Values can be Boolean, an URL at which reservations can be made or (for backwards compatibility) the strings &lt;code&gt;Yes&lt;/code&gt; or &lt;code&gt;No&lt;/code&gt;.
        /// </summary>
        [JsonPropertyName("acceptsReservations")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<bool?, string, Uri> AcceptsReservations { get; set; }

        /// <summary>
        /// Either the actual menu as a structured representation, as text, or a URL of the menu.
        /// </summary>
        [JsonPropertyName("hasMenu")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMenu, string, Uri> HasMenu { get; set; }

        /// <summary>
        /// The cuisine of the restaurant.
        /// </summary>
        [JsonPropertyName("servesCuisine")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ServesCuisine { get; set; }

        /// <summary>
        /// An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).
        /// </summary>
        [JsonPropertyName("starRating")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IRating> StarRating { get; set; }
    }
}
