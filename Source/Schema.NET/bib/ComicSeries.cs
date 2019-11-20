﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
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
    [DataContract]
    public partial class ComicSeries : Periodical, IComicSeries
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ComicSeries";
    }
}
