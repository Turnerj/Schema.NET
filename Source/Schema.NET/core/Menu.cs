namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A structured representation of food or drink items available from a FoodEstablishment.
    /// </summary>
    public partial interface IMenu : ICreativeWork
    {
        /// <summary>
        /// A food or drink item contained in a menu or menu section.
        /// </summary>
        OneOrMany<IMenuItem> HasMenuItem { get; set; }

        /// <summary>
        /// A subgrouping of the menu (by dishes, course, serving time period, etc.).
        /// </summary>
        OneOrMany<IMenuSection> HasMenuSection { get; set; }
    }

    /// <summary>
    /// A structured representation of food or drink items available from a FoodEstablishment.
    /// </summary>
    public partial class Menu : CreativeWork, IMenu
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Menu";

        /// <summary>
        /// A food or drink item contained in a menu or menu section.
        /// </summary>
        [JsonPropertyName("hasMenuItem")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMenuItem> HasMenuItem { get; set; }

        /// <summary>
        /// A subgrouping of the menu (by dishes, course, serving time period, etc.).
        /// </summary>
        [JsonPropertyName("hasMenuSection")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMenuSection> HasMenuSection { get; set; }
    }
}
