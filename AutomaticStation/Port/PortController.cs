using System;

namespace AutomaticStation
{
    //класс для отслеживания измения состояния порта
    public class PortController// : ILinkSource
    {
        public PortController()
        {
            
        }


        //объявление событий Event Hundler
        #region EventHundler

        //говорит терминалу, что на него звонят
        public event EventHandler<CallEventArgs> CallRequested;

        #endregion

        public void OnCallRequested(CallEventArgs e)
        {
            EventHandler<CallEventArgs> handler = CallRequested;
            if (handler != null)
            {
                handler(this, e);
            }
        }


        #region metods


        #endregion
    }
}
