//using System;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Newtonsoft.Json;
//using CoinGlassApi.Models;

//namespace CoinGlassApi.Services
//{
//    public class CoinGlassService2
//    {
//        private static readonly HttpClient client = new HttpClient();
//        private readonly string apiKey;

//        public CoinGlassService2(string apiKey)
//        {
//            this.apiKey = apiKey;
//        }

//        public async Task<LiquidationHeatmapDataModel?[]> GetLiquidationHeatmapAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/futures/liquidation_heatmap";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<LiquidationHeatmapDataModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<CoinInfoModel?[]> GetCoinsAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/futures/coins";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<CoinInfoModel?[]>(responseBody);
//            return data;
//        }

//        public async Task<InstrumentInfoModel?[]> GetInstrumentsAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/futures/instruments";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<InstrumentInfoModel?[]>(responseBody);
//            return data;
//        }

//        public async Task<OhlcAggregatedHistoryModel?[]> GetOhlcAggregatedHistoryAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/ohlc_aggregated_history?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<OhlcAggregatedHistoryModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<OhlcAggregatedHistoryModel?[]> GetOhlcAggregatedStablecoinMarginHistoryAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/ohlc_aggregated_stablecoin_margin_history?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<OhlcAggregatedHistoryModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<OhlcAggregatedHistoryModel?[]> GetOhlcAggregatedCoinMarginHistoryAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/ohlc_aggregated_coin_margin_history?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<OhlcAggregatedHistoryModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<ExchangeInfoModel?[]> GetExchangeListAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/futures/exchange_list";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<ExchangeInfoModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<ExchangeHistoryChartModel?[]> GetExchangeHistoryChartAsync(string exchange)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/exchange_history_chart?exchange={exchange}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<ExchangeHistoryChartModel?[]>(responseBody);
//            return data;
//        }

//        public async Task<FrOhlcHistoryModel?[]> GetFrOhlcHistoryAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/fr_ohlc_history?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<FrOhlcHistoryModel?[]>(responseBody);
//            return data;
//        }

//        public async Task<OiWeightOhlcHistoryModel?[]> GetOiWeightOhlcHistoryAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/oi_weight_ohlc_history?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<OiWeightOhlcHistoryModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<VolWeightOhlcHistoryModel?[]> GetVolWeightOhlcHistoryAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/vol_weight_ohlc_history?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<VolWeightOhlcHistoryModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<FrExchangeInfoModel?[]> GetFrExchangeListAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/futures/fr_exchange_list";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<FrExchangeInfoModel?[]>(responseBody);
//            return data;
//        }

//        public async Task<LiquidationHistoryModel?[]> GetLiquidationHistoryAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/liquidation_history?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<LiquidationHistoryModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<AggregatedLiquidationHistoryModel?[]> GetAggregatedLiquidationHistoryAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/aggregated_liquidation_history?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<AggregatedLiquidationHistoryModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<LiquidationExchangeListModel?[]> GetLiquidationExchangeListAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/futures/liquidation_exchange_list";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<LiquidationExchangeListModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<LiquidationOrderModel?[]> GetLiquidationOrderAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/liquidation_order?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<LiquidationOrderModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<LiquidationAggregateHeatmapModel?[]> GetLiquidationAggregateHeatmapAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/liquidation_aggregate_heatmap?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<LiquidationAggregateHeatmapModel?[]>(responseBody);
//            return data;
//        }

//        public async Task<LiquidationAggregateHeatmapModel?[]> GetLiquidationAggregateHeatmapModel2Async(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/liquidation_aggregate_heatmap_model2?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<LiquidationAggregateHeatmapModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<LiquidationAggregateHeatmapModel?[]> GetLiquidationHeatmapAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/liquidation_heatmap?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<LiquidationAggregateHeatmapModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<LiquidationAggregateHeatmapModel?[]> GetLiquidationHeatmapModel2Async(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/liquidation_heatmap_model2?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<LiquidationAggregateHeatmapModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<LiquidationMapModel?[]> GetLiquidationMapAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/liquidation_map?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<LiquidationMapModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<GlobalLongShortAccountRatioModel?[]> GetGlobalLongShortAccountRatioAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/global_longshort_account_ratio?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<GlobalLongShortAccountRatioModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<TopLongShortAccountRatioModel?[]> GetTopLongShortAccountRatioAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/top_longshort_account_ratio?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<TopLongShortAccountRatioModel?[]>(responseBody);
//            return data;
//        }

//        public async Task<TopLongShortPositionRatioModel?[]> GetTopLongShortPositionRatioAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/top_longshort_position_ratio?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<TopLongShortPositionRatioModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<AggregatedTakerBuySellVolumeRatioModel?[]> GetAggregatedTakerBuySellVolumeRatioAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/aggregated_taker_buysell_volume_ratio?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<AggregatedTakerBuySellVolumeRatioModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<AggregatedTakerBuySellVolumeHistoryModel?[]> GetAggregatedTakerBuySellVolumeHistoryAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/aggregated_taker_buysell_volume_history?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<AggregatedTakerBuySellVolumeHistoryModel?[]>(responseBody);
//            return data;
//        }

//        public async Task<TakerBuySellVolumeModel?[]> GetTakerBuySellVolumeAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/taker_buysell_volume?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<TakerBuySellVolumeModel?[]>(responseBody);
//            return data;
//        }

//        public async Task<TakerBuySellVolumeExchangeListModel?[]> GetTakerBuySellVolumeExchangeListAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/futures/taker_buysell_volume_exchange_list";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<TakerBuySellVolumeExchangeListModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<CoinsMarketsModel?[]> GetCoinsMarketsAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/global/coins_markets";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<CoinsMarketsModel?[]>(responseBody);
//            return data;
//        }

//        public async Task<PairsMarketsModel?[]> GetPairsMarketsAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/global/pairs_markets";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<PairsMarketsModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<CoinsPriceChangeModel?[]> GetCoinsPriceChangeAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/global/coins_price_change";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<CoinsPriceChangeModel?[]>(responseBody);
//            return data;
//        }

//        public async Task<FuturesOrderbookHistoryModel?[]> GetFuturesOrderbookHistoryAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/orderbook_history?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<FuturesOrderbookHistoryModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<FuturesAggregatedOrderbookHistoryModel?[]> GetFuturesAggregatedOrderbookHistoryAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/aggregated_orderbook_history?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<FuturesAggregatedOrderbookHistoryModel?[]>(responseBody);
//            return data;
//        }

//        public async Task<FuturesRsiListModel?[]> GetFuturesRsiListAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/futures/rsi_list?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<FuturesRsiListModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<SpotSupportedCoinsModel?[]> GetSpotSupportedCoinsAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/spot/supported_coins";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<SpotSupportedCoinsModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<SpotSupportedExchangePairsModel?[]> GetSpotSupportedExchangePairsAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/spot/supported_exchange_pairs";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<SpotSupportedExchangePairsModel?[]>(responseBody);
//            return data;
//        }

//        public async Task<SpotTakerBuySellRatioHistoryModel?[]> GetSpotTakerBuySellRatioHistoryAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/spot/taker_buysell_ratio_history?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<SpotTakerBuySellRatioHistoryModel?[]>(responseBody);
//            return data;
//        }

//        public async Task<SpotAggregatedTakerBuySellHistoryModel?[]> GetSpotAggregatedTakerBuySellHistoryAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/spot/aggregated_taker_buysell_history?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<SpotAggregatedTakerBuySellHistoryModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<SpotOrderbookHistoryModel?[]> GetSpotOrderbookHistoryAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/spot/orderbook_history?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<SpotOrderbookHistoryModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<SpotAggregatedOrderbookHistoryModel?[]> GetSpotAggregatedOrderbookHistoryAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/spot/aggregated_orderbook_history?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<SpotAggregatedOrderbookHistoryModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<SpotCoinsMarketsModel?[]> GetSpotCoinsMarketsAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/global/spot_coins_markets";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<SpotCoinsMarketsModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<SpotPairsMarketsModel?[]> GetSpotPairsMarketsAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/global/spot_pairs_markets";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<SpotPairsMarketsModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<BitcoinBubbleIndexModel?[]> GetBitcoinBubbleIndexAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/indicator/bitcoin_bubble_index";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<BitcoinBubbleIndexModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<Ahr999Model?[]> GetAhr999Async()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/indicator/ahr999";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<Ahr999Model?[]>(responseBody);
//            return data;
//        }
//        public async Task<TwoYearMaMultiplierModel?[]> GetTwoYearMaMultiplierAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/indicator/two_year_ma_multiplier";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<TwoYearMaMultiplierModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<TwoHundredWeekMaHeatmapModel?[]> GetTwoHundredWeekMaHeatmapAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/indicator/two_hundred_week_ma_heatmap";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<TwoHundredWeekMaHeatmapModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<PuellMultipleModel?[]> GetPuellMultipleAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/indicator/puell_multiple";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<PuellMultipleModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<StockToFlowModel?[]> GetStockToFlowAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/indicator/stock_to_flow";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<StockToFlowModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<PiCycleModel?[]> GetPiCycleAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/indicator/pi_cycle";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<PiCycleModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<GoldenRatioMultiplierModel?[]> GetGoldenRatioMultiplierAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/indicator/golden_ratio_multiplier";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<GoldenRatioMultiplierModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<BitcoinProfitableDaysModel?[]> GetBitcoinProfitableDaysAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/indicator/bitcoin_profitable_days";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<BitcoinProfitableDaysModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<BitcoinRainbowChartModel?[]> GetBitcoinRainbowChartAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/indicator/bitcoin_rainbow_chart";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<BitcoinRainbowChartModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<CryptoFearGreedIndexModel?[]> GetCryptoFearGreedIndexAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/indicator/cryptofear_greedindex";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<CryptoFearGreedIndexModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<GrayscaleHoldingListModel?[]> GetGrayscaleHoldingListAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/grayscale/holding_list";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<GrayscaleHoldingListModel?[]>(responseBody);
//            return data;
//        }

//        public async Task<GrayscalePremiumHistoryModel?[]> GetGrayscalePremiumHistoryAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/grayscale/premium_history";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<GrayscalePremiumHistoryModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<BorrowInterestRateModel?[]> GetBorrowInterestRateAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/borrow_interest_rate";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<BorrowInterestRateModel?[]>(responseBody);
//            return data;
//        }

//        public async Task<OptionsInfoModel?[]> GetOptionsInfoAsync(string symbol)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/options/info?symbol={symbol}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<OptionsInfoModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<ExchangeOpenInterestHistoryModel?[]> GetExchangeOpenInterestHistoryAsync(string exchange)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/options/exchange_open_interest_history?exchange={exchange}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<ExchangeOpenInterestHistoryModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<ExchangeVolumeHistoryModel?[]> GetExchangeVolumeHistoryAsync(string exchange)
//        {
//            string url = $"https://api.coinglass.com/api/pro/v1/options/exchange_volume_history?exchange={exchange}";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<ExchangeVolumeHistoryModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<BitcoinEtfModel?[]> GetBitcoinEtfsAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/etf/bitcoin_etfs";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<BitcoinEtfModel?[]>(responseBody);
//            return data;
//        }

//        public async Task<HongKongBitcoinEtfFlowHistoryModel?[]> GetHongKongBitcoinEtfFlowHistoryAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/etf/hong_kong_bitcoin_etf_flow_history";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<HongKongBitcoinEtfFlowHistoryModel?[]>(responseBody);
//            return data;
//        }
//        public async Task<EtfFlowsHistoryModel?[]> GetEtfFlowsHistoryAsync()
//        {
//            string url = "https://api.coinglass.com/api/pro/v1/etf/flows_history";
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//            HttpResponseMessage response = await client.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            string responseBody = await response.Content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject<EtfFlowsHistoryModel?[]>(responseBody);
//            return data;
//        }


//    }
//}
