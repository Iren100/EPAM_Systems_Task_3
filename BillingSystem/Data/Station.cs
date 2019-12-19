using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Data
{
    class Station: IElementId, IElementName
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
