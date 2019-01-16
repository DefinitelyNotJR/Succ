using System.Threading.Tasks;
using Discord.Commands;
using Discord.WebSocket;
using SuccBot.Services;

namespace SuccBot.Modules.AudioModule
{
    public class AudioModule : ModuleBase<SocketCommandContext>
    {
        public AudioService AudioService { get; set; }

        [Command("join", RunMode = RunMode.Async)]
        public async Task JoinAsync()
        {
            await ReplyAsync("", false, await AudioService.JoinAsync((SocketGuildUser)Context.User, Context.Channel, Context.Guild.Id));
        }

        [Command("leave", RunMode = RunMode.Async)]
        public async Task LeaveAsync()
        {
            await ReplyAsync("", false, await AudioService.LeaveAsync(Context.Guild.Id));
        }
    }
}