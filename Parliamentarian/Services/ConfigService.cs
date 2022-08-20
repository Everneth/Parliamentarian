using Discord.WebSocket;
using Parliamentarian.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using Newtonsoft.Json;

namespace Parliamentarian.Services
{
    public class ConfigService
    {
        private DiscordSocketClient _client;
        private DataService _data;
        private IServiceProvider _services;
        public BotConfig BotConfig { get; set; }

        public ConfigService(IServiceProvider services)
        {
            _client = services.GetRequiredService<DiscordSocketClient>();
            _data = services.GetRequiredService<DataService>();
            _services = services;
            BotConfig = _data.Load("config", BotConfig);
        }
    }
}
