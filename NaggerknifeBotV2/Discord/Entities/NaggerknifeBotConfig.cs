using Discord.WebSocket;

namespace NaggerknifeBotV2.Discord.Entities
{
    public class NaggerknifeBotConfig
    {
        public string Token { get; set; }
        public DiscordSocketConfig SocketConfig { get; set; }
    }
}