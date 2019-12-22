using System;

namespace AutomaticStation
{
    public class Terminal//: ILinkTarget
    {
        private Guid _id = new Guid();

        private Port _activePort;

        public Terminal()
        {
            CallAnswered = OnCallAnswered;
        }


        //delegate void call(); //метод
        //event call Notify; // событие   

        //public void Update(int commandId, Dictionary<string, object> parameters)
        //{
        //    throw new NotImplementedException();
        //}


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
            port.CallRequested += CallRequested;

            //сохраняем порт у себя
            _activePort = port;//portId;

            //меняем статус
            port.Status = PortStatus.Busy;

            //оповестить порт
            port.CallAnswered += CallAnswered;
        }

        //отключение от порта
        public void DisconnectFromPort()
        {
            //отписка от событий порта
            _activePort.CallRequested -= CallRequested;

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
