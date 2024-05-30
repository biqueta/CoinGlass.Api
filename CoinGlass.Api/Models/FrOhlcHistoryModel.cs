using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class FrOhlcHistoryModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("fundingRate")]
        public decimal? FundingRate { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
