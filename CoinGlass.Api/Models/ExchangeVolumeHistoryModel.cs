using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class ExchangeVolumeHistoryModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("volume")]
        public decimal? Volume { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
