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
            this.Status = PortStatus.Free;
        }


        //объявление событий Event Hundler
        #region EventHundler

        public event EventHandler<CallEventArgs> CallRequested; //говорит терминалу, что на него звонят

        #endregion


        #region metods

        private void OnCallRequested(Object sender, CallEventArgs e) => CallRequested(this,e);

        //private CallRequested call()
        //{

        //}

        #endregion
    }
}
