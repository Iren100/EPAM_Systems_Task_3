using System;

namespace BillingSystem.Data
{
    public class CallsHistory
    {
        public Guid Id { get; set; }

        public Phone incomingCallNumber { get; set; }

        public Phone outgoingCallNumber { get; set; }
    }
}
