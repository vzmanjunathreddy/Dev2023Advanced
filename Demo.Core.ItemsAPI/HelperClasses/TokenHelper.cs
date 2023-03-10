using Demo.Core.ItemsAPI.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace Demo.Core.ItemsAPI.HelperClasses
{
    public class TokenHelper
    {
        private IConfiguration _configuration;
        private HttpClient _httpClient;
        public TokenHelper(IConfiguration configuration, HttpClient httpClient)
        {
            _configuration = configuration;
            _httpClient = httpClient;
        }
        public async Task<string> GetAccessToken()
        {
            string accessToken = string.Empty;

            try
            {
                var person = new User(_configuration["Appsettings:UserName"]!, _configuration["Appsettings:Password"]!);

                var json = JsonConvert.SerializeObject(person);

                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(_configuration["Appsettings:AccessTokenURL"]!, data);

                accessToken = await response.Content.ReadAsStringAsync();

                accessToken = accessToken.Replace("\"", string.Empty).Trim();

            }
            catch (Exception ex)
            {

            }

            return accessToken!;

        }
    }
}
