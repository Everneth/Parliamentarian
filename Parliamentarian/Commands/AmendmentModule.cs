using System;
using System.Collections.Generic;
using System.Linq;
using Parliamentarian.Services;
using Parliamentarian.Models.Enums;
using Microsoft.Extensions.DependencyInjection;
using Discord.Interactions;
using Parliamentarian.Extensions;
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
        public async Task MakeProposal(string title, AmendmentType amendmentType, AmendmentSection amendmentSection, string text)
        {
            await RespondAsync(String.Format($"TITLE: {title}\nTYPE: {amendmentType.GetDisplayName()}\nSECTION: {amendmentSection.GetDisplayName()}\nTEXT: {text}"));
        }
    }
}
