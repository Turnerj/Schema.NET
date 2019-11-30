namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of editing by adding an object to a collection.
    /// </summary>
    public partial interface IAddAction : IUpdateAction
    {
    }

    /// <summary>
    /// The act of editing by adding an object to a collection.
    /// </summary>
    public partial class AddAction : UpdateAction, IAddAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AddAction";
    }
}
