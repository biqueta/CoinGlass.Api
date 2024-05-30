using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class ExchangeInfoModel
    {
        [JsonProperty("exchangeName")]
        public string? ExchangeName { get; set; }

        [JsonProperty("volume")]
        public decimal? Volume { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
