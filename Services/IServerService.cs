using BattleMetricsAPI.DTO;
using BattleMetricsAPI.Models;

namespace BattleMetricsAPI.Services
{
    public interface IServerService
    {
        Task<List<ServerDTO>> GetServersAsync(string game, int page);
    }
}
