using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillingSystem.Data;

namespace BillingSystem
{
    class UnityCollections
    {
        public ICollection<User> userItems { get; private set; }

        public ICollection<Phone> phoneItems { get; private set; }

        public ICollection<Agreement> agreementItems { get; private set; }
    }
}
