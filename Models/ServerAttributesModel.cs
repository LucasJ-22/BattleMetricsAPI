namespace BattleMetricsAPI.Models
{
    public class ServerAttributesModel
    {
        public string Name { get; set; }
        public string Ip { get; set; }
        public int Port { get; set; }
        public int Players { get; set; }
        public int MaxPlayers { get; set; }
        public int Rank { get; set; }
        public string Status { get; set; }
    }
}
