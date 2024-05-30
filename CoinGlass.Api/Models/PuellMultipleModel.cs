using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class PuellMultipleModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("puellMultiple")]
        public decimal? PuellMultiple { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
