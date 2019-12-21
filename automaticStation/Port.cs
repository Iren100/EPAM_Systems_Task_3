using System;

namespace AutomaticStation
{
    public class Port
    {

        private int id;

        private Terminal activeTerminal;


        //объявление событий Event Hundler
        #region EventHundler

        public event EventHandler<CallEventArgs> CallRequested;

        #endregion


        #region properties

        private PortStatus portStatus { get; set; }

        #endregion


        

        public void OnCallRequested(Object sender, CallEventArgs e) => CallRequested(this,e);

        //подключение к терминалу
        public void Port_CallRequested(Terminal terminal)
        {
            //terminal.SubscribeToPort(this.Id);

            //подписка на события порта
            CallRequested += OnCallRequested;

            //сохраняем порт у себя
            activeTerminal = terminal;
        }

        //отключение от терминала
        public void Port_Disconnect(Terminal terminal)
        {
            //terminal.UnsubscribeFromPort();

            //отписка от событий порта
            CallRequested -= OnCallRequested;

            activeTerminal = null;
        }

        #endregion
    }
}
