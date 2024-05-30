using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class PiCycleModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("piCycle")]
        public decimal? PiCycle { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
