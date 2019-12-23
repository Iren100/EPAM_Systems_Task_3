using System.Collections.Generic;
using BillingSystem.Data;

namespace BillingSystem.Collections
{
    public static class UnityCollections
    {
        public static ICollection<User> userItems { get; private set; } = new List<User>();

        public static ICollection<Phone> phoneItems { get; private set; } = new List<Phone>();

        public static ICollection<Agreement> agreementItems { get; private set; } = new List<Agreement>();

        public static ICollection<CallHistory> callHistorytItems { get; private set; } = new List<CallHistory>();
    }
}
