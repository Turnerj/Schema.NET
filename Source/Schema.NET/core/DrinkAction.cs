namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of swallowing liquids.
    /// </summary>
    public partial interface IDrinkAction : IConsumeAction
    {
    }

    /// <summary>
    /// The act of swallowing liquids.
    /// </summary>
    public partial class DrinkAction : ConsumeAction, IDrinkAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DrinkAction";
    }
}
