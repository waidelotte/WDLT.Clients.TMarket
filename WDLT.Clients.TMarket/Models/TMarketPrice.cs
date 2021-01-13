using Newtonsoft.Json;

namespace WDLT.Clients.TMarket.Models
{
    public class TMarketPrice
    {
        [JsonProperty("market_hash_name")]
        public string MarketHashName { get; set; }

        [JsonProperty("volume")]
        public long Volume { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }
    }
}