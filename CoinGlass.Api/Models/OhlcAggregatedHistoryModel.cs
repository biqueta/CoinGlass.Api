using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class OhlcAggregatedHistoryModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("open")]
        public decimal? Open { get; set; }

        [JsonProperty("high")]
        public decimal? High { get; set; }

        [JsonProperty("low")]
        public decimal? Low { get; set; }

        [JsonProperty("close")]
        public decimal? Close { get; set; }

        [JsonProperty("volume")]
        public decimal? Volume { get; set; }
    }
}
