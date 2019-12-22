using System;
using AutomaticStation;

namespace BillingSystem.Data
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name {
                             get { return  firstName + " " + lastName + " " + patronymicName; }
                             set { value = firstName + " " + lastName + " " + patronymicName; }
                           }

        private Port _port { get; set; }


        #region Other fields

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string patronymicName { get; set; }
        
        public string Adress { get; set; }

        public string mail { get; set; }

        #endregion


        #region metods

        //абоненст может самостоятельно подключать телефон к порту станции
        public void connectToPort()
        {
            Port port = new Port();
            CallEventArgs e = new CallEventArgs();
            port.OnCallRequested(this, e);

            _port = port;
        }        
        
        //абоненст может самостоятельно отключать телефон от порта станции
        public void disconnectFromPort()
        {
            _port.Port_Disconnect();
        }

        #endregion
    }
}
