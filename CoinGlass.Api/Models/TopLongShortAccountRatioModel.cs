using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class TopLongShortAccountRatioModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("longAccount")]
        public decimal? LongAccount { get; set; }

        [JsonProperty("shortAccount")]
        public decimal? ShortAccount { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
