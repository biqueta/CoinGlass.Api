using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class BitcoinBubbleIndexModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("bubbleIndex")]
        public decimal? BubbleIndex { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
