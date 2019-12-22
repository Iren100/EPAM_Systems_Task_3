using System;

namespace AutomaticStation
{
    public class Port
    {
        public Guid Id = new Guid();

        //private Terminal _activeTerminal;


        #region properties

        public PortStatus Status { get; set; }

        #endregion


        public Port()
        {
            this.Status = PortStatus.Free;
            CallRequested = OnCallRequested;
        }


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
