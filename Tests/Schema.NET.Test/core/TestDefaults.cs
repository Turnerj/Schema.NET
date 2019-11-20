namespace Schema.NET.Test
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.Json.Serialization;
    using Newtonsoft.Json.Serialization;

    public static class TestDefaults
    {
        public static readonly JsonSerializerSettings DefaultJsonSerializerSettings = new JsonSerializerSettings()
        {
            Formatting = Formatting.None,
            DateParseHandling = DateParseHandling.DateTimeOffset,
            DefaultValueHandling = DefaultValueHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore,
            TypeNameHandling = TypeNameHandling.None,
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        };
    }
}
