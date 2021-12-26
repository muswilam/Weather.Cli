using System.Text.Json.Serialization;

namespace Weather.Cli.Contracts
{
    public class Rain
    {
        [JsonPropertyName("1h")]
        public double _1h { get; set; }
    }
}
