using System;

namespace BillingSystem.Data
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name {
                             get { return  firstName + " " + lastName + " " + patronymicName; }
                             set { value = firstName + " " + lastName + " " + patronymicName; }
                           }


        #region Other fields

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string patronymicName { get; set; }
        
        public string Adress { get; set; }

        public string mail { get; set; }

        #endregion
    }
}
