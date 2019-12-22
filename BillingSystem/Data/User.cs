using System;
using AutomaticStation;

namespace BillingSystem.Data
{
    public class User
    {
        private Guid _id = new Guid();

        public string Name {
                             get { return  FirstName + " " + LastName + " " + PatronymicName; }
                             private set { value = FirstName + " " + LastName + " " + PatronymicName; }
                           }

        private Port _port { get; set; }


        #region Other fields

        private string FirstName { get; set; }

        private string LastName { get; set; }

        private string PatronymicName { get; set; }
        
        private string Adress { get; set; }

        private string Mail { get; set; }

        #endregion


        public User(Port port, string firstName, string lastName, string patronymicName, string adress, string mail)
        {
            _port = port;
            LastName = lastName;
            PatronymicName = patronymicName;
            Adress = adress;
            Mail = mail;
        }


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
