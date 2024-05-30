using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class PairsMarketsModel
    {
        [JsonProperty("pair")]
        public string? Pair { get; set; }

        [JsonProperty("market")]
        public string? Market { get; set; }

        [JsonProperty("price")]
        public decimal? Price { get; set; }

        [JsonProperty("volume")]
        public decimal? Volume { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
