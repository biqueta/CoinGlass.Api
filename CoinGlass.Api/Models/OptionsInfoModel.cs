using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class OptionsInfoModel
    {
        [JsonProperty("symbol")]
        public string? Symbol { get; set; }

        [JsonProperty("expiryDate")]
        public long? ExpiryDate { get; set; }

        [JsonProperty("strikePrice")]
        public decimal? StrikePrice { get; set; }

        [JsonProperty("optionType")]
        public string? OptionType { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
