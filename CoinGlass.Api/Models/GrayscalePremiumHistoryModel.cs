using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class GrayscalePremiumHistoryModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("premium")]
        public decimal? Premium { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
