using System;

namespace BillingSystem.Data
{
    public class CallHistory
    {
        private Guid Id = new Guid();

        public DateTime Date { get; set; }

        public Phone IncomingCallNumber { get; set; }

        public Phone OutgoingCallNumber { get; set; }

        public TimeSpan Duration { get; set; }

        public int Sum { get; set; }

        public User User { get; set; }

        //для упрощения вывода в отчет
        public string UserName { get; set; }


        public CallHistory(DateTime date, Phone incomingCallNumber, Phone outgoingCallNumber, 
                            TimeSpan duration, int sum, User user)
        {
            Date = date;
            IncomingCallNumber = incomingCallNumber;
            OutgoingCallNumber = outgoingCallNumber;
            Duration = duration;
            Sum = sum;
            User = user;
            UserName = User.Name;
        }
    }
}
