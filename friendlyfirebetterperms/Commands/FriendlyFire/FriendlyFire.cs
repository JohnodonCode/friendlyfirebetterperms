using CommandSystem;
using Exiled.API.Features;
using Exiled.API.Extensions;
using RemoteAdmin;
using System;
using Exiled.Permissions.Extensions;

namespace friendlyfirebetterperms.Commands.FriendlyFire
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class FriendlyFire : ParentCommand
    {
        public FriendlyFire() => LoadGeneratedCommands();

        public override string Command { get; } = "friendlyfire";

        public override string[] Aliases { get; } = new string[] { "ff" };

        public override string Description { get; } = "Enabled and Disabled Friendly Fire";

        public override void LoadGeneratedCommands() { }

        protected override bool ExecuteParent(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!sender.CheckPermission("friendlyfirebetterperms.use"))
            {
                response = "You do not have permission to use this command. (friendlyfirebetterperms.use)";
                return false;
            }

            if (arguments.Count < 1)
            {
                response = "Usage: friendlyfire (enable/disable)";
                return false;
            }

            switch(arguments.At(0).ToLower())
            {
                case "enable":
                    ServerConsole.FriendlyFire = true;
                    response = "Enabled Friendly Fire";
                    Log.Info("FriendlyFire enabled.");
                    return true;
                case "disable":
                    ServerConsole.FriendlyFire = false;
                    response = "Disabled Friendly Fire";
                    Log.Info("FriendlyFire disabled.");
                    return true;
                default:
                    response = "Invalid argument (0) Usage: friendlyfire (enable/disable)";
                    return false;
                    
            }
        }
    }
}
