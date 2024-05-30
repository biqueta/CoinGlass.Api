using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class OiWeightOhlcHistoryModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("oiWeight")]
        public decimal? OiWeight { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
