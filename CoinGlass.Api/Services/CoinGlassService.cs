using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CoinGlassApi.Models;

namespace CoinGlassApi.Services
{



    public class CoinGlassService
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly string apiKey;
        private readonly string baseUrl = "https://api.coinglass.com/api/pro/v1/futures";

        public CoinGlassService(string apiKey)
        {
            this.apiKey = apiKey;
        }

        private async Task<T?> GetAsync<T>(string route)
        {
            string url = $"{baseUrl}/{route}";
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<T?>(responseBody);
            return data;
        }

        public async Task<LiquidationHeatmapDataModel[]?> GetLiquidationHeatmapAsync()
        {
            return await GetAsync<LiquidationHeatmapDataModel[]>("liquidation_heatmap");
        }

        public async Task<CoinInfoModel[]?> GetCoinsAsync()
        {
            return await GetAsync<CoinInfoModel[]>("coins");
        }

        public async Task<InstrumentInfoModel[]?> GetInstrumentsAsync()
        {
            return await GetAsync<InstrumentInfoModel[]>("instruments");
        }

        public async Task<OhlcAggregatedHistoryModel[]?> GetOhlcAggregatedHistoryAsync(string symbol)
        {
            return await GetAsync<OhlcAggregatedHistoryModel[]>($"ohlc_aggregated_history?symbol={symbol}");
        }

        public async Task<OhlcAggregatedHistoryModel[]?> GetOhlcAggregatedStablecoinMarginHistoryAsync(string symbol)
        {
            return await GetAsync<OhlcAggregatedHistoryModel[]>($"ohlc_aggregated_stablecoin_margin_history?symbol={symbol}");
        }

        public async Task<OhlcAggregatedHistoryModel[]?> GetOhlcAggregatedCoinMarginHistoryAsync(string symbol)
        {
            return await GetAsync<OhlcAggregatedHistoryModel[]>($"ohlc_aggregated_coin_margin_history?symbol={symbol}");
        }

        public async Task<ExchangeInfoModel[]?> GetExchangeListAsync()
        {
            return await GetAsync<ExchangeInfoModel[]>("exchange_list");
        }

        public async Task<ExchangeHistoryChartModel[]?> GetExchangeHistoryChartAsync(string exchange)
        {
            return await GetAsync<ExchangeHistoryChartModel[]>($"exchange_history_chart?exchange={exchange}");
        }
      
        public async Task<FrOhlcHistoryModel[]?> GetFrOhlcHistoryAsync(string symbol)
        {
            return await GetAsync<FrOhlcHistoryModel[]>($"fr_ohlc_history?symbol={symbol}");
        }

        public async Task<OiWeightOhlcHistoryModel[]?> GetOiWeightOhlcHistoryAsync(string symbol)
        {
            return await GetAsync<OiWeightOhlcHistoryModel[]>($"oi_weight_ohlc_history?symbol={symbol}");
        }

        public async Task<VolWeightOhlcHistoryModel[]?> GetVolWeightOhlcHistoryAsync(string symbol)
        {
            return await GetAsync<VolWeightOhlcHistoryModel[]>($"vol_weight_ohlc_history?symbol={symbol}");
        }

        public async Task<FrExchangeInfoModel[]?> GetFrExchangeListAsync()
        {
            return await GetAsync<FrExchangeInfoModel[]>("fr_exchange_list");
        }

        public async Task<LiquidationHistoryModel[]?> GetLiquidationHistoryAsync(string symbol)
        {
            return await GetAsync<LiquidationHistoryModel[]>($"liquidation_history?symbol={symbol}");
        }

        public async Task<AggregatedLiquidationHistoryModel[]?> GetAggregatedLiquidationHistoryAsync(string symbol)
        {
            return await GetAsync<AggregatedLiquidationHistoryModel[]>($"aggregated_liquidation_history?symbol={symbol}");
        }

        public async Task<LiquidationExchangeListModel[]?> GetLiquidationExchangeListAsync()
        {
            return await GetAsync<LiquidationExchangeListModel[]>("liquidation_exchange_list");
        }

        public async Task<LiquidationOrderModel[]?> GetLiquidationOrderAsync(string symbol)
        {
            return await GetAsync<LiquidationOrderModel[]>($"liquidation_order?symbol={symbol}");
        }

        public async Task<LiquidationAggregateHeatmapModel[]?> GetLiquidationAggregateHeatmapAsync(string symbol)
        {
            return await GetAsync<LiquidationAggregateHeatmapModel[]>($"liquidation_aggregate_heatmap?symbol={symbol}");
        }

        public async Task<LiquidationAggregateHeatmapModel[]?> GetLiquidationAggregateHeatmapModel2Async(string symbol)
        {
            return await GetAsync<LiquidationAggregateHeatmapModel[]>($"liquidation_aggregate_heatmap_model2?symbol={symbol}");
        }

        public async Task<LiquidationAggregateHeatmapModel[]?> GetLiquidationHeatmapAsync(string symbol)
        {
            return await GetAsync<LiquidationAggregateHeatmapModel[]>($"liquidation_heatmap?symbol={symbol}");
        }

        public async Task<LiquidationAggregateHeatmapModel[]?> GetLiquidationHeatmapModel2Async(string symbol)
        {
            return await GetAsync<LiquidationAggregateHeatmapModel[]>($"liquidation_heatmap_model2?symbol={symbol}");
        }

        public async Task<LiquidationMapModel[]?> GetLiquidationMapAsync(string symbol)
        {
            return await GetAsync<LiquidationMapModel[]>($"liquidation_map?symbol={symbol}");
        }

        public async Task<GlobalLongShortAccountRatioModel[]?> GetGlobalLongShortAccountRatioAsync(string symbol)
        {
            return await GetAsync<GlobalLongShortAccountRatioModel[]>($"global_long_short_account_ratio?symbol={symbol}");
        }

        public async Task<TopLongShortAccountRatioModel[]?> GetTopLongShortAccountRatioAsync(string symbol)
        {
            return await GetAsync<TopLongShortAccountRatioModel[]>($"top_long_short_account_ratio?symbol={symbol}");
        }

        public async Task<TopLongShortPositionRatioModel[]?> GetTopLongShortPositionRatioAsync(string symbol)
        {
            return await GetAsync<TopLongShortPositionRatioModel[]>($"top_long_short_position_ratio?symbol={symbol}");
        }

        public async Task<AggregatedTakerBuySellVolumeRatioModel[]?> GetAggregatedTakerBuySellVolumeRatioAsync(string symbol)
        {
            return await GetAsync<AggregatedTakerBuySellVolumeRatioModel[]>($"aggregated_taker_buy_sell_volume_ratio?symbol={symbol}");
        }

        public async Task<AggregatedTakerBuySellVolumeHistoryModel[]?> GetAggregatedTakerBuySellVolumeHistoryAsync(string symbol)
        {
            return await GetAsync<AggregatedTakerBuySellVolumeHistoryModel[]>($"aggregated_taker_buy_sell_volume_history?symbol={symbol}");
        }

        public async Task<TakerBuySellVolumeModel[]?> GetTakerBuySellVolumeAsync(string symbol)
        {
            return await GetAsync<TakerBuySellVolumeModel[]>($"taker_buy_sell_volume?symbol={symbol}");
        }

        public async Task<TakerBuySellVolumeExchangeListModel[]?> GetTakerBuySellVolumeExchangeListAsync()
        {
            return await GetAsync<TakerBuySellVolumeExchangeListModel[]>("taker_buy_sell_volume_exchange_list");
        }

        public async Task<CoinsMarketsModel[]?> GetCoinsMarketsAsync()
        {
            return await GetAsync<CoinsMarketsModel[]>("coins_markets");
        }

        public async Task<PairsMarketsModel[]?> GetPairsMarketsAsync()
        {
            return await GetAsync<PairsMarketsModel[]>("pairs_markets");
        }

        public async Task<CoinsPriceChangeModel[]?> GetCoinsPriceChangeAsync()
        {
            return await GetAsync<CoinsPriceChangeModel[]>("coins_price_change");
        }

        public async Task<FuturesOrderbookHistoryModel[]?> GetFuturesOrderbookHistoryAsync(string symbol)
        {
            return await GetAsync<FuturesOrderbookHistoryModel[]>($"futures_orderbook_history?symbol={symbol}");
        }

        public async Task<FuturesAggregatedOrderbookHistoryModel[]?> GetFuturesAggregatedOrderbookHistoryAsync(string symbol)
        {
            return await GetAsync<FuturesAggregatedOrderbookHistoryModel[]>($"futures_aggregated_orderbook_history?symbol={symbol}");
        }

        public async Task<FuturesRsiListModel[]?> GetFuturesRsiListAsync(string symbol)
        {
            return await GetAsync<FuturesRsiListModel[]>($"futures_rsi_list?symbol={symbol}");
        }

        public async Task<SpotSupportedCoinsModel[]?> GetSpotSupportedCoinsAsync()
        {
            return await GetAsync<SpotSupportedCoinsModel[]>("spot_supported_coins");
        }

        public async Task<SpotSupportedExchangePairsModel[]?> GetSpotSupportedExchangePairsAsync()
        {
            return await GetAsync<SpotSupportedExchangePairsModel[]>("spot_supported_exchange_pairs");
        }

        public async Task<SpotTakerBuySellRatioHistoryModel[]?> GetSpotTakerBuySellRatioHistoryAsync(string symbol)
        {
            return await GetAsync<SpotTakerBuySellRatioHistoryModel[]>($"spot_taker_buy_sell_ratio_history?symbol={symbol}");
        }

        public async Task<SpotAggregatedTakerBuySellHistoryModel[]?> GetSpotAggregatedTakerBuySellHistoryAsync(string symbol)
        {
            return await GetAsync<SpotAggregatedTakerBuySellHistoryModel[]>($"spot_aggregated_taker_buy_sell_history?symbol={symbol}");
        }

        public async Task<SpotOrderbookHistoryModel[]?> GetSpotOrderbookHistoryAsync(string symbol)
        {
            return await GetAsync<SpotOrderbookHistoryModel[]>($"spot_orderbook_history?symbol={symbol}");
        }

        public async Task<SpotAggregatedOrderbookHistoryModel[]?> GetSpotAggregatedOrderbookHistoryAsync(string symbol)
        {
            return await GetAsync<SpotAggregatedOrderbookHistoryModel[]>($"spot_aggregated_orderbook_history?symbol={symbol}");
        }

        public async Task<SpotCoinsMarketsModel[]?> GetSpotCoinsMarketsAsync()
        {
            return await GetAsync<SpotCoinsMarketsModel[]>("spot_coins_markets");
        }

        public async Task<SpotPairsMarketsModel[]?> GetSpotPairsMarketsAsync()
        {
            return await GetAsync<SpotPairsMarketsModel[]>("spot_pairs_markets");
        }

        public async Task<BitcoinBubbleIndexModel[]?> GetBitcoinBubbleIndexAsync()
        {
            return await GetAsync<BitcoinBubbleIndexModel[]>("bitcoin_bubble_index");
        }

        public async Task<Ahr999Model[]?> GetAhr999Async()
        {
            return await GetAsync<Ahr999Model[]>("ahr999");
        }

        public async Task<TwoYearMaMultiplierModel[]?> GetTwoYearMaMultiplierAsync()
        {
            return await GetAsync<TwoYearMaMultiplierModel[]>("two_year_ma_multiplier");
        }

        public async Task<TwoHundredWeekMaHeatmapModel[]?> GetTwoHundredWeekMaHeatmapAsync()
        {
            return await GetAsync<TwoHundredWeekMaHeatmapModel[]>("two_hundred_week_ma_heatmap");
        }

        public async Task<PuellMultipleModel[]?> GetPuellMultipleAsync()
        {
            return await GetAsync<PuellMultipleModel[]>("puell_multiple");
        }

        public async Task<StockToFlowModel[]?> GetStockToFlowAsync()
        {
            return await GetAsync<StockToFlowModel[]>("stock_to_flow");
        }

        public async Task<PiCycleModel[]?> GetPiCycleAsync()
        {
            return await GetAsync<PiCycleModel[]>("pi_cycle");
        }

        public async Task<GoldenRatioMultiplierModel[]?> GetGoldenRatioMultiplierAsync()
        {
            return await GetAsync<GoldenRatioMultiplierModel[]>("golden_ratio_multiplier");
        }

        public async Task<BitcoinProfitableDaysModel[]?> GetBitcoinProfitableDaysAsync()
        {
            return await GetAsync<BitcoinProfitableDaysModel[]>("bitcoin_profitable_days");
        }

        public async Task<BitcoinRainbowChartModel[]?> GetBitcoinRainbowChartAsync()
        {
            return await GetAsync<BitcoinRainbowChartModel[]>("bitcoin_rainbow_chart");
        }

        public async Task<CryptoFearGreedIndexModel[]?> GetCryptoFearGreedIndexAsync()
        {
            return await GetAsync<CryptoFearGreedIndexModel[]>("crypto_fear_greed_index");
        }

        public async Task<GrayscaleHoldingListModel[]?> GetGrayscaleHoldingListAsync()
        {
            return await GetAsync<GrayscaleHoldingListModel[]>("grayscale_holding_list");
        }

        public async Task<GrayscalePremiumHistoryModel[]?> GetGrayscalePremiumHistoryAsync()
        {
            return await GetAsync<GrayscalePremiumHistoryModel[]>("grayscale_premium_history");
        }

        public async Task<BorrowInterestRateModel[]?> GetBorrowInterestRateAsync()
        {
            return await GetAsync<BorrowInterestRateModel[]>("borrow_interest_rate");
        }

        public async Task<OptionsInfoModel[]?> GetOptionsInfoAsync(string symbol)
        {
            return await GetAsync<OptionsInfoModel[]>($"options_info?symbol={symbol}");
        }

        public async Task<ExchangeOpenInterestHistoryModel[]?> GetExchangeOpenInterestHistoryAsync(string exchange)
        {
            return await GetAsync<ExchangeOpenInterestHistoryModel[]>($"exchange_open_interest_history?exchange={exchange}");
        }

        public async Task<ExchangeVolumeHistoryModel[]?> GetExchangeVolumeHistoryAsync(string exchange)
        {
            return await GetAsync<ExchangeVolumeHistoryModel[]>($"exchange_volume_history?exchange={exchange}");
        }

        public async Task<BitcoinEtfModel[]?> GetBitcoinEtfsAsync()
        {
            return await GetAsync<BitcoinEtfModel[]>("bitcoin_etfs");
        }

        public async Task<HongKongBitcoinEtfFlowHistoryModel[]?> GetHongKongBitcoinEtfFlowHistoryAsync()
        {
            return await GetAsync<HongKongBitcoinEtfFlowHistoryModel[]>("hong_kong_bitcoin_etf_flow_history");
        }

        public async Task<EtfFlowsHistoryModel[]?> GetEtfFlowsHistoryAsync()
        {
            return await GetAsync<EtfFlowsHistoryModel[]>("etf_flows_history");
        }



    }
}
