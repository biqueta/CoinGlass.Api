using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class TwoYearMaMultiplierModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("maMultiplier")]
        public decimal? MaMultiplier { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
