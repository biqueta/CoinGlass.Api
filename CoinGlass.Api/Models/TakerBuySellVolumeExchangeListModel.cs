using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class TakerBuySellVolumeExchangeListModel
    {
        [JsonProperty("exchangeName")]
        public string? ExchangeName { get; set; }

        [JsonProperty("buyVolume")]
        public decimal? BuyVolume { get; set; }

        [JsonProperty("sellVolume")]
        public decimal? SellVolume { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
