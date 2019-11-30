namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via &lt;a class="localLink" href="http://schema.org/suitableForDiet"&gt;suitableForDiet&lt;/a&gt;. The &lt;a class="localLink" href="http://schema.org/keywords"&gt;keywords&lt;/a&gt; property can also be used to add more detail.
    /// </summary>
    public partial interface IRecipe : IHowTo
    {
        /// <summary>
        /// The method of cooking, such as Frying, Steaming, ...
        /// </summary>
        OneOrMany<string> CookingMethod { get; set; }

        /// <summary>
        /// The time it takes to actually cook the dish, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        OneOrMany<TimeSpan?> CookTime { get; set; }

        /// <summary>
        /// Nutrition information about the recipe or menu item.
        /// </summary>
        OneOrMany<INutritionInformation> Nutrition { get; set; }

        /// <summary>
        /// The category of the recipe—for example, appetizer, entree, etc.
        /// </summary>
        OneOrMany<string> RecipeCategory { get; set; }

        /// <summary>
        /// The cuisine of the recipe (for example, French or Ethiopian).
        /// </summary>
        OneOrMany<string> RecipeCuisine { get; set; }

        /// <summary>
        /// A single ingredient used in the recipe, e.g. sugar, flour or garlic.
        /// </summary>
        OneOrMany<string> RecipeIngredient { get; set; }

        /// <summary>
        /// A step in making the recipe, in the form of a single item (document, video, etc.) or an ordered list with HowToStep and/or HowToSection items.
        /// </summary>
        Values<ICreativeWork, IItemList, string> RecipeInstructions { get; set; }

        /// <summary>
        /// The quantity produced by the recipe (for example, number of people served, number of servings, etc).
        /// </summary>
        Values<IQuantitativeValue, string> RecipeYield { get; set; }

        /// <summary>
        /// Indicates a dietary restriction or guideline for which this recipe or menu item is suitable, e.g. diabetic, halal etc.
        /// </summary>
        OneOrMany<RestrictedDiet?> SuitableForDiet { get; set; }
    }

    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via &lt;a class="localLink" href="http://schema.org/suitableForDiet"&gt;suitableForDiet&lt;/a&gt;. The &lt;a class="localLink" href="http://schema.org/keywords"&gt;keywords&lt;/a&gt; property can also be used to add more detail.
    /// </summary>
    public partial class Recipe : HowTo, IRecipe
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Recipe";

        /// <summary>
        /// The method of cooking, such as Frying, Steaming, ...
        /// </summary>
        [JsonPropertyName("cookingMethod")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CookingMethod { get; set; }

        /// <summary>
        /// The time it takes to actually cook the dish, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("cookTime")]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public OneOrMany<TimeSpan?> CookTime { get; set; }

        /// <summary>
        /// Nutrition information about the recipe or menu item.
        /// </summary>
        [JsonPropertyName("nutrition")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<INutritionInformation> Nutrition { get; set; }

        /// <summary>
        /// The category of the recipe—for example, appetizer, entree, etc.
        /// </summary>
        [JsonPropertyName("recipeCategory")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> RecipeCategory { get; set; }

        /// <summary>
        /// The cuisine of the recipe (for example, French or Ethiopian).
        /// </summary>
        [JsonPropertyName("recipeCuisine")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> RecipeCuisine { get; set; }

        /// <summary>
        /// A single ingredient used in the recipe, e.g. sugar, flour or garlic.
        /// </summary>
        [JsonPropertyName("recipeIngredient")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> RecipeIngredient { get; set; }

        /// <summary>
        /// A step in making the recipe, in the form of a single item (document, video, etc.) or an ordered list with HowToStep and/or HowToSection items.
        /// </summary>
        [JsonPropertyName("recipeInstructions")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, IItemList, string> RecipeInstructions { get; set; }

        /// <summary>
        /// The quantity produced by the recipe (for example, number of people served, number of servings, etc).
        /// </summary>
        [JsonPropertyName("recipeYield")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IQuantitativeValue, string> RecipeYield { get; set; }

        /// <summary>
        /// Indicates a dietary restriction or guideline for which this recipe or menu item is suitable, e.g. diabetic, halal etc.
        /// </summary>
        [JsonPropertyName("suitableForDiet")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<RestrictedDiet?> SuitableForDiet { get; set; }
    }
}
