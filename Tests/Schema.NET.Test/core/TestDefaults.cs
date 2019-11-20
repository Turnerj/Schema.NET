namespace Schema.NET.Test
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.Json;

    public static class TestDefaults
    {
        public static readonly JsonSerializerOptions DefaultJsonSerializerSettings = new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            IgnoreNullValues = true
        };
    }
}
