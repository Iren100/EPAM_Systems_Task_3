﻿using System;

namespace AutomaticStation
{
    [DllImport("winscard.dll")]
    public class Terminal//: ILinkTarget
    {
        private Guid _id = new Guid();

        public TerminalController terminalController { get; private set; }

        public User user { get; set; }


        public Terminal()
        {
            this.terminalController = new TerminalController();
        }
    }
}
