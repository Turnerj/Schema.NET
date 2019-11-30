namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A Property value specification.
    /// </summary>
    public partial interface IPropertyValueSpecification : IIntangible
    {
        /// <summary>
        /// The default value of the input.  For properties that expect a literal, the default is a literal value, for properties that expect an object, it's an ID reference to one of the current values.
        /// </summary>
        Values<string, IThing> DefaultValue { get; set; }

        /// <summary>
        /// The upper value of some characteristic or property.
        /// </summary>
        OneOrMany<double?> MaxValue { get; set; }

        /// <summary>
        /// The lower value of some characteristic or property.
        /// </summary>
        OneOrMany<double?> MinValue { get; set; }

        /// <summary>
        /// Whether multiple values are allowed for the property.  Default is false.
        /// </summary>
        OneOrMany<bool?> MultipleValues { get; set; }

        /// <summary>
        /// Whether or not a property is mutable.  Default is false. Specifying this for a property that also has a value makes it act similar to a "hidden" input in an HTML form.
        /// </summary>
        OneOrMany<bool?> ReadonlyValue { get; set; }

        /// <summary>
        /// The stepValue attribute indicates the granularity that is expected (and required) of the value in a PropertyValueSpecification.
        /// </summary>
        OneOrMany<double?> StepValue { get; set; }

        /// <summary>
        /// Specifies the allowed range for number of characters in a literal value.
        /// </summary>
        OneOrMany<double?> ValueMaxLength { get; set; }

        /// <summary>
        /// Specifies the minimum allowed range for number of characters in a literal value.
        /// </summary>
        OneOrMany<double?> ValueMinLength { get; set; }

        /// <summary>
        /// Indicates the name of the PropertyValueSpecification to be used in URL templates and form encoding in a manner analogous to HTML's input@name.
        /// </summary>
        OneOrMany<string> ValueName { get; set; }

        /// <summary>
        /// Specifies a regular expression for testing literal values according to the HTML spec.
        /// </summary>
        OneOrMany<string> ValuePattern { get; set; }

        /// <summary>
        /// Whether the property must be filled in to complete the action.  Default is false.
        /// </summary>
        OneOrMany<bool?> ValueRequired { get; set; }
    }

    /// <summary>
    /// A Property value specification.
    /// </summary>
    public partial class PropertyValueSpecification : Intangible, IPropertyValueSpecification
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PropertyValueSpecification";

        /// <summary>
        /// The default value of the input.  For properties that expect a literal, the default is a literal value, for properties that expect an object, it's an ID reference to one of the current values.
        /// </summary>
        [JsonPropertyName("defaultValue")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IThing> DefaultValue { get; set; }

        /// <summary>
        /// The upper value of some characteristic or property.
        /// </summary>
        [JsonPropertyName("maxValue")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> MaxValue { get; set; }

        /// <summary>
        /// The lower value of some characteristic or property.
        /// </summary>
        [JsonPropertyName("minValue")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> MinValue { get; set; }

        /// <summary>
        /// Whether multiple values are allowed for the property.  Default is false.
        /// </summary>
        [JsonPropertyName("multipleValues")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> MultipleValues { get; set; }

        /// <summary>
        /// Whether or not a property is mutable.  Default is false. Specifying this for a property that also has a value makes it act similar to a "hidden" input in an HTML form.
        /// </summary>
        [JsonPropertyName("readonlyValue")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> ReadonlyValue { get; set; }

        /// <summary>
        /// The stepValue attribute indicates the granularity that is expected (and required) of the value in a PropertyValueSpecification.
        /// </summary>
        [JsonPropertyName("stepValue")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> StepValue { get; set; }

        /// <summary>
        /// Specifies the allowed range for number of characters in a literal value.
        /// </summary>
        [JsonPropertyName("valueMaxLength")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> ValueMaxLength { get; set; }

        /// <summary>
        /// Specifies the minimum allowed range for number of characters in a literal value.
        /// </summary>
        [JsonPropertyName("valueMinLength")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> ValueMinLength { get; set; }

        /// <summary>
        /// Indicates the name of the PropertyValueSpecification to be used in URL templates and form encoding in a manner analogous to HTML's input@name.
        /// </summary>
        [JsonPropertyName("valueName")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ValueName { get; set; }

        /// <summary>
        /// Specifies a regular expression for testing literal values according to the HTML spec.
        /// </summary>
        [JsonPropertyName("valuePattern")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ValuePattern { get; set; }

        /// <summary>
        /// Whether the property must be filled in to complete the action.  Default is false.
        /// </summary>
        [JsonPropertyName("valueRequired")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> ValueRequired { get; set; }
    }
}
