using BattleMetricsAPI.Models;
using BattleMetricsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BattleMetricsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServersController : ControllerBase
    {
        private readonly ILogger<ServersController> _logger;
        private readonly IServerService _serverService;

        public ServersController(ILogger<ServersController> logger, IServerService serverService)
        {
            _logger = logger;
            _serverService = serverService;
        }

        /// <summary>
        ///     Get Listed Servers for a game that you want passing it's name
        /// </summary>
        /// <returns>Nome do servidor, Rank, Status, IP, Porta, Número de jogadores online, limite máximo de jogadores online</returns>
        /// <param name="game">Name of the game that you want to list the servers</param>
        /// <param name="page">Quantity of the servers that will be list per page</param>
        /// <response code="200">Returns the servers of a game</response>
        /// <response code="400">Returns bad request</response>
        [HttpGet(Name = "Server List")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetServer(string game, int page = 1)
        {
            var servers = await _serverService.GetServersAsync(game, page);
            return Ok(servers);
        }
    }
}
