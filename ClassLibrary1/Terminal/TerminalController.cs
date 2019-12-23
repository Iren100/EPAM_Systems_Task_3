using System;

namespace AutomaticStation
{
    public class TerminalController
    {
        private Port _port;

        public TerminalController(Port port)
        {
            _port = port;
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

            CallEventArgs e = new CallEventArgs(port,terminal);
            port.portController.OnCallRequested(e);

            //сохраняем порт у себя
            _port = port;//portId;

            //меняем статус
            _port.Status = PortStatus.Busy;

            //оповестить порт
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
            _port.portController.CallRequested -= OnCallRequested;

            //меняем статус
            _port.Status = PortStatus.Free;

            _port = null;//Guid.Empty;
        }


        public void OnCallAnswered(CallEventArgs e)
        {
            EventHandler<CallEventArgs> handler = CallAnswered;
            if (handler != null)
            {
                handler(this, e);
            }
        }



        #endregion

    }
}
