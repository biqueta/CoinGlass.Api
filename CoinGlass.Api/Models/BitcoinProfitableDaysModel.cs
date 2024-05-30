using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class BitcoinProfitableDaysModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("profitableDays")]
        public decimal? ProfitableDays { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
