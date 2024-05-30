using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class SpotTakerBuySellRatioHistoryModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("buyRatio")]
        public decimal? BuyRatio { get; set; }

        [JsonProperty("sellRatio")]
        public decimal? SellRatio { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
