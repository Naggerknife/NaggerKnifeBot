using System;
using NaggerknifeBotV2.Discord;
using NaggerknifeBotV2.Discord.Entities;

namespace NaggerknifeBotV2
{
    internal class Program
    {


        private static void Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello Discord!");

            var discordBotConfig = new NaggerknifeBotConfig
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };
        }
    }

}
