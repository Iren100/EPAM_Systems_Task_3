using System;
using BillingSystem.Data;

namespace AutomaticStation
{
    public class Port
    {
        public Guid Id = new Guid();

        public Station Station { get; set; }

        //private Terminal _activeTerminal;


        #region properties

        public PortController portController { get; private set; }

        public PortStatus Status { get; set; }

        #endregion


        public Port(Station station)
        {
            this.Status = PortStatus.Free;
            this.portController = new PortController();
        }   
    }
}
