using BattleMetricsAPI.Models;

namespace BattleMetricsAPI.Clients
{
    public interface IServersClient
    {
        Task<ServerObjectModel> GetServersAsync(string game, int page);
    }
}
