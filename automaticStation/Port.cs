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

        public void Port_CallRequested(Object sender, CallEventArgs e) => CallRequested(this,e);

        //подключение к терминалу
        public void Port_CallRequested(Terminal terminal, CallEventArgs e)
        {
            terminal.SubscribeToPort(this.Id);

            //подписка на события порта
            CallRequested += Port_CallRequested;
        }

        //отключение от терминала
        public void DisconnectFromTerminal(Terminal terminal, CallEventArgs e)
        {
            terminal.UnsubscribeFromPort(this.Id);

            //отписка от событий порта
            CallRequested -= Port_CallRequested;
        }

        #endregion
    }
}
