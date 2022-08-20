using System;
using System.Collections.Generic;
using System.Linq;
using Parliamentarian.Services;
using Microsoft.Extensions.DependencyInjection;
using Discord.Interactions;
using Discord.WebSocket;
using System.Text;
using System.Threading.Tasks;

namespace Parliamentarian.Commands
{
    [Group("amendment", "All commands relating to the charter amendment process")]
    public class AmendmentModule : InteractionModuleBase<SocketInteractionContext>
    {
        private readonly DatabaseService _database;
        public AmendmentModule(IServiceProvider services)
        {
            _database = services.GetRequiredService<DatabaseService>();
        }

        [SlashCommand("propose", "Make a proposal to parliament")]
    }
}
