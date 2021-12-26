using System.Text.Json.Serialization;

namespace Weather.Cli.Contracts
{
    public class Coord
    {
        [JsonPropertyName("lon")]
        public double Lon { get; set; }

        [JsonPropertyName("lat")]
        public double Lat { get; set; }
    }
}
