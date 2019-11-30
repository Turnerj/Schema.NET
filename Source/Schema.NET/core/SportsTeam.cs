namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Organization: Sports team.
    /// </summary>
    public partial interface ISportsTeam : ISportsOrganization
    {
        /// <summary>
        /// A person that acts as performing member of a sports team; a player as opposed to a coach.
        /// </summary>
        OneOrMany<IPerson> Athlete { get; set; }

        /// <summary>
        /// A person that acts in a coaching role for a sports team.
        /// </summary>
        OneOrMany<IPerson> Coach { get; set; }

        /// <summary>
        /// Gender of something, typically a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt;, but possibly also fictional characters, animals, etc. While http://schema.org/Male and http://schema.org/Female may be used, text strings are also acceptable for people who do not identify as a binary gender. The &lt;a class="localLink" href="http://schema.org/gender"&gt;gender&lt;/a&gt; property can also be used in an extended sense to cover e.g. the gender of sports teams. As with the gender of individuals, we do not try to enumerate all possibilities. A mixed-gender &lt;a class="localLink" href="http://schema.org/SportsTeam"&gt;SportsTeam&lt;/a&gt; can be indicated with a text value of "Mixed".
        /// </summary>
        Values<GenderType?, string> Gender { get; set; }
    }

    /// <summary>
    /// Organization: Sports team.
    /// </summary>
    public partial class SportsTeam : SportsOrganization, ISportsTeam
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "SportsTeam";

        /// <summary>
        /// A person that acts as performing member of a sports team; a player as opposed to a coach.
        /// </summary>
        [JsonPropertyName("athlete")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Athlete { get; set; }

        /// <summary>
        /// A person that acts in a coaching role for a sports team.
        /// </summary>
        [JsonPropertyName("coach")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Coach { get; set; }

        /// <summary>
        /// Gender of something, typically a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt;, but possibly also fictional characters, animals, etc. While http://schema.org/Male and http://schema.org/Female may be used, text strings are also acceptable for people who do not identify as a binary gender. The &lt;a class="localLink" href="http://schema.org/gender"&gt;gender&lt;/a&gt; property can also be used in an extended sense to cover e.g. the gender of sports teams. As with the gender of individuals, we do not try to enumerate all possibilities. A mixed-gender &lt;a class="localLink" href="http://schema.org/SportsTeam"&gt;SportsTeam&lt;/a&gt; can be indicated with a text value of "Mixed".
        /// </summary>
        [JsonPropertyName("gender")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<GenderType?, string> Gender { get; set; }
    }
}
