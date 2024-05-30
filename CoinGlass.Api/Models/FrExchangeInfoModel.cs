using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class FrExchangeInfoModel
    {
        [JsonProperty("exchangeName")]
        public string? ExchangeName { get; set; }

        [JsonProperty("fundingRate")]
        public decimal? FundingRate { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
