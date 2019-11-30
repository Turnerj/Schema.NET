namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Any bodily activity that enhances or maintains physical fitness and overall health and wellness. Includes activity that is part of daily living and routine, structured exercise, and exercise prescribed as part of a medical treatment or recovery plan.
    /// </summary>
    public partial interface IPhysicalActivity : ILifestyleModification
    {
        /// <summary>
        /// The anatomy of the underlying organ system or structures associated with this entity.
        /// </summary>
        Values<IAnatomicalStructure, IAnatomicalSystem, ISuperficialAnatomy> AssociatedAnatomy { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        Values<PhysicalActivityCategory?, string, IThing> Category { get; set; }

        /// <summary>
        /// The characteristics of associated patients, such as age, gender, race etc.
        /// </summary>
        OneOrMany<string> Epidemiology { get; set; }

        /// <summary>
        /// Changes in the normal mechanical, physical, and biochemical functions that are associated with this activity or condition.
        /// </summary>
        OneOrMany<string> Pathophysiology { get; set; }
    }

    /// <summary>
    /// Any bodily activity that enhances or maintains physical fitness and overall health and wellness. Includes activity that is part of daily living and routine, structured exercise, and exercise prescribed as part of a medical treatment or recovery plan.
    /// </summary>
    public partial class PhysicalActivity : LifestyleModification, IPhysicalActivity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PhysicalActivity";

        /// <summary>
        /// The anatomy of the underlying organ system or structures associated with this entity.
        /// </summary>
        [JsonPropertyName("associatedAnatomy")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAnatomicalStructure, IAnatomicalSystem, ISuperficialAnatomy> AssociatedAnatomy { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [JsonPropertyName("category")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<PhysicalActivityCategory?, string, IThing> Category { get; set; }

        /// <summary>
        /// The characteristics of associated patients, such as age, gender, race etc.
        /// </summary>
        [JsonPropertyName("epidemiology")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Epidemiology { get; set; }

        /// <summary>
        /// Changes in the normal mechanical, physical, and biochemical functions that are associated with this activity or condition.
        /// </summary>
        [JsonPropertyName("pathophysiology")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Pathophysiology { get; set; }
    }
}
