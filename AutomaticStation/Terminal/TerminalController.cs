using System;

namespace AutomaticStation
{
    public class TerminalController
    {
        private Port _activePort;

        public TerminalController()
        {
         
        }

        //объявление событий Event Hundler
        #region EventHundler

        //сообщает порту, что к нему подключились
        public event EventHandler<CallEventArgs> CallAnswered;

        #endregion


        #region metods

        //подключение к порту
        public void ConnectToPort(Terminal terminal, Port port)//(Guid portId)
        {
            //подписка на событие
            port.portController.CallRequested += OnCallRequested;

            CallEventArgs e = new CallEventArgs();
            port.portController.OnCallRequested(e);

            //сохраняем порт у себя
            _activePort = port;//portId;

            //меняем статус
            _activePort.Status = PortStatus.Busy;

            //оповестить порт
            CallAnswered += OnCallAnswered;
            OnCallAnswered(e);
        }

        private void OnCallRequested(Object sender, CallEventArgs e)
        {
            Console.WriteLine("Получен ответ от терминала!");          
        }

        //отключение от порта
        public void DisconnectFromPort()
        {
            //отписка от событий порта
            _activePort.portController.CallRequested -= OnCallRequested;

            //меняем статус
            _activePort.Status = PortStatus.Free;

            _activePort = null;//Guid.Empty;
        }


        public void OnCallAnswered(CallEventArgs e)
        {
            EventHandler<CallEventArgs> handler = CallAnswered;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnCallAnswered(Object sender, CallEventArgs e)
        {
            Console.WriteLine("Оповещен порт!");
        }

        #endregion

    }
}
