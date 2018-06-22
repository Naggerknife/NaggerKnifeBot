using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using NaggerknifeBotV2.Discord.Entities;

namespace NaggerknifeBotV2.Discord
{
    public class Connection
    {
        private DiscordSocketClient _client;
        private readonly DiscordLogger _logger;

        public Connection(DiscordLogger logger)
        {
            _logger = logger;
        }

        internal async Task ConnectAsync(NaggerknifeBotConfig config)
        {
            _client = new DiscordSocketClient(config.SocketConfig);

            _client.Log += _logger.Log;
        }


    }
}