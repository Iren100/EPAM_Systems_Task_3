using System;

namespace AutomaticStation
{
    public class Terminal//: ILinkTarget
    {
        private Guid _id = new Guid();

        private Port _activePort;


        //delegate void call(); //метод
        //event call Notify; // событие   

        //public void Update(int commandId, Dictionary<string, object> parameters)
        //{
        //    throw new NotImplementedException();
        //}


        //объявление событий Event Hundler
        #region EventHundler

        public event EventHandler<CallEventArgs> CallRequested;

        #endregion


        ////подписка
        //public void SubscribeToPort(int portId)
        //{

        //}

        ////отписка
        //public void UnsubscribeFromPort()
        //{

        //}

        #region metods

        //public void OnCallRequested(Object sender, CallEventArgs e) => CallRequested(this, e);

        //подключение к порту
        public void ConnectToPort(Port port)//(Guid portId)
        {
            //SubscribeToPort(portId);

            //подписка на события порта
            CallRequested += port.OnCallRequested;

            //сохраняем порт у себя
            _activePort = port;//portId;

            //меняем статус
            port.Status = PortStatus.Busy;
        }

        //отключение от порта
        public void DisconnectFromPort()
        {
            //UnsubscribeFromPort();

            //отписка от событий порта
            CallRequested -= _activePort.OnCallRequested;

            //меняем статус
            _activePort.Status = PortStatus.Free;

            _activePort = null;//Guid.Empty;
        }

        #endregion
    }
}
