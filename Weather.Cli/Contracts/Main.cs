﻿using System.Text.Json.Serialization;

namespace Weather.Cli.Contracts
{
    public class Main
    {
        [JsonPropertyName("temp")]
        public double Temp { get; set; }

        [JsonPropertyName("feels_like")]
        public double FeelsLike { get; set; }

        [JsonPropertyName("temp_min")]
        public double TempMin { get; set; }

        [JsonPropertyName("temp_max")]
        public double TempMax { get; set; }

        [JsonPropertyName("pressure ")]
        public int Pressure { get; set; }

        [JsonPropertyName("humidity")]
        public int Hunidity { get; set; }
    }
}
