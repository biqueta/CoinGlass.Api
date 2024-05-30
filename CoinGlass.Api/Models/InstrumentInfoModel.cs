using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class InstrumentInfoModel
    {
        [JsonProperty("symbol")]
        public string? Symbol { get; set; }

        [JsonProperty("instrumentName")]
        public string? InstrumentName { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("market")]
        public string? Market { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
