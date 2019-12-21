using System;

namespace BillingSystem.Data
{
    public class Call
    {
        public Guid Id { get; set; }

        public Phone incomingCallNumber { get; set; }

        public Phone outgoingCallNumber { get; set; }
    }
}
