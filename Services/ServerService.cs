using BattleMetricsAPI.Clients;
using BattleMetricsAPI.DTO;
using BattleMetricsAPI.Models;
using System.Collections.Immutable;

namespace BattleMetricsAPI.Services
{
    public class ServerService : IServerService
    {
        private readonly IServersClient _serversClient;

        public ServerService(IServersClient serversClient) 
        {
            _serversClient = serversClient;
        }

        public async Task<List<ServerDTO>> GetServersAsync(string game, int page)
        {
            var serverDatas = await _serversClient.GetServersAsync(game, page);

            try
            {
                var response = serverDatas.Data.Select(x => new ServerDTO
                {
                    ServerName = x.Attributes.Name,
                    Rank = x.Attributes.Rank,
                    Status = x.Attributes.Status,
                    IP = x.Attributes.Ip,
                    Port = x.Attributes.Port,
                    OnlinePlayers = x.Attributes.Players,
                    MaxOnlinePlayers = x.Attributes.MaxPlayers

                }).ToList();
                return response;
            }
            catch (HttpRequestException httpEx)
            {
                throw new Exception($"HTTP request error: {httpEx.Message}");
            }
        }
    }
}
