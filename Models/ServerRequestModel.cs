using System.ComponentModel.DataAnnotations;

namespace BattleMetricsAPI.Models
{
    public class ServerRequestModel
    {
        [Required]
        public string Game { get; set; }

        public int Page { get; set; } = 1;
    }
}
