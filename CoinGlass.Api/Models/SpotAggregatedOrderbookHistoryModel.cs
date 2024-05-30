using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class SpotAggregatedOrderbookHistoryModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("buyOrders")]
        public decimal? BuyOrders { get; set; }

        [JsonProperty("sellOrders")]
        public decimal? SellOrders { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
