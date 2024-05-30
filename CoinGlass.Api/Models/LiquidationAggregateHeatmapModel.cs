using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class LiquidationAggregateHeatmapModel
    {
        [JsonProperty("price")]
        public decimal? Price { get; set; }

        [JsonProperty("quantity")]
        public decimal? Quantity { get; set; }

        [JsonProperty("side")]
        public string? Side { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
