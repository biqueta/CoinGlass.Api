using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class CoinsPriceChangeModel
    {
        [JsonProperty("symbol")]
        public string? Symbol { get; set; }

        [JsonProperty("priceChange")]
        public decimal? PriceChange { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
