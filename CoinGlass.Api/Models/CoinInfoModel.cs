using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class CoinInfoModel
    {
        [JsonProperty("symbol")]
        public string? Symbol { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("price")]
        public decimal? Price { get; set; }

        [JsonProperty("marketCap")]
        public decimal? MarketCap { get; set; }
    }
}
