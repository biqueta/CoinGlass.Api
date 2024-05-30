using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class StockToFlowModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("stockToFlow")]
        public decimal? StockToFlow { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
