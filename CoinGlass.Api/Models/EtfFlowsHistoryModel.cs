using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class EtfFlowsHistoryModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("flow")]
        public decimal? Flow { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
