using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class LiquidationExchangeListModel
    {
        [JsonProperty("exchangeName")]
        public string? ExchangeName { get; set; }

        [JsonProperty("totalLiquidation")]
        public decimal? TotalLiquidation { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
