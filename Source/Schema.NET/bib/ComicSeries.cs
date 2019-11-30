namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A sequential publication of comic stories under a
    ///     unifying title, for example "The Amazing Spider-Man" or "Groo the
    ///     Wanderer".
    /// </summary>
    public partial interface IComicSeries : IPeriodical
    {
    }

    /// <summary>
    /// A sequential publication of comic stories under a
    ///     unifying title, for example "The Amazing Spider-Man" or "Groo the
    ///     Wanderer".
    /// </summary>
    public partial class ComicSeries : Periodical, IComicSeries
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ComicSeries";
    }
}
