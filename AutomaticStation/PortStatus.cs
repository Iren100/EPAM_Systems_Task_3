using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticStation
{
    // BPort Status
    public enum PortStatus
    {
        /// <summary>
        /// busy/is free
        /// </summary>
        Busy,
        /// <summary>
        /// turn on/turn off
        /// </summary>
        TurnOn,
        /// <summary>
        /// connect/disconnect
        /// </summary>
        Connect
    }
}
