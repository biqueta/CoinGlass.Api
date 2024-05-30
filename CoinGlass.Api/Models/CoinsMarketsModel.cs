using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class CoinsMarketsModel
    {
        [JsonProperty("symbol")]
        public string? Symbol { get; set; }

        [JsonProperty("market")]
        public string? Market { get; set; }

        [JsonProperty("price")]
        public decimal? Price { get; set; }

        [JsonProperty("volume")]
        public decimal? Volume { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
