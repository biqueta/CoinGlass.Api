using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class LiquidationOrderModel
    {
        [JsonProperty("symbol")]
        public string? Symbol { get; set; }

        [JsonProperty("price")]
        public decimal? Price { get; set; }

        [JsonProperty("quantity")]
        public decimal? Quantity { get; set; }

        [JsonProperty("side")]
        public string? Side { get; set; }

        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
