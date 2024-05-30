using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class LiquidationHeatmapDataModel
    {
        [JsonProperty("symbol")]
        public string? Symbol { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("longs")]
        public int Longs { get; set; }

        [JsonProperty("shorts")]
        public int Shorts { get; set; }
    }
}
