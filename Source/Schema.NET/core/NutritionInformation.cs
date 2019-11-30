namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Nutritional information about the recipe.
    /// </summary>
    public partial interface INutritionInformation : IStructuredValue
    {
        /// <summary>
        /// The number of calories.
        /// </summary>
        OneOrMany<string> Calories { get; set; }

        /// <summary>
        /// The number of grams of carbohydrates.
        /// </summary>
        OneOrMany<string> CarbohydrateContent { get; set; }

        /// <summary>
        /// The number of milligrams of cholesterol.
        /// </summary>
        OneOrMany<string> CholesterolContent { get; set; }

        /// <summary>
        /// The number of grams of fat.
        /// </summary>
        OneOrMany<string> FatContent { get; set; }

        /// <summary>
        /// The number of grams of fiber.
        /// </summary>
        OneOrMany<string> FiberContent { get; set; }

        /// <summary>
        /// The number of grams of protein.
        /// </summary>
        OneOrMany<string> ProteinContent { get; set; }

        /// <summary>
        /// The number of grams of saturated fat.
        /// </summary>
        OneOrMany<string> SaturatedFatContent { get; set; }

        /// <summary>
        /// The serving size, in terms of the number of volume or mass.
        /// </summary>
        OneOrMany<string> ServingSize { get; set; }

        /// <summary>
        /// The number of milligrams of sodium.
        /// </summary>
        OneOrMany<string> SodiumContent { get; set; }

        /// <summary>
        /// The number of grams of sugar.
        /// </summary>
        OneOrMany<string> SugarContent { get; set; }

        /// <summary>
        /// The number of grams of trans fat.
        /// </summary>
        OneOrMany<string> TransFatContent { get; set; }

        /// <summary>
        /// The number of grams of unsaturated fat.
        /// </summary>
        OneOrMany<string> UnsaturatedFatContent { get; set; }
    }

    /// <summary>
    /// Nutritional information about the recipe.
    /// </summary>
    public partial class NutritionInformation : StructuredValue, INutritionInformation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "NutritionInformation";

        /// <summary>
        /// The number of calories.
        /// </summary>
        [JsonPropertyName("calories")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Calories { get; set; }

        /// <summary>
        /// The number of grams of carbohydrates.
        /// </summary>
        [JsonPropertyName("carbohydrateContent")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CarbohydrateContent { get; set; }

        /// <summary>
        /// The number of milligrams of cholesterol.
        /// </summary>
        [JsonPropertyName("cholesterolContent")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CholesterolContent { get; set; }

        /// <summary>
        /// The number of grams of fat.
        /// </summary>
        [JsonPropertyName("fatContent")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> FatContent { get; set; }

        /// <summary>
        /// The number of grams of fiber.
        /// </summary>
        [JsonPropertyName("fiberContent")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> FiberContent { get; set; }

        /// <summary>
        /// The number of grams of protein.
        /// </summary>
        [JsonPropertyName("proteinContent")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ProteinContent { get; set; }

        /// <summary>
        /// The number of grams of saturated fat.
        /// </summary>
        [JsonPropertyName("saturatedFatContent")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SaturatedFatContent { get; set; }

        /// <summary>
        /// The serving size, in terms of the number of volume or mass.
        /// </summary>
        [JsonPropertyName("servingSize")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ServingSize { get; set; }

        /// <summary>
        /// The number of milligrams of sodium.
        /// </summary>
        [JsonPropertyName("sodiumContent")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SodiumContent { get; set; }

        /// <summary>
        /// The number of grams of sugar.
        /// </summary>
        [JsonPropertyName("sugarContent")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SugarContent { get; set; }

        /// <summary>
        /// The number of grams of trans fat.
        /// </summary>
        [JsonPropertyName("transFatContent")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TransFatContent { get; set; }

        /// <summary>
        /// The number of grams of unsaturated fat.
        /// </summary>
        [JsonPropertyName("unsaturatedFatContent")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> UnsaturatedFatContent { get; set; }
    }
}
