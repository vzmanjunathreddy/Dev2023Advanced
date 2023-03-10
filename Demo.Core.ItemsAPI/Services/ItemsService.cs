using Demo.Core.ItemsAPI.HelperClasses;
using Demo.Core.ItemsAPI.Interfaces;
using Demo.Core.ItemsAPI.Models;
using Newtonsoft.Json;

namespace Demo.Core.ItemsAPI.Services
{
    public class ItemsService : IItemsService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly TokenHelper _tokenHelper;

        public ItemsService(HttpClient httpClient, IConfiguration configuration, TokenHelper tokenHelper)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _tokenHelper = tokenHelper;
        }

        public async Task<Orders> GetOrderItems()
        {
            Orders orders = null;

            try
            {

                var accessToken = await _tokenHelper.GetAccessToken();

                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");

                var response = await _httpClient.GetAsync(_configuration["Appsettings:OrderAPIUrl"]);

                if (response.IsSuccessStatusCode)
                {
                    var orderStringResponse = await response.Content.ReadAsStringAsync();

                    orders = JsonConvert.DeserializeObject<Orders>(orderStringResponse)!;
                }

                return orders!;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
