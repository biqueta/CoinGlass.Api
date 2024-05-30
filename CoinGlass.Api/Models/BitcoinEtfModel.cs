using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class BitcoinEtfModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("etfName")]
        public string? EtfName { get; set; }

        [JsonProperty("holdings")]
        public decimal? Holdings { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
