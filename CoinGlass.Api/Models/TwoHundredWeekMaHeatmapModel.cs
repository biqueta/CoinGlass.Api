using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class TwoHundredWeekMaHeatmapModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("heatmapValue")]
        public decimal? HeatmapValue { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
