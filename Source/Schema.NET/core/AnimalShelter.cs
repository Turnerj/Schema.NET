namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Animal shelter.
    /// </summary>
    public partial interface IAnimalShelter : ILocalBusiness
    {
    }

    /// <summary>
    /// Animal shelter.
    /// </summary>
    public partial class AnimalShelter : LocalBusiness, IAnimalShelter
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AnimalShelter";
    }
}
