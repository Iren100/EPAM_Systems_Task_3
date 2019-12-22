using System;

namespace AutomaticStation
{
    public class Port
    {
        public Guid Id = new Guid();

        private Terminal _activeTerminal;


        #region properties

        public PortStatus Status { get; set; }

        #endregion


        public Port()
        {
            this.Status = PortStatus.IsFree;
        }


        //объявление событий Event Hundler
        #region EventHundler

        public event EventHandler<CallEventArgs> CallRequested; //запрос на соединение к порту

        #endregion


        #region metods

        public void OnCallRequested(Object sender, CallEventArgs e) => CallRequested(this,e);

        //подключение к терминалу
        public void Connect(Terminal terminal)
        {
            //terminal.SubscribeToPort(this.Id);

            if (Status == PortStatus.TurnOn || Status == PortStatus.IsFree)
            {
                //подписка на события порта
                CallRequested += OnCallRequested;
                //сохраняем порт у себя
                _activeTerminal = terminal;
                //меняем статус
                Status = PortStatus.Connect;
            }
        }

        //отключение от терминала
        public void Disconnect()
        {
            //terminal.UnsubscribeFromPort();

            if (Status == PortStatus.Busy || Status == PortStatus.Connect)
            {
                //отписка от событий порта
                CallRequested -= OnCallRequested;
                //обнуляем порт
                _activeTerminal = null;
                //меняем статус
                Status = PortStatus.Disconnect;
            }
        }

        #endregion
    }
}
