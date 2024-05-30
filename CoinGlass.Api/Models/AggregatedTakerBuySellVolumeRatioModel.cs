﻿using Newtonsoft.Json;

namespace CoinGlassApi.Models
{
    public class AggregatedTakerBuySellVolumeRatioModel
    {
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("buyVolume")]
        public decimal? BuyVolume { get; set; }

        [JsonProperty("sellVolume")]
        public decimal? SellVolume { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
