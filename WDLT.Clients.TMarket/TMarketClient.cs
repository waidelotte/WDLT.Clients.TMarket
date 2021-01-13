using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using WDLT.Clients.Base;
using WDLT.Clients.TMarket.Enums;
using WDLT.Clients.TMarket.Models;

namespace WDLT.Clients.TMarket
{
    public class TMarketClient : BaseClient
    {
        private const string CSGO_HOST = "https://market.csgo.com/api/v2";
        private const string DOTA_HOST = "https://market.dota2.net/api/v2";

        public TMarketClient(string userAgent) : base(userAgent) { } 

        public Task<IRestResponse<TMarketPrices>> CSGOPrices(ETMarketCurrency currency)
        {
            return _client.ExecuteAsync<TMarketPrices>(new RestRequest(CSGO_HOST + $"/prices/{currency}.json"));
        }

        public Task<IRestResponse<TMarketPrices>> DOTAPrices(ETMarketCurrency currency)
        {
            return _client.ExecuteAsync<TMarketPrices>(new RestRequest(DOTA_HOST + $"/prices/{currency}.json"));
        }

        public async Task<TMarketItemInstances> CSGOInstances(ETMarketCurrency currency)
        {
            var data = await _client.ExecuteAsync(new RestRequest(CSGO_HOST + $"/prices/class_instance/{currency}.json"));
            return JsonConvert.DeserializeObject<TMarketItemInstances>(data.Content);
        }

        public async Task<TMarketItemInstances> DOTAInstances(ETMarketCurrency currency)
        {
            var data = await _client.ExecuteAsync(new RestRequest(DOTA_HOST + $"/prices/class_instance/{currency}.json"));
            return JsonConvert.DeserializeObject<TMarketItemInstances>(data.Content);
        }
    }
}
