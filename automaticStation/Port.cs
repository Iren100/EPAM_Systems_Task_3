using System;

namespace AutomaticStation
{
    public class Port
    {

        private int Id;

        private Terminal activeTerminal;


        //объявление событий Event Hundler
        #region EventHundler


        public event EventHandler<CallEventArgs> CallRequested;


        #endregion


        #region properties

        private PortStatus portStatus { get; set; }

        #endregion


        #region metods

        public void OnCallRequested(CallEventArgs e) => CallRequested(this, e);

        //подключение к терминалу
        public void ConnectToTerminal(Terminal terminal)
        {
            terminal.SubscribeToPort(this.Id);

            //подписка на события порта
            CallRequested += OnCallRequested;
        }

        //отключение от терминала
        public void DisconnectFromTerminal(Terminal terminal)
        {
            terminal.UnsubscribeFromPort(this.Id);

            //отписка от событий порта
            CallRequested -= OnCallRequested;
        }

        #endregion
    }
}
