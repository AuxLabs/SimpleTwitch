﻿using System.Text.Json.Serialization;

namespace AuxLabs.SimpleTwitch.Rest.Models
{
    public class EmoteTheme
    {
        [JsonPropertyName("dark")]
        public EmoteFormat Dark { get; set; }
        [JsonPropertyName("light")]
        public EmoteFormat Light { get; set; }

        [JsonConstructor]
        public EmoteTheme(EmoteFormat dark, EmoteFormat light)
            => (Dark, Light) = (dark, light);
    }
}