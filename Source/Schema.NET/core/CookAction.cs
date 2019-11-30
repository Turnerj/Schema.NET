namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of producing/preparing food.
    /// </summary>
    public partial interface ICookAction : ICreateAction
    {
        /// <summary>
        /// A sub property of location. The specific food establishment where the action occurred.
        /// </summary>
        Values<IFoodEstablishment, IPlace> FoodEstablishment { get; set; }

        /// <summary>
        /// A sub property of location. The specific food event where the action occurred.
        /// </summary>
        OneOrMany<IFoodEvent> FoodEvent { get; set; }

        /// <summary>
        /// A sub property of instrument. The recipe/instructions used to perform the action.
        /// </summary>
        OneOrMany<IRecipe> Recipe { get; set; }
    }

    /// <summary>
    /// The act of producing/preparing food.
    /// </summary>
    public partial class CookAction : CreateAction, ICookAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "CookAction";

        /// <summary>
        /// A sub property of location. The specific food establishment where the action occurred.
        /// </summary>
        [JsonPropertyName("foodEstablishment")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IFoodEstablishment, IPlace> FoodEstablishment { get; set; }

        /// <summary>
        /// A sub property of location. The specific food event where the action occurred.
        /// </summary>
        [JsonPropertyName("foodEvent")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IFoodEvent> FoodEvent { get; set; }

        /// <summary>
        /// A sub property of instrument. The recipe/instructions used to perform the action.
        /// </summary>
        [JsonPropertyName("recipe")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IRecipe> Recipe { get; set; }
    }
}
