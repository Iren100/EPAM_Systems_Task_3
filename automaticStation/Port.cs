using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticStation
{
    public class Port
    {

        private int Id;

        private Terminal activeTerminal;

        #region properties

        private PortStatus portStatus { get; set; }

        #endregion


        #region metods

        //подключение к терминалу
        public void ConnectToTerminal(Terminal terminal)
        {
            terminal.SubscribeToPort(this);

            //подписка на события порта
        }

        //отключение от терминала
        public void DisconnectFromTerminal(Terminal terminal)
        {
            terminal.UnsubscribeFromPort(this);

            //отписка от событий порта
        }

        #endregion
    }
}
