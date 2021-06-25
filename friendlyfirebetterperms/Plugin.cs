using Exiled.API.Features;
using System;

namespace friendlyfirebetterperms
{
    public class Plugin : Plugin<Config>
    {
        // Metadata
        public override string Author { get; } = "Johnodon";
        public override string Name { get; } = "FriendlyFireBetterPerms";
        public override string Prefix { get; } = "FFBP";
        public override Version Version { get; } = new Version(1, 3, 0);
        public override Version RequiredExiledVersion { get; } = new Version(2, 8, 0);
    }
}