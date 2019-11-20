namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.Json;

    internal static class JsonElementExtensions
    {
        public static object ToObject(this JsonElement element, Type objectType)
        {
            // TODO: Investigate avoiding the string allocation
            var json = element.GetRawText();
            return JsonSerializer.Deserialize(json, objectType);
        }
    }
}
