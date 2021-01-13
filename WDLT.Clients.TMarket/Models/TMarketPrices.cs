using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using WDLT.Clients.TMarket.Enums;

namespace WDLT.Clients.TMarket.Models
{
    public class TMarketPrices
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset Time { get; set; }

        [JsonProperty("currency")]
        public ETMarketCurrency Currency { get; set; }

        [JsonProperty("items")]
        public List<TMarketPrice> Items { get; set; }
    }
}