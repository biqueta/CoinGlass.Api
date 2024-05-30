using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class Ahr999Model
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("ahr999")]
        public decimal? Ahr999 { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
