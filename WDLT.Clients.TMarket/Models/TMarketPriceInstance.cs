using Newtonsoft.Json;

namespace WDLT.Clients.TMarket.Models
{
    public class TMarketPriceInstance
    {
        [JsonProperty("market_hash_name")]
        public string MarketHashName { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("buy_order")]
        public double BuyOrder { get; set; }

        [JsonProperty("avg_price")]
        public double? AvgPrice { get; set; }

        [JsonProperty("popularity_7d")]
        public int? PopularityWeek { get; set; }
    }
}