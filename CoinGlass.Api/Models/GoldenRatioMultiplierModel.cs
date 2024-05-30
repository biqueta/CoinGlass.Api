using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class GoldenRatioMultiplierModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("goldenRatio")]
        public decimal? GoldenRatio { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
