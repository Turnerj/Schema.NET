namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A strategy of regulating the intake of food to achieve or maintain a specific health-related goal.
    /// </summary>
    public partial interface IDiet : ICreativeWorkAndLifestyleModification
    {
        /// <summary>
        /// Nutritional information specific to the dietary plan. May include dietary recommendations on what foods to avoid, what foods to consume, and specific alterations/deviations from the USDA or other regulatory body's approved dietary guidelines.
        /// </summary>
        OneOrMany<string> DietFeatures { get; set; }

        /// <summary>
        /// People or organizations that endorse the plan.
        /// </summary>
        Values<IOrganization, IPerson> Endorsers { get; set; }

        /// <summary>
        /// Medical expert advice related to the plan.
        /// </summary>
        OneOrMany<string> ExpertConsiderations { get; set; }

        /// <summary>
        /// Descriptive information establishing the overarching theory/philosophy of the plan. May include the rationale for the name, the population where the plan first came to prominence, etc.
        /// </summary>
        OneOrMany<string> Overview { get; set; }

        /// <summary>
        /// Specific physiologic benefits associated to the plan.
        /// </summary>
        OneOrMany<string> PhysiologicalBenefits { get; set; }

        /// <summary>
        /// Specific physiologic risks associated to the diet plan.
        /// </summary>
        OneOrMany<string> Risks { get; set; }
    }

    /// <summary>
    /// A strategy of regulating the intake of food to achieve or maintain a specific health-related goal.
    /// </summary>
    public partial class Diet : CreativeWorkAndLifestyleModification, IDiet
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Diet";

        /// <summary>
        /// Nutritional information specific to the dietary plan. May include dietary recommendations on what foods to avoid, what foods to consume, and specific alterations/deviations from the USDA or other regulatory body's approved dietary guidelines.
        /// </summary>
        [JsonPropertyName("dietFeatures")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> DietFeatures { get; set; }

        /// <summary>
        /// People or organizations that endorse the plan.
        /// </summary>
        [JsonPropertyName("endorsers")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Endorsers { get; set; }

        /// <summary>
        /// Medical expert advice related to the plan.
        /// </summary>
        [JsonPropertyName("expertConsiderations")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ExpertConsiderations { get; set; }

        /// <summary>
        /// Descriptive information establishing the overarching theory/philosophy of the plan. May include the rationale for the name, the population where the plan first came to prominence, etc.
        /// </summary>
        [JsonPropertyName("overview")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Overview { get; set; }

        /// <summary>
        /// Specific physiologic benefits associated to the plan.
        /// </summary>
        [JsonPropertyName("physiologicalBenefits")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PhysiologicalBenefits { get; set; }

        /// <summary>
        /// Specific physiologic risks associated to the diet plan.
        /// </summary>
        [JsonPropertyName("risks")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Risks { get; set; }
    }
}
