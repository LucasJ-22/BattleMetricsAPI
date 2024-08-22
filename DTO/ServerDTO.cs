namespace BattleMetricsAPI.DTO
{
    public class ServerDTO
    {
        public string ServerName { get; set; }
        public int Rank { get; set; }
        public string Status { get; set; }
        public string IP {  get; set; }
        public int Port { get; set; }
        public int OnlinePlayers { get; set;}
        public int MaxOnlinePlayers { get; set;}
    }
}
