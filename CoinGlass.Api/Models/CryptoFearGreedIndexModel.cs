using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class CryptoFearGreedIndexModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("fearGreedIndex")]
        public decimal? FearGreedIndex { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
