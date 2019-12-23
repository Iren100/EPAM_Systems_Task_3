using System;

namespace BillingSystem.Data
{
    public class Phone
    {
        public Phone(string number)
        {
            Number = number;
        }

        public string Number { get; set; }

        //public Station station { get; set; } // не уверена, что нужно
    }
}
