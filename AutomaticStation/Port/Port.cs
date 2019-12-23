using System;

namespace AutomaticStation
{
    public class Port
    {
        public Guid Id = new Guid();

        //private Terminal _activeTerminal;


        #region properties

        public PortController portController { get; private set; }

        public PortStatus Status { get; set; }

        #endregion


        public Port()
        {
            this.Status = PortStatus.Free;
            this.portController = new PortController();
        }


   
    }
}
