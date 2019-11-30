namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of capturing sound and moving images on film, video, or digitally.
    /// </summary>
    public partial interface IFilmAction : ICreateAction
    {
    }

    /// <summary>
    /// The act of capturing sound and moving images on film, video, or digitally.
    /// </summary>
    public partial class FilmAction : CreateAction, IFilmAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "FilmAction";
    }
}
