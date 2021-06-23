using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ServerE = Exiled.Events.Handlers.Server;
using RACommand = Exiled.Events.EventArgs.SendingRemoteAdminCommandEventArgs;

namespace friendlyfirebetterperms
{
    public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "Johnodon";
        public override string Name { get; } = "FriendlyFireBetterPerms";
        public override string Prefix { get; } = "FFBP";
        public override Version Version { get; } = new Version(1, 2, 0);
        public override Version RequiredExiledVersion { get; } = new Version(2, 8, 0);

        public static Plugin Instance;
        private Handlers _handler;

        public override void OnEnabled()
        {
            Log.Info("friendlyfirebetterperms.dll is enabled.");

            Instance = this;

            _handler = new Handlers();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {

            _handler = null;
            Instance = null;
            base.OnDisabled();
        }
    }
}