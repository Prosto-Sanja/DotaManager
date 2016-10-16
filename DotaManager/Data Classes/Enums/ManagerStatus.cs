using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaManager.Data_Classes.Enums
{
    internal enum ManagerStatus
    {
        Stopped = 0,
        Connecting = 1,
        LoggingIn = 2,
        Online = 3,
        InGame = 4
    };
}
