using System.Text.Json.Serialization;

namespace Weather.Cli.Contracts
{
    public class Clouds
    {
        [JsonPropertyName("all")]
        public int All { get; set; }
    }
}
