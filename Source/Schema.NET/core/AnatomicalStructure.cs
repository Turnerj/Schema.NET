namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Any part of the human body, typically a component of an anatomical system. Organs, tissues, and cells are all anatomical structures.
    /// </summary>
    public partial interface IAnatomicalStructure : IMedicalEntity
    {
        /// <summary>
        /// If applicable, a description of the pathophysiology associated with the anatomical system, including potential abnormal changes in the mechanical, physical, and biochemical functions of the system.
        /// </summary>
        OneOrMany<string> AssociatedPathophysiology { get; set; }

        /// <summary>
        /// Location in the body of the anatomical structure.
        /// </summary>
        OneOrMany<string> BodyLocation { get; set; }

        /// <summary>
        /// Other anatomical structures to which this structure is connected.
        /// </summary>
        OneOrMany<IAnatomicalStructure> ConnectedTo { get; set; }

        /// <summary>
        /// An image containing a diagram that illustrates the structure and/or its component substructures and/or connections with other structures.
        /// </summary>
        OneOrMany<IImageObject> Diagram { get; set; }

        /// <summary>
        /// Function of the anatomical structure.
        /// </summary>
        OneOrMany<string> Function { get; set; }

        /// <summary>
        /// The anatomical or organ system that this structure is part of.
        /// </summary>
        OneOrMany<IAnatomicalSystem> PartOfSystem { get; set; }

        /// <summary>
        /// A medical condition associated with this anatomy.
        /// </summary>
        OneOrMany<IMedicalCondition> RelatedCondition { get; set; }

        /// <summary>
        /// A medical therapy related to this anatomy.
        /// </summary>
        OneOrMany<IMedicalTherapy> RelatedTherapy { get; set; }

        /// <summary>
        /// Component (sub-)structure(s) that comprise this anatomical structure.
        /// </summary>
        OneOrMany<IAnatomicalStructure> SubStructure { get; set; }
    }

    /// <summary>
    /// Any part of the human body, typically a component of an anatomical system. Organs, tissues, and cells are all anatomical structures.
    /// </summary>
    public partial class AnatomicalStructure : MedicalEntity, IAnatomicalStructure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AnatomicalStructure";

        /// <summary>
        /// If applicable, a description of the pathophysiology associated with the anatomical system, including potential abnormal changes in the mechanical, physical, and biochemical functions of the system.
        /// </summary>
        [JsonPropertyName("associatedPathophysiology")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AssociatedPathophysiology { get; set; }

        /// <summary>
        /// Location in the body of the anatomical structure.
        /// </summary>
        [JsonPropertyName("bodyLocation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BodyLocation { get; set; }

        /// <summary>
        /// Other anatomical structures to which this structure is connected.
        /// </summary>
        [JsonPropertyName("connectedTo")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAnatomicalStructure> ConnectedTo { get; set; }

        /// <summary>
        /// An image containing a diagram that illustrates the structure and/or its component substructures and/or connections with other structures.
        /// </summary>
        [JsonPropertyName("diagram")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IImageObject> Diagram { get; set; }

        /// <summary>
        /// Function of the anatomical structure.
        /// </summary>
        [JsonPropertyName("function")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Function { get; set; }

        /// <summary>
        /// The anatomical or organ system that this structure is part of.
        /// </summary>
        [JsonPropertyName("partOfSystem")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAnatomicalSystem> PartOfSystem { get; set; }

        /// <summary>
        /// A medical condition associated with this anatomy.
        /// </summary>
        [JsonPropertyName("relatedCondition")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalCondition> RelatedCondition { get; set; }

        /// <summary>
        /// A medical therapy related to this anatomy.
        /// </summary>
        [JsonPropertyName("relatedTherapy")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalTherapy> RelatedTherapy { get; set; }

        /// <summary>
        /// Component (sub-)structure(s) that comprise this anatomical structure.
        /// </summary>
        [JsonPropertyName("subStructure")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAnatomicalStructure> SubStructure { get; set; }
    }
}
