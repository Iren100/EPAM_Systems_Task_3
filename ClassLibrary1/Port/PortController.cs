using System;

namespace AutomaticStation
{
    //класс для отслеживания измения состояния порта
    public class PortController// : ILinkSource
    {
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

            e.Terminal.terminalController.CallAnswered += OnCallAnswered;
        }

        private void OnCallAnswered(Object sender, CallEventArgs e)
        {
            Console.WriteLine("Оповещен порт!");
        }

        #region metods


        #endregion
    }
}
