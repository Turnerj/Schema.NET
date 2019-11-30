namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of participating in performance arts.
    /// </summary>
    public partial interface IPerformAction : IPlayAction
    {
        /// <summary>
        /// A sub property of location. The entertainment business where the action occurred.
        /// </summary>
        OneOrMany<IEntertainmentBusiness> EntertainmentBusiness { get; set; }
    }

    /// <summary>
    /// The act of participating in performance arts.
    /// </summary>
    public partial class PerformAction : PlayAction, IPerformAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PerformAction";

        /// <summary>
        /// A sub property of location. The entertainment business where the action occurred.
        /// </summary>
        [JsonPropertyName("entertainmentBusiness")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEntertainmentBusiness> EntertainmentBusiness { get; set; }
    }
}
