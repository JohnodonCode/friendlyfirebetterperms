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
        public static Plugin Instance;
        private Handlers _handler;

        public override void OnEnabled()
        {
            Log.Info("friendlyfirebetterperms.dll is now running.");

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