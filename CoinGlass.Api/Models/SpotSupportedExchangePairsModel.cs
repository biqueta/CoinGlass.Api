using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class SpotSupportedExchangePairsModel
    {
        [JsonProperty("pair")]
        public string? Pair { get; set; }

        [JsonProperty("exchange")]
        public string? Exchange { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
