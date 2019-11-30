namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A medical test performed on a sample of a patient's blood.
    /// </summary>
    public partial interface IBloodTest : IMedicalTest
    {
    }

    /// <summary>
    /// A medical test performed on a sample of a patient's blood.
    /// </summary>
    public partial class BloodTest : MedicalTest, IBloodTest
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "BloodTest";
    }
}
