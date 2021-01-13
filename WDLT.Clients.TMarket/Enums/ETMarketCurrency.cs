using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WDLT.Clients.TMarket.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ETMarketCurrency
    {
        RUB,
        USD,
        EUR
    }
}