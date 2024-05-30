using System;
using System.Threading.Tasks;
using CoinGlassApi.Services;

class Program
{
    static async Task Main(string[] args)
    {
        string apiKey = "YOUR_API_KEY";
        var service = new CoinGlassService(apiKey);

        try
        {
            // Teste do endpoint Liquidation Heatmap
            var heatmapData = await service.GetLiquidationHeatmapAsync();
            foreach (var data in heatmapData)
            {
                Console.WriteLine($"Symbol: {data.Symbol}, Price: {data.Price}, Longs: {data.Longs}, Shorts: {data.Shorts}");
            }

            // Teste do endpoint Coins
            var coins = await service.GetCoinsAsync();
            foreach (var coin in coins)
            {
                Console.WriteLine($"Symbol: {coin.Symbol}, Name: {coin.Name}, Price: {coin.Price}, MarketCap: {coin.MarketCap}");
            }

            // Teste do endpoint Instruments
            var instruments = await service.GetInstrumentsAsync();
            foreach (var instrument in instruments)
            {
                Console.WriteLine($"Symbol: {instrument.Symbol}, InstrumentName: {instrument.InstrumentName}, Type: {instrument.Type}, Market: {instrument.Market}");
            }

            // Teste do endpoint OHLC Aggregated Stablecoin Margin History
            var stablecoinSymbol = "ETHUSDT"; // Substitua pelo símbolo desejado
            var ohlcStablecoinData = await service.GetOhlcAggregatedStablecoinMarginHistoryAsync(stablecoinSymbol);
            foreach (var data in ohlcStablecoinData)
            {
                Console.WriteLine($"Timestamp: {data.Timestamp}, Open: {data.Open}, High: {data.High}, Low: {data.Low}, Close: {data.Close}, Volume: {data.Volume}");
            }

            // Teste do endpoint OHLC Aggregated Coin Margin History
            var coinMarginSymbol = "BTCUSD"; // Substitua pelo símbolo desejado
            var ohlcCoinMarginData = await service.GetOhlcAggregatedCoinMarginHistoryAsync(coinMarginSymbol);
            foreach (var data in ohlcCoinMarginData)
            {
                Console.WriteLine($"Timestamp: {data.Timestamp}, Open: {data.Open}, High: {data.High}, Low: {data.Low}, Close: {data.Close}, Volume: {data.Volume}");
            }

            // Teste do endpoint Exchange List
            var exchangeList = await service.GetExchangeListAsync();
            foreach (var exchange in exchangeList)
            {
                Console.WriteLine($"Exchange Name: {exchange.ExchangeName}, Volume: {exchange.Volume}");
            }
            // Teste do endpoint Exchange History Chart
            var exchangeHistory = await service.GetExchangeHistoryChartAsync("Binance"); // Substitua pelo nome da exchange desejada
            foreach (var data in exchangeHistory)
            {
                Console.WriteLine($"Timestamp: {data.Timestamp}, Open Interest: {data.OpenInterest}");
            }

            // Teste do endpoint FR OHLC History
            var frOhlcHistory = await service.GetFrOhlcHistoryAsync("BTCUSDT"); // Substitua pelo símbolo desejado
            foreach (var data in frOhlcHistory)
            {
                Console.WriteLine($"Timestamp: {data.Timestamp}, Funding Rate: {data.FundingRate}");
            }
            // Teste do endpoint OI Weight OHLC History
            var oiWeightOhlcHistory = await service.GetOiWeightOhlcHistoryAsync("ETHUSDT"); // Substitua pelo símbolo desejado
            foreach (var data in oiWeightOhlcHistory)
            {
                Console.WriteLine($"Timestamp: {data.Timestamp}, OI Weight: {data.OiWeight}");
            }
            // Teste do endpoint Volume Weight OHLC History
            var volWeightOhlcHistory = await service.GetVolWeightOhlcHistoryAsync("LTCUSDT"); // Substitua pelo símbolo desejado
            foreach (var data in volWeightOhlcHistory)
            {
                Console.WriteLine($"Timestamp: {data.Timestamp}, Volume Weight: {data.VolWeight}");
            }
            // Teste do endpoint FR Exchange List
            var frExchangeList = await service.GetFrExchangeListAsync();
            foreach (var exchange in frExchangeList)
            {
                Console.WriteLine($"Exchange Name: {exchange.ExchangeName}, Funding Rate: {exchange.FundingRate}");
            }
            // Teste do endpoint Liquidation History
            var liquidationHistory = await service.GetLiquidationHistoryAsync("BTCUSDT"); // Substitua pelo símbolo desejado
            foreach (var data in liquidationHistory)
            {
                Console.WriteLine($"Timestamp: {data.Timestamp}, Symbol: {data.Symbol}, Side: {data.Side}, Price: {data.Price}, Quantity: {data.Quantity}");
            }

            // Teste do endpoint Aggregated Liquidation History
            var aggregatedLiquidationHistory = await service.GetAggregatedLiquidationHistoryAsync("ETHUSDT"); // Substitua pelo símbolo desejado
            foreach (var data in aggregatedLiquidationHistory)
            {
                Console.WriteLine($"Timestamp: {data.Timestamp}, Total Liquidation: {data.TotalLiquidation}");
            }
            // Teste do endpoint Liquidation Exchange List
            var liquidationExchangeList = await service.GetLiquidationExchangeListAsync();
            foreach (var exchange in liquidationExchangeList)
            {
                Console.WriteLine($"Exchange Name: {exchange.ExchangeName}, Total Liquidation: {exchange.TotalLiquidation}");
            }
            // Teste do endpoint Liquidation Order
            var liquidationOrder = await service.GetLiquidationOrderAsync("BTCUSDT"); // Substitua pelo símbolo desejado
            foreach (var order in liquidationOrder)
            {
                Console.WriteLine($"Symbol: {order.Symbol}, Price: {order.Price}, Quantity: {order.Quantity}, Side: {order.Side}, Timestamp: {order.Timestamp}");
            }
            // Teste do endpoint Liquidation Aggregate Heatmap
            var liquidationAggregateHeatmap = await service.GetLiquidationAggregateHeatmapAsync("ETHUSDT"); // Substitua pelo símbolo desejado
            foreach (var heatmap in liquidationAggregateHeatmap)
            {
                Console.WriteLine($"Price: {heatmap.Price}, Quantity: {heatmap.Quantity}, Side: {heatmap.Side}");
            }
            // Teste do endpoint Liquidation Aggregate Heatmap Model 2
            var liquidationAggregateHeatmapModel2 = await service.GetLiquidationAggregateHeatmapModel2Async("LTCUSDT"); // Substitua pelo símbolo desejado
            foreach (var heatmap in liquidationAggregateHeatmapModel2)
            {
                Console.WriteLine($"Price: {heatmap.Price}, Quantity: {heatmap.Quantity}, Side: {heatmap.Side}");
            }
            // Teste do endpoint Liquidation Heatmap
            var liquidationHeatmap = await service.GetLiquidationHeatmapAsync("XRPUSDT"); // Substitua pelo símbolo desejado
            foreach (var heatmap in liquidationHeatmap)
            {
                Console.WriteLine($"Price: {heatmap.Price}, Quantity: {heatmap.Quantity}, Side: {heatmap.Side}");
            }
            // Teste do endpoint Liquidation Map
            var liquidationMap = await service.GetLiquidationMapAsync("DOGEUSDT"); // Substitua pelo símbolo desejado
            foreach (var map in liquidationMap)
            {
                Console.WriteLine($"Price: {map.Price}, Longs: {map.Longs}, Shorts: {map.Shorts}, Total: {map.Total}");
            }
            // Teste do endpoint Global Long/Short Account Ratio
            var globalLongShortAccountRatio = await service.GetGlobalLongShortAccountRatioAsync("ADAUSDT"); // Substitua pelo símbolo desejado
            foreach (var ratio in globalLongShortAccountRatio)
            {
                Console.WriteLine($"Timestamp: {ratio.Timestamp}, Long Account: {ratio.LongAccount}, Short Account: {ratio.ShortAccount}");
            }
            // Teste do endpoint Top Long/Short Account Ratio
            var topLongShortAccountRatio = await service.GetTopLongShortAccountRatioAsync("SOLUSDT"); // Substitua pelo símbolo desejado
            foreach (var ratio in topLongShortAccountRatio)
            {
                Console.WriteLine($"Timestamp: {ratio.Timestamp}, Long Account: {ratio.LongAccount}, Short Account: {ratio.ShortAccount}");
            }
            // Teste do endpoint Top Long/Short Position Ratio
            var topLongShortPositionRatio = await service.GetTopLongShortPositionRatioAsync("DOTUSDT"); // Substitua pelo símbolo desejado
            foreach (var ratio in topLongShortPositionRatio)
            {
                Console.WriteLine($"Timestamp: {ratio.Timestamp}, Long Position: {ratio.LongPosition}, Short Position: {ratio.ShortPosition}");
            }
            // Teste do endpoint Aggregated Taker Buy/Sell Volume Ratio
            var aggregatedTakerBuySellVolumeRatio = await service.GetAggregatedTakerBuySellVolumeRatioAsync("UNIUSDT"); // Substitua pelo símbolo desejado
            foreach (var ratio in aggregatedTakerBuySellVolumeRatio)
            {
                Console.WriteLine($"Timestamp: {ratio.Timestamp}, Buy Volume: {ratio.BuyVolume}, Sell Volume: {ratio.SellVolume}");
            }
            // Teste do endpoint Aggregated Taker Buy/Sell Volume History
            var aggregatedTakerBuySellVolumeHistory = await service.GetAggregatedTakerBuySellVolumeHistoryAsync("LINKUSDT"); // Substitua pelo símbolo desejado
            foreach (var history in aggregatedTakerBuySellVolumeHistory)
            {
                Console.WriteLine($"Timestamp: {history.Timestamp}, Buy Volume: {history.BuyVolume}, Sell Volume: {history.SellVolume}");
            }
            // Teste do endpoint Taker Buy/Sell Volume
            var takerBuySellVolume = await service.GetTakerBuySellVolumeAsync("BNBUSDT"); // Substitua pelo símbolo desejado
            foreach (var volume in takerBuySellVolume)
            {
                Console.WriteLine($"Timestamp: {volume.Timestamp}, Buy Volume: {volume.BuyVolume}, Sell Volume: {volume.SellVolume}");
            }
            // Teste do endpoint Taker Buy/Sell Volume Exchange List
            var takerBuySellVolumeExchangeList = await service.GetTakerBuySellVolumeExchangeListAsync();
            foreach (var exchange in takerBuySellVolumeExchangeList)
            {
                Console.WriteLine($"Exchange Name: {exchange.ExchangeName}, Buy Volume: {exchange.BuyVolume}, Sell Volume: {exchange.SellVolume}");
            }
            // Teste do endpoint Coins Markets
            var coinsMarkets = await service.GetCoinsMarketsAsync();
            foreach (var market in coinsMarkets)
            {
                Console.WriteLine($"Symbol: {market.Symbol}, Market: {market.Market}, Price: {market.Price}, Volume: {market.Volume}");
            }
            // Teste do endpoint Pairs Markets
            var pairsMarkets = await service.GetPairsMarketsAsync();
            foreach (var market in pairsMarkets)
            {
                Console.WriteLine($"Pair: {market.Pair}, Market: {market.Market}, Price: {market.Price}, Volume: {market.Volume}");
            }
            // Teste do endpoint Coins Price Change
            var coinsPriceChange = await service.GetCoinsPriceChangeAsync();
            foreach (var change in coinsPriceChange)
            {
                Console.WriteLine($"Symbol: {change.Symbol}, Price Change: {change.PriceChange}");
            }
            // Teste do endpoint Futures Orderbook History
            var futuresOrderbookHistory = await service.GetFuturesOrderbookHistoryAsync("BTCUSDT"); // Substitua pelo símbolo desejado
            foreach (var orderbook in futuresOrderbookHistory)
            {
                Console.WriteLine($"Timestamp: {orderbook.Timestamp}, Buy Orders: {orderbook.BuyOrders}, Sell Orders: {orderbook.SellOrders}");
            }
            // Teste do endpoint Futures Aggregated Orderbook History
            var futuresAggregatedOrderbookHistory = await service.GetFuturesAggregatedOrderbookHistoryAsync("ETHUSDT"); // Substitua pelo símbolo desejado
            foreach (var orderbook in futuresAggregatedOrderbookHistory)
            {
                Console.WriteLine($"Timestamp: {orderbook.Timestamp}, Buy Orders: {orderbook.BuyOrders}, Sell Orders: {orderbook.SellOrders}");
            }
            // Teste do endpoint Futures RSI List
            var futuresRsiList = await service.GetFuturesRsiListAsync("XRPUSDT"); // Substitua pelo símbolo desejado
            foreach (var rsi in futuresRsiList)
            {
                Console.WriteLine($"Timestamp: {rsi.Timestamp}, RSI: {rsi.Rsi}");
            }
            // Teste do endpoint Spot Supported Coins
            var spotSupportedCoins = await service.GetSpotSupportedCoinsAsync();
            foreach (var coin in spotSupportedCoins)
            {
                Console.WriteLine($"Symbol: {coin.Symbol}, Name: {coin.Name}");
            }
            // Teste do endpoint Spot Supported Exchange Pairs
            var spotSupportedExchangePairs = await service.GetSpotSupportedExchangePairsAsync();
            foreach (var pair in spotSupportedExchangePairs)
            {
                Console.WriteLine($"Pair: {pair.Pair}, Exchange: {pair.Exchange}");
            }
            // Teste do endpoint Spot Taker Buy/Sell Ratio History
            var spotTakerBuySellRatioHistory = await service.GetSpotTakerBuySellRatioHistoryAsync("BTCUSDT"); // Substitua pelo símbolo desejado
            foreach (var ratio in spotTakerBuySellRatioHistory)
            {
                Console.WriteLine($"Timestamp: {ratio.Timestamp}, Buy Ratio: {ratio.BuyRatio}, Sell Ratio: {ratio.SellRatio}");
            }

            // Teste do endpoint Spot Aggregated Taker Buy/Sell History
            var spotAggregatedTakerBuySellHistory = await service.GetSpotAggregatedTakerBuySellHistoryAsync("ETHUSDT"); // Substitua pelo símbolo desejado
            foreach (var volume in spotAggregatedTakerBuySellHistory)
            {
                Console.WriteLine($"Timestamp: {volume.Timestamp}, Buy Volume: {volume.BuyVolume}, Sell Volume: {volume.SellVolume}");
            }
            // Teste do endpoint Spot Orderbook History
            var spotOrderbookHistory = await service.GetSpotOrderbookHistoryAsync("BTCUSDT"); // Substitua pelo símbolo desejado
            foreach (var orderbook in spotOrderbookHistory)
            {
                Console.WriteLine($"Timestamp: {orderbook.Timestamp}, Buy Orders: {orderbook.BuyOrders}, Sell Orders: {orderbook.SellOrders}");
            }
            // Teste do endpoint Spot Aggregated Orderbook History
            var spotAggregatedOrderbookHistory = await service.GetSpotAggregatedOrderbookHistoryAsync("ETHUSDT"); // Substitua pelo símbolo desejado
            foreach (var orderbook in spotAggregatedOrderbookHistory)
            {
                Console.WriteLine($"Timestamp: {orderbook.Timestamp}, Buy Orders: {orderbook.BuyOrders}, Sell Orders: {orderbook.SellOrders}");
            }
            // Teste do endpoint Spot Coins Markets
            var spotCoinsMarkets = await service.GetSpotCoinsMarketsAsync();
            foreach (var market in spotCoinsMarkets)
            {
                Console.WriteLine($"Symbol: {market.Symbol}, Market: {market.Market}, Price: {market.Price}, Volume: {market.Volume}");
            }
            // Teste do endpoint Spot Pairs Markets
            var spotPairsMarkets = await service.GetSpotPairsMarketsAsync();
            foreach (var market in spotPairsMarkets)
            {
                Console.WriteLine($"Pair: {market.Pair}, Market: {market.Market}, Price: {market.Price}, Volume: {market.Volume}");
            }
            // Teste do endpoint Bitcoin Bubble Index
            var bitcoinBubbleIndex = await service.GetBitcoinBubbleIndexAsync();
            foreach (var index in bitcoinBubbleIndex)
            {
                Console.WriteLine($"Timestamp: {index.Timestamp}, Bubble Index: {index.BubbleIndex}");
            }
            // Teste do endpoint AHR999
            var ahr999 = await service.GetAhr999Async();
            foreach (var index in ahr999)
            {
                Console.WriteLine($"Timestamp: {index.Timestamp}, AHR999: {index.Ahr999}");
            }
            // Teste do endpoint Two Year MA Multiplier
            var twoYearMaMultiplier = await service.GetTwoYearMaMultiplierAsync();
            foreach (var ma in twoYearMaMultiplier)
            {
                Console.WriteLine($"Timestamp: {ma.Timestamp}, MA Multiplier: {ma.MaMultiplier}");
            }
            // Teste do endpoint 200 Week Moving Average Heatmap
            var twoHundredWeekMaHeatmap = await service.GetTwoHundredWeekMaHeatmapAsync();
            foreach (var heatmap in twoHundredWeekMaHeatmap)
            {
                Console.WriteLine($"Timestamp: {heatmap.Timestamp}, Heatmap Value: {heatmap.HeatmapValue}");
            }
            // Teste do endpoint Puell Multiple
            var puellMultiple = await service.GetPuellMultipleAsync();
            foreach (var pm in puellMultiple)
            {
                Console.WriteLine($"Timestamp: {pm.Timestamp}, Puell Multiple: {pm.PuellMultiple}");
            }
            // Teste do endpoint Stock-to-Flow
            var stockToFlow = await service.GetStockToFlowAsync();
            foreach (var sf in stockToFlow)
            {
                Console.WriteLine($"Timestamp: {sf.Timestamp}, Stock-to-Flow: {sf.StockToFlow}");
            }
            // Teste do endpoint PI Cycle
            var piCycle = await service.GetPiCycleAsync();
            foreach (var pc in piCycle)
            {
                Console.WriteLine($"Timestamp: {pc.Timestamp}, PI Cycle: {pc.PiCycle}");
            }
            // Teste do endpoint Golden Ratio Multiplier
            var goldenRatioMultiplier = await service.GetGoldenRatioMultiplierAsync();
            foreach (var gr in goldenRatioMultiplier)
            {
                Console.WriteLine($"Timestamp: {gr.Timestamp}, Golden Ratio: {gr.GoldenRatio}");
            }
            // Teste do endpoint Bitcoin Profitable Days
            var bitcoinProfitableDays = await service.GetBitcoinProfitableDaysAsync();
            foreach (var day in bitcoinProfitableDays)
            {
                Console.WriteLine($"Timestamp: {day.Timestamp}, Profitable Days: {day.ProfitableDays}");
            }
            // Teste do endpoint Bitcoin Rainbow Chart
            var bitcoinRainbowChart = await service.GetBitcoinRainbowChartAsync();
            foreach (var rainbow in bitcoinRainbowChart)
            {
                Console.WriteLine($"Timestamp: {rainbow.Timestamp}, Price: {rainbow.Price}, Color: {rainbow.Color}");
            }
            // Teste do endpoint Crypto Fear & Greed Index
            var cryptoFearGreedIndex = await service.GetCryptoFearGreedIndexAsync();
            foreach (var index in cryptoFearGreedIndex)
            {
                Console.WriteLine($"Timestamp: {index.Timestamp}, Fear & Greed Index: {index.FearGreedIndex}");
            }
            // Teste do endpoint Grayscale Holding List
            var grayscaleHoldingList = await service.GetGrayscaleHoldingListAsync();
            foreach (var holding in grayscaleHoldingList)
            {
                Console.WriteLine($"Symbol: {holding.Symbol}, Holding: {holding.Holding}");
            }
            // Teste do endpoint Grayscale Premium History
            var grayscalePremiumHistory = await service.GetGrayscalePremiumHistoryAsync();
            foreach (var premium in grayscalePremiumHistory)
            {
                Console.WriteLine($"Timestamp: {premium.Timestamp}, Premium: {premium.Premium}");
            }
            // Teste do endpoint Borrow Interest Rate
            var borrowInterestRate = await service.GetBorrowInterestRateAsync();
            foreach (var rate in borrowInterestRate)
            {
                Console.WriteLine($"Timestamp: {rate.Timestamp}, Interest Rate: {rate.InterestRate}");
            }
            // Teste do endpoint Options Info
            var optionsInfo = await service.GetOptionsInfoAsync("BTCUSDT"); // Substitua pelo símbolo desejado
            foreach (var info in optionsInfo)
            {
                Console.WriteLine($"Symbol: {info.Symbol}, Expiry Date: {info.ExpiryDate}, Strike Price: {info.StrikePrice}, Option Type: {info.OptionType}");
            }
            // Teste do endpoint Exchange Open Interest History
            var exchangeOpenInterestHistory = await service.GetExchangeOpenInterestHistoryAsync("Deribit"); // Substitua pelo nome da exchange desejada
            foreach (var history in exchangeOpenInterestHistory)
            {
                Console.WriteLine($"Timestamp: {history.Timestamp}, Open Interest: {history.OpenInterest}");
            }
            // Teste do endpoint Exchange Volume History
            var exchangeVolumeHistory = await service.GetExchangeVolumeHistoryAsync("Deribit"); // Substitua pelo nome da exchange desejada
            foreach (var volume in exchangeVolumeHistory)
            {
                Console.WriteLine($"Timestamp: {volume.Timestamp}, Volume: {volume.Volume}");
            }
            // Teste do endpoint Bitcoin ETFs
            var bitcoinEtfs = await service.GetBitcoinEtfsAsync();
            foreach (var etf in bitcoinEtfs)
            {
                Console.WriteLine($"Timestamp: {etf.Timestamp}, ETF Name: {etf.EtfName}, Holdings: {etf.Holdings}");
            }
            // Teste do endpoint Hong Kong Bitcoin ETF Flow History
            var hongKongBitcoinEtfFlowHistory = await service.GetHongKongBitcoinEtfFlowHistoryAsync();
            foreach (var flow in hongKongBitcoinEtfFlowHistory)
            {
                Console.WriteLine($"Timestamp: {flow.Timestamp}, Flow: {flow.Flow}");
            }
            // Teste do endpoint ETF Flows History
            var etfFlowsHistory = await service.GetEtfFlowsHistoryAsync();
            foreach (var flow in etfFlowsHistory)
            {
                Console.WriteLine($"Timestamp: {flow.Timestamp}, Flow: {flow.Flow}");
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
