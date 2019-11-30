namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public partial class Thing : JsonLdObject
    {
        private const string ContextPropertyJson = "\"@context\":\"https://schema.org\",";

        /// <summary>
        /// Default serializer settings used.
        /// </summary>
        private static readonly JsonSerializerOptions SerializerSettings;

        /// <summary>
        /// Serializer settings used when trying to avoid XSS vulnerabilities where user-supplied data is used
        /// and the output of the serialization is embedded into a web page raw.
        /// </summary>
        private static readonly JsonSerializerOptions HtmlEscapedSerializerSettings;

#pragma warning disable CA1810 // Initialize reference type static fields inline - required to add custom Converter
        static Thing()
#pragma warning restore CA1810 // Initialize reference type static fields inline
        {
            var stringEnumConverter = new JsonStringEnumConverter();

            SerializerSettings = new JsonSerializerOptions
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                IgnoreNullValues = true
            };
            SerializerSettings.Converters.Add(stringEnumConverter);

            HtmlEscapedSerializerSettings = new JsonSerializerOptions
            {
                IgnoreNullValues = true
            };
            HtmlEscapedSerializerSettings.Converters.Add(stringEnumConverter);
        }

        /// <summary>
        /// Returns the JSON-LD representation of this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents the JSON-LD representation of this instance.
        /// </returns>
        public override string ToString() => this.ToString(SerializerSettings);

        /// <summary>
        /// Returns the JSON-LD representation of this instance.
        ///
        /// This method should be used when you want to embed the output raw (as-is) into a web
        /// page. It uses serializer settings with HTML escaping to avoid Cross-Site Scripting (XSS)
        /// vulnerabilities if the object was constructed from an untrusted source.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents the JSON-LD representation of this instance.
        /// </returns>
        public string ToHtmlEscapedString() => this.ToString(HtmlEscapedSerializerSettings);

        /// <summary>
        /// Returns the JSON-LD representation of this instance using the <see cref="JsonSerializerOptions"/> provided.
        /// </summary>
        /// <param name="serializerSettings">Serialization settings.</param>
        /// <returns>
        /// A <see cref="string" /> that represents the JSON-LD representation of this instance.
        /// </returns>
        public string ToString(JsonSerializerOptions serializerSettings) =>
            RemoveAllButRootContext(JsonSerializer.Serialize(this, serializerSettings));

        private static string RemoveAllButRootContext(string json)
        {
            var stringBuilder = new StringBuilder(json);
            var lastIndex = json.LastIndexOf(ContextPropertyJson, StringComparison.OrdinalIgnoreCase);
            stringBuilder.Replace(ContextPropertyJson, string.Empty, 0, lastIndex);
            return stringBuilder.ToString();
        }
    }
}
