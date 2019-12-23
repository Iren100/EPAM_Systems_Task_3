
namespace BillingSystem.Data
{
    public class Phone
    {
        public string Number { get; set; }

        //public Station station { get; set; } // не уверена, что нужно

        public Phone(string number)
        {
            Number = number;
        }
    }
}
