using System;
using UnitOfWorkClass.Link;

namespace AutomaticStation
{
    //класс для отслеживания измения состояния порта
    public class PortController// : ILinkSource
    {
        public PortController()
        {
            //this.port = port;
            CallRequested = OnCallRequested;
        }

        //public object GetState()
        //{
        //    throw new NotImplementedException();
        //}

        //public Port port { get; private set; }

        //объявление событий Event Hundler
        #region EventHundler

        //говорит терминалу, что на него звонят
        public event EventHandler<CallEventArgs> CallRequested;

        //получает ответ от терминала
        public event EventHandler<CallEventArgs> CallAnswered;

        #endregion


        #region metods

        private void OnCallRequested(Object sender, CallEventArgs e)
        {
            //code
        }

        #endregion
    }
}
