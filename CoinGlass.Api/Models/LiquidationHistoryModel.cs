using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class LiquidationHistoryModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("symbol")]
        public string? Symbol { get; set; }

        [JsonProperty("side")]
        public string? Side { get; set; }

        [JsonProperty("price")]
        public decimal? Price { get; set; }

        [JsonProperty("quantity")]
        public decimal? Quantity { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
