namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Event type: Education event.
    /// </summary>
    public partial interface IEducationEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Education event.
    /// </summary>
    [DataContract]
    public partial class EducationEvent : Event, IEducationEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EducationEvent";
    }
}
