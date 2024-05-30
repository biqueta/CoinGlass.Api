using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class FuturesRsiListModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("rsi")]
        public decimal? Rsi { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
