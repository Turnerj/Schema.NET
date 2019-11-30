namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An anatomical system is a group of anatomical structures that work together to perform a certain task. Anatomical systems, such as organ systems, are one organizing principle of anatomy, and can includes circulatory, digestive, endocrine, integumentary, immune, lymphatic, muscular, nervous, reproductive, respiratory, skeletal, urinary, vestibular, and other systems.
    /// </summary>
    public partial interface IAnatomicalSystem : IMedicalEntity
    {
        /// <summary>
        /// If applicable, a description of the pathophysiology associated with the anatomical system, including potential abnormal changes in the mechanical, physical, and biochemical functions of the system.
        /// </summary>
        OneOrMany<string> AssociatedPathophysiology { get; set; }

        /// <summary>
        /// Specifying something physically contained by something else. Typically used here for the underlying anatomical structures, such as organs, that comprise the anatomical system.
        /// </summary>
        Values<IAnatomicalStructure, IAnatomicalSystem> ComprisedOf { get; set; }

        /// <summary>
        /// A medical condition associated with this anatomy.
        /// </summary>
        OneOrMany<IMedicalCondition> RelatedCondition { get; set; }

        /// <summary>
        /// Related anatomical structure(s) that are not part of the system but relate or connect to it, such as vascular bundles associated with an organ system.
        /// </summary>
        OneOrMany<IAnatomicalStructure> RelatedStructure { get; set; }

        /// <summary>
        /// A medical therapy related to this anatomy.
        /// </summary>
        OneOrMany<IMedicalTherapy> RelatedTherapy { get; set; }
    }

    /// <summary>
    /// An anatomical system is a group of anatomical structures that work together to perform a certain task. Anatomical systems, such as organ systems, are one organizing principle of anatomy, and can includes circulatory, digestive, endocrine, integumentary, immune, lymphatic, muscular, nervous, reproductive, respiratory, skeletal, urinary, vestibular, and other systems.
    /// </summary>
    public partial class AnatomicalSystem : MedicalEntity, IAnatomicalSystem
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AnatomicalSystem";

        /// <summary>
        /// If applicable, a description of the pathophysiology associated with the anatomical system, including potential abnormal changes in the mechanical, physical, and biochemical functions of the system.
        /// </summary>
        [JsonPropertyName("associatedPathophysiology")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AssociatedPathophysiology { get; set; }

        /// <summary>
        /// Specifying something physically contained by something else. Typically used here for the underlying anatomical structures, such as organs, that comprise the anatomical system.
        /// </summary>
        [JsonPropertyName("comprisedOf")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAnatomicalStructure, IAnatomicalSystem> ComprisedOf { get; set; }

        /// <summary>
        /// A medical condition associated with this anatomy.
        /// </summary>
        [JsonPropertyName("relatedCondition")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalCondition> RelatedCondition { get; set; }

        /// <summary>
        /// Related anatomical structure(s) that are not part of the system but relate or connect to it, such as vascular bundles associated with an organ system.
        /// </summary>
        [JsonPropertyName("relatedStructure")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAnatomicalStructure> RelatedStructure { get; set; }

        /// <summary>
        /// A medical therapy related to this anatomy.
        /// </summary>
        [JsonPropertyName("relatedTherapy")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalTherapy> RelatedTherapy { get; set; }
    }
}
