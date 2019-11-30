namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of producing a visual/graphical representation of an object, typically with a pen/pencil and paper as instruments.
    /// </summary>
    public partial interface IDrawAction : ICreateAction
    {
    }

    /// <summary>
    /// The act of producing a visual/graphical representation of an object, typically with a pen/pencil and paper as instruments.
    /// </summary>
    public partial class DrawAction : CreateAction, IDrawAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DrawAction";
    }
}
