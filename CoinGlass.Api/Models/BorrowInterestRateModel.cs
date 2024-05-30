using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class BorrowInterestRateModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("interestRate")]
        public decimal? InterestRate { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
