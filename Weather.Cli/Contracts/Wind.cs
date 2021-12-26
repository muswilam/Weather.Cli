using System.Text.Json.Serialization;

namespace Weather.Cli.Contracts
{
    public class Wind
    {
        [JsonPropertyName("speed")]
        public double Speed { get; set; }

        [JsonPropertyName("deg")]
        public int Degree { get; set; }
    }
}
