using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class SpotSupportedCoinsModel
    {
        [JsonProperty("symbol")]
        public string? Symbol { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
