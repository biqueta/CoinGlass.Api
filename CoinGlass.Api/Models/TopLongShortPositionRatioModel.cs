using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class TopLongShortPositionRatioModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("longPosition")]
        public decimal? LongPosition { get; set; }

        [JsonProperty("shortPosition")]
        public decimal? ShortPosition { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
