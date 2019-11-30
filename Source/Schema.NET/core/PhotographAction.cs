namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of capturing still images of objects using a camera.
    /// </summary>
    public partial interface IPhotographAction : ICreateAction
    {
    }

    /// <summary>
    /// The act of capturing still images of objects using a camera.
    /// </summary>
    public partial class PhotographAction : CreateAction, IPhotographAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PhotographAction";
    }
}
