using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class GrayscaleHoldingListModel
    {
        [JsonProperty("symbol")]
        public string? Symbol { get; set; }

        [JsonProperty("holding")]
        public decimal? Holding { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
