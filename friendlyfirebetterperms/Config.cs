using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace friendlyfirebetterperms
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
    }
}