using System;
using BillingSystem.Data;

namespace AutomaticStation
{
    public class Terminal
    {
        private Guid _id = new Guid();

        public TerminalController TerminalController { get; private set; }

        public User User { get; set; }

        public Port Port { get; set; }

        public Phone Phone { get; set; }


        public Terminal(Phone phone)
        {
            Phone = phone;
            TerminalController = new TerminalController(Port);
        }
    }
}
