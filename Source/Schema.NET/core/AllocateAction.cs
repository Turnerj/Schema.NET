namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of organizing tasks/objects/events by associating resources to it.
    /// </summary>
    public partial interface IAllocateAction : IOrganizeAction
    {
        /// <summary>
        /// A goal towards an action is taken. Can be concrete or abstract.
        /// </summary>
        Values<MedicalDevicePurpose?, IThing> Purpose { get; set; }
    }

    /// <summary>
    /// The act of organizing tasks/objects/events by associating resources to it.
    /// </summary>
    public partial class AllocateAction : OrganizeAction, IAllocateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AllocateAction";

        /// <summary>
        /// A goal towards an action is taken. Can be concrete or abstract.
        /// </summary>
        [JsonPropertyName("purpose")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<MedicalDevicePurpose?, IThing> Purpose { get; set; }
    }
}
