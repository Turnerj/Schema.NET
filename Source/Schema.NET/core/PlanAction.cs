namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of planning the execution of an event/task/action/reservation/plan to a future date.
    /// </summary>
    public partial interface IPlanAction : IOrganizeAction
    {
        /// <summary>
        /// The time the object is scheduled to.
        /// </summary>
        OneOrMany<DateTimeOffset?> ScheduledTime { get; set; }
    }

    /// <summary>
    /// The act of planning the execution of an event/task/action/reservation/plan to a future date.
    /// </summary>
    public partial class PlanAction : OrganizeAction, IPlanAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PlanAction";

        /// <summary>
        /// The time the object is scheduled to.
        /// </summary>
        [JsonPropertyName("scheduledTime")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> ScheduledTime { get; set; }
    }
}
