namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An aggregate rating of an Organization related to its role as an employer.
    /// </summary>
    public partial interface IEmployerAggregateRating : IAggregateRating
    {
    }

    /// <summary>
    /// An aggregate rating of an Organization related to its role as an employer.
    /// </summary>
    public partial class EmployerAggregateRating : AggregateRating, IEmployerAggregateRating
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "EmployerAggregateRating";
    }
}
