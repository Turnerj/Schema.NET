namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Converts a <see cref="JsonLdContext"/> object to and from JSON.
    /// </summary>
    public class ContextJsonConverter : JsonConverter<JsonLdContext>
    {
        /// <inheritdoc />
        public override JsonLdContext Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (typeToConvert is null)
            {
                throw new ArgumentNullException(nameof(typeToConvert));
            }

            if (options is null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            var context = new JsonLdContext();

            if (reader.TokenType == JsonTokenType.String)
            {
                context.Name = reader.GetString();
            }
            else
            {
                var o = JsonDocument.ParseValue(ref reader);

                if (o.RootElement.TryGetProperty("name", out var nameElement))
                {
                    context.Name = nameElement.GetString() ?? "http://schema.org";
                }

                if (o.RootElement.TryGetProperty("@language", out var languageElement))
                {
                    context.Language = languageElement.GetString();
                }
            }

            return context;
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, JsonLdContext value, JsonSerializerOptions options)
        {
            if (writer is null)
            {
                throw new ArgumentNullException(nameof(writer));
            }

            if (value is null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (options is null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrWhiteSpace(value.Language))
            {
                writer.WriteStringValue(value.Name);
            }
            else
            {
                writer.WriteStartObject();
                writer.WriteString("name", value.Name);
                writer.WriteString("@language", value.Language);
                writer.WriteEndObject();
            }
        }
    }
}
