using BattleMetricsAPI.Models;
using BattleMetricsAPI.DTO;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BattleMetricsAPI.Clients
{
    public class ServersClient : IServersClient
    {
        private readonly HttpClient _httpClient;

        public ServersClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ServerObjectModel> GetServersAsync(string game, int page)
        {
            var url = $"https://api.battlemetrics.com/servers?page[size]={page}&filter[game]={game}";
        
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            try
            {
                var content = await response.Content.ReadAsStringAsync();
                var serverjson = JsonSerializer.Deserialize<ServerObjectModel>(content, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return serverjson;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }



        }
    }
}
