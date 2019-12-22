using System;

namespace AutomaticStation
{
    public class Port
    {
        private Guid _id = new Guid();

        private Terminal activeTerminal;


        #region properties

        private PortStatus portStatus { get; set; }

        #endregion


        public Port()
        {
            this.portStatus = PortStatus.IsFree;
        }


        //объявление событий Event Hundler
        #region EventHundler

        public event EventHandler<CallEventArgs> CallRequested; //запрос на соединение к порту

        #endregion


        #region metods

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
        public void Port_Disconnect()
        {
            //terminal.UnsubscribeFromPort();

            //отписка от событий порта
            CallRequested -= OnCallRequested;

            activeTerminal = null;
        }

        #endregion
    }
}
