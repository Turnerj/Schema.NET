namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.Json;

    /// <summary>
    /// Extensions for JsonElement
    /// </summary>
    internal static class JsonElementExtensions
    {
        /// <summary>
        /// Converts a <see cref="JsonElement"/> into an object of the specified type.
        /// </summary>
        /// <param name="element">The element to convert.</param>
        /// <param name="objectType">The type to convert to.</param>
        /// <param name="options">The JSON serializer options.</param>
        /// <returns>The converted object.</returns>
        public static object ToObject(this JsonElement element, Type objectType, JsonSerializerOptions options)
        {
            // TODO: Investigate avoiding the string allocation
            var json = element.GetRawText();
            return JsonSerializer.Deserialize(json, objectType, options);
        }
    }
}
