using System;

namespace AutomaticStation
{
    class TerminalController
    {
        private Port _activePort;

        public TerminalController()
        {
            CallAnswered = OnCallAnswered;
        }

        //объявление событий Event Hundler
        #region EventHundler

        public event EventHandler<CallEventArgs> CallRequested;

        //сообщает порту, что к нему подключились
        public event EventHandler<CallEventArgs> CallAnswered;

        #endregion


        #region metods

        //подключение к порту
        public void ConnectToPort(Port port)//(Guid portId)
        {
            //подписка на события терминала
            port.portController.CallRequested += CallRequested;

            //сохраняем порт у себя
            _activePort = port.portController.port;//portId;

            //меняем статус
            _activePort.Status = PortStatus.Busy;

            //оповестить порт
            port.portController.CallAnswered += CallAnswered;
        }

        //отключение от порта
        public void DisconnectFromPort()
        {
            //отписка от событий порта
            _activePort.portController.CallRequested -= CallRequested;

            //меняем статус
            _activePort.Status = PortStatus.Free;

            _activePort = null;//Guid.Empty;
        }

        private void OnCallAnswered(Object sender, CallEventArgs e)
        {
            //code
        }

        #endregion

    }
}
