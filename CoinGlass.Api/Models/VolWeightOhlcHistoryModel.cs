using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class VolWeightOhlcHistoryModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("volWeight")]
        public decimal? VolWeight { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
