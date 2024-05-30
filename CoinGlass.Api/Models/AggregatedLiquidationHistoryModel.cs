using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class AggregatedLiquidationHistoryModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("totalLiquidation")]
        public decimal? TotalLiquidation { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
