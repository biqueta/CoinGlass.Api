using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class BitcoinRainbowChartModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("price")]
        public decimal? Price { get; set; }

        [JsonProperty("color")]
        public string? Color { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
