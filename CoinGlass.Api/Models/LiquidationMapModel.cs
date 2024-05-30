using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class LiquidationMapModel
    {
        [JsonProperty("price")]
        public decimal? Price { get; set; }

        [JsonProperty("longs")]
        public decimal? Longs { get; set; }

        [JsonProperty("shorts")]
        public decimal? Shorts { get; set; }

        [JsonProperty("total")]
        public decimal? Total { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
