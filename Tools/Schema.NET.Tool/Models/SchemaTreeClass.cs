namespace Schema.NET.Tool.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    public class SchemaTreeClass
    {
#pragma warning disable CA2227 // Collection properties should be read only
        public List<SchemaTreeClass> Children { get; set; }// = new List<SchemaTreeClass>();
#pragma warning restore CA2227 // Collection properties should be read only

        public string Description { get; set; }

        [JsonPropertyName("@id")]
        public Uri Id { get; set; }

        public string Layer { get; set; }

        public string Name { get; set; }

        [JsonPropertyName("rdfs:subClassOf")]
        public string SubClassOf { get; set; }

        [JsonPropertyName("@type")]
        public string Type { get; set; }
    }
}
