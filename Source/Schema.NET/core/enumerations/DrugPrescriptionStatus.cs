﻿namespace Schema.NET
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;


    /// <summary>
    /// Indicates whether this drug is available by prescription or over-the-counter.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DrugPrescriptionStatus
    {
        /// <summary>
        /// The character of a medical substance, typically a medicine, of being available over the counter or not.
        /// </summary>
        [EnumMember(Value = "https://schema.org/OTC")]
        OTC,

        /// <summary>
        /// Available by prescription only.
        /// </summary>
        [EnumMember(Value = "https://schema.org/PrescriptionOnly")]
        PrescriptionOnly
    }
}
