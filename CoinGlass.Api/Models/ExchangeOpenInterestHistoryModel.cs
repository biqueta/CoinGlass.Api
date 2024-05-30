using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class ExchangeOpenInterestHistoryModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("openInterest")]
        public decimal? OpenInterest { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
