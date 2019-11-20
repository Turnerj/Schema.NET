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

#pragma warning disable CA1810 // Initialize reference type static fields inline - required to add custom Converter
        static Thing()
#pragma warning restore CA1810 // Initialize reference type static fields inline
        {
            SerializerSettings = new JsonSerializerOptions
            {
                IgnoreNullValues = true
            };

            SerializerSettings.Converters.Add(new JsonStringEnumConverter());
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
        [Obsolete("Use ToString() - The default encoder automatically escapes HTML within strings")]
        public string ToHtmlEscapedString() => this.ToString();

        /// <summary>
        /// Returns the JSON-LD representation of this instance using the <see cref="JsonSerializerOptions"/> provided.
        /// </summary>
        /// <param name="serializerSettings">Serialization settings.</param>
        /// <returns>
        /// A <see cref="string" /> that represents the JSON-LD representation of this instance.
        /// </returns>
        public string ToString(JsonSerializerOptions serializerSettings) =>
            RemoveAllButFirstContext(JsonSerializer.Serialize(this, serializerSettings));

        private static string RemoveAllButFirstContext(string json)
        {
            var stringBuilder = new StringBuilder(json);
            var startIndex = ContextPropertyJson.Length + 1; // We add the one to represent the opening curly brace.
            stringBuilder.Replace(ContextPropertyJson, string.Empty, startIndex, stringBuilder.Length - startIndex);
            return stringBuilder.ToString();
        }
    }
}
