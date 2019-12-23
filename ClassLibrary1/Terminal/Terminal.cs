using System;
using BillingSystem.Data;

namespace AutomaticStation
{
    public class Terminal
    {
        private Guid _id = new Guid();

        public TerminalController terminalController { get; private set; }

        public User user { get; set; }

        public Port port { get; set; }


        public Terminal()
        {
            this.terminalController = new TerminalController(port);
        }
    }
}
